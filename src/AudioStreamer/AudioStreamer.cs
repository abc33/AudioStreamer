/**
 * Copyright 2015 Davide Marchetti (@dvdmarchetti)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *    http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace AudioStreamer
{
    public partial class AudioStreamer : Form
    {
        // Stream Handler
        WStreamRepeater stream;

        public AudioStreamer()
        {
            // Initialize form components
            InitializeComponent();

            // Initialize the Stream Capture
            this.stream = new WStreamRepeater();
            
            // Show current connected output devices to the combobox
            this.scanDevices();
        }

        private void streamStart(object sender, EventArgs e)
        {
            // Switch state of Play/Stop buttons
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            // Update Text
            textServiceStatus.Text = "Running...";

            // Start streaming
            this.stream.Start();
        }

        private void streamEnd(object sender, EventArgs e)
        {
            // Switch state of Play/Stop buttons
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            // Update Text
            textServiceStatus.Text = "Stopped";

            // Stop streaming
            this.stream.End();
        }

        private void addOutputDevice(object sender, EventArgs e)
        {
            // If there is a selected item
            if (cmbDevice.SelectedIndex != -1)
            {
                // Check if device is already in list
                bool notInList = devicesList.Items.Cast<ComboBoxItem>()
                    .Where(m => m.interfaceGuid == ((ComboBoxItem)cmbDevice.SelectedItem).interfaceGuid)
                    .Where(n => n.Name == ((ComboBoxItem)cmbDevice.SelectedItem).Name)
                    .LongCount() == 0;

                // If not in list yet, add it
                if (notInList)
                {
                    // Read latency, buffer number and volume
                    int latency;
                    int bufferNumber;
                    float volume;

                    try
                    {
                        latency = Convert.ToInt32(settingsLatency.Value);
                    }
                    catch (Exception ex)
                    {
                        // Default value for fallback
                        latency = 200;
                    }

                    try
                    {
                        bufferNumber = Convert.ToInt32(settingsNumberOfBuffers.Value);
                    }
                    catch (Exception ex)
                    {
                        // Default value for fallback
                        bufferNumber = 2;
                    }

                    try
                    {
                        volume = (float)settingsVolume.Value / 100;
                    }
                    catch (Exception ex)
                    {
                        // Default value for fallback
                        volume = (float)0.5;
                    }

                    int deviceAdded = this.stream.AddDevice(((ComboBoxItem)cmbDevice.SelectedItem).interfaceGuid, (int)((ComboBoxItem)cmbDevice.SelectedItem).Value, latency, bufferNumber, volume);

                    // If device has been added successfully
                    if (deviceAdded == 0)
                    {
                        // Add the new wave to the output list
                        devicesList.Items.Add(cmbDevice.SelectedItem, CheckState.Checked);

                        // Enable Remove button
                        if (this.devicesList.Items.Count > 0)
                        {
                            btnRemoveOutput.Enabled = true;
                        }
                    }
                    else if (deviceAdded == -1)
                    {
                        MessageBox.Show("The choosen device cannot be added. Make sure no one else is currently using it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        /// <summary>
        /// <para>Toggle the state of a wave</para>
        /// </summary>
        /// <param name="sender">Toggle checkbox</param>
        /// <param name="e">Event informations</param>
        private void toggleDevice(object sender, ItemCheckEventArgs e)
        {
            this.stream.ToggleDevice(e.NewValue, e.Index);
        }

        private void toggleAdvancedOptions(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.panelAdvancedOptions.Visible = true;
            }
        }

        private void removeDevice(object sender, EventArgs e)
        {
            // If there is a selected item
            if (devicesList.SelectedIndex != -1)
            {
                // Ask a confirm to delete output
                DialogResult confirm = MessageBox.Show("Are you sure you want to remove this element from the output list?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (confirm == DialogResult.Yes)
                {
                    // Get current device
                    ComboBoxItem device = (ComboBoxItem)devicesList.Items[devicesList.SelectedIndex];

                    // Remove output from wave
                    this.stream.RemoveDevice(devicesList.SelectedIndex);
                    // Remove output from list
                    devicesList.Items.RemoveAt(devicesList.SelectedIndex);

                    // Disable Button
                    if (devicesList.Items.Count == 0)
                    {
                        btnRemoveOutput.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("You have to select one device from list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshDevices(object sender, EventArgs e)
        {
            // Remove current device selected
            cmbDevice.SelectedIndex = -1;

            // Scan for new devices
            this.scanDevices();
        }

        private void scanDevices()
        {
            // Remove all elements
            cmbDevice.Items.Clear();

            foreach (ComboBoxItem device in this.stream.scanAudioOutputDevices())
            {
                cmbDevice.Items.Add(device);
            }
        }
    }
}
