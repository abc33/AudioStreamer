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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NAudio.Wave;
using NAudio.CoreAudioApi;
using AudioStreamer.Types;
using NAudio;
using System.Windows.Forms;

namespace AudioStreamer
{
    class WStreamRepeater
    {
        /// <summary>
        /// <para>Windows Audio Stream</para>
        /// </summary>
        private WasapiLoopbackCapture streamIn;

        /// <summary>
        /// <para>List of all the waves connected to the waves</para>
        /// </summary>
        private List<BufferedWaveProvider> bufferedWaves;

        /// <summary>
        /// <para>List of all outputs added</para>
        /// </summary>
        private List<StreamWaveOut> outputs;

        /// <summary>
        /// <para>Tells if service is running or not</para>
        /// </summary>
        private bool isRunning;

        public WStreamRepeater()
        {
            // Service not running
            this.isRunning = false;

            // Create a new stream capture from windows
            this.streamIn = new WasapiLoopbackCapture();
            // Add event handling
            this.streamIn.DataAvailable += InputBufferToOutput;

            // Allocate a List of BufferedWaveProvider where each stream wave will be stored
            this.bufferedWaves = new List<BufferedWaveProvider>();
            // Allocate a List of WaveOut where each element will be one output device
            this.outputs = new List<StreamWaveOut>();
        }

        public void Start()
        {
            // Set service as running
            this.isRunning = true;

            // Start capture
            this.streamIn.StartRecording();
            // Start playing each wave
            foreach (StreamWaveOut wave in outputs)
            {
                // If output device is checked, play through it
                if (wave.isEnabled())
                {
                    wave.Play();
                }
            }
        }

        public void End()
        {
            // Set service as stopped
            this.isRunning = false;

            // Stop each wave
            foreach (StreamWaveOut wave in outputs)
            {
                // If output is enabled and playing, stop it
                if (wave.isEnabled() && wave.PlaybackState == PlaybackState.Playing)
                {
                    wave.Stop();
                }
            }
            // Stop capturing
            this.streamIn.StopRecording();
        }


        /// <summary>
        /// Write buffered audio to each registered wave
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event informations</param>
        private void InputBufferToOutput(object sender, WaveInEventArgs e)
        {
            // Write captured buffered bytes to each output wave active
            foreach (BufferedWaveProvider bufferedWave in this.bufferedWaves)
            {
                bufferedWave.AddSamples(e.Buffer, 0, e.BytesRecorded);
            }
        }

        /// <summary>
        /// <para>Scan for all the connected devices</para>
        /// </summary>
        public ComboBoxItem[] scanAudioOutputDevices()
        {
            // Get how much output devices are connected
            int outputDevicesCount = StreamWaveOut.DeviceCount;
            // Prepare List of items
            ComboBoxItem[] outputDevices = new ComboBoxItem[outputDevicesCount];

            // For each output device
            for (int deviceIndex = 0; deviceIndex < outputDevicesCount; deviceIndex++)
            {
                var c = StreamWaveOut.GetCapabilities(deviceIndex);
                // Get device name and add device to the output array
                outputDevices[deviceIndex] = new ComboBoxItem(StreamWaveOut.GetCapabilities(deviceIndex).ProductGuid, StreamWaveOut.GetCapabilities(deviceIndex).ProductName, deviceIndex);
            }

            return outputDevices;
        }

        public int AddDevice(Guid interfaceGuid, int deviceNumber, int latency, int bufferNumber, float volume)
        {
            // Create a new BufferedWaveProvider with same wave format as stream capture
            BufferedWaveProvider bufferedWave = new BufferedWaveProvider(streamIn.WaveFormat);
            // Prevent buffer overflow
            bufferedWave.DiscardOnBufferOverflow = true;

            // Create new wave
            StreamWaveOut wave = new StreamWaveOut(interfaceGuid);
            // Set Latency
            wave.DesiredLatency = latency;
            // Set number of buffers
            wave.NumberOfBuffers = bufferNumber;
            // Write current output device id number
            wave.DeviceNumber = deviceNumber;
            // Set volume
            wave.Volume = volume;

            try
            {
                // Initialize wave
                wave.Init(bufferedWave);
            }
            catch (MmException ex)
            {
                wave = null;
                bufferedWave = null;
                return -1;
            }

            // If stream capture is already running, start playing
            if (this.isRunning)
            {
                wave.Play();
            }

            // Save bufferedWave
            this.bufferedWaves.Add(bufferedWave);
            // Save wave
            this.outputs.Add(wave);

            return 0;
        }

        public void ToggleDevice(CheckState state, int deviceIndex)
        {
            // Get selected device
            StreamWaveOut device = this.outputs[deviceIndex];

            // Toggle Play/Stop state
            if (state == CheckState.Unchecked && device != null)
            {
                // Disable output from device
                device.Disable();

                if (this.isRunning)
                {
                    device.Stop();
                }
            }
            else if (state == CheckState.Checked && device != null)
            {
                // Enable output from device
                device.Enable();

                if (this.isRunning)
                {
                    device.Play();
                }
            }
        }

        public void RemoveDevice(int deviceIndex)
        {
            this.outputs[deviceIndex].Stop();
            this.outputs.RemoveAt(deviceIndex);
        }
    }
}
