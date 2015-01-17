namespace AudioStreamer
{
    partial class AudioStreamer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemoveOutput = new System.Windows.Forms.Button();
            this.panelAdvancedOptions = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.settingsVolume = new System.Windows.Forms.TrackBar();
            this.settingsNumberOfBuffers = new System.Windows.Forms.NumericUpDown();
            this.settingsLatency = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkAdvancedOptions = new System.Windows.Forms.CheckBox();
            this.devicesList = new System.Windows.Forms.CheckedListBox();
            this.btnAddOutput = new System.Windows.Forms.Button();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textServiceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.panelAdvancedOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsNumberOfBuffers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsLatency)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(351, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.streamStart);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnRemoveOutput);
            this.groupBox1.Controls.Add(this.panelAdvancedOptions);
            this.groupBox1.Controls.Add(this.checkAdvancedOptions);
            this.groupBox1.Controls.Add(this.devicesList);
            this.groupBox1.Controls.Add(this.btnAddOutput);
            this.groupBox1.Controls.Add(this.cmbDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PC Audio Stream Recorder";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh Devices";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.refreshDevices);
            // 
            // btnRemoveOutput
            // 
            this.btnRemoveOutput.Enabled = false;
            this.btnRemoveOutput.Location = new System.Drawing.Point(402, 242);
            this.btnRemoveOutput.Name = "btnRemoveOutput";
            this.btnRemoveOutput.Size = new System.Drawing.Size(101, 23);
            this.btnRemoveOutput.TabIndex = 8;
            this.btnRemoveOutput.Text = "Remove Output";
            this.btnRemoveOutput.UseVisualStyleBackColor = true;
            this.btnRemoveOutput.Click += new System.EventHandler(this.removeDevice);
            // 
            // panelAdvancedOptions
            // 
            this.panelAdvancedOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAdvancedOptions.Controls.Add(this.label5);
            this.panelAdvancedOptions.Controls.Add(this.settingsVolume);
            this.panelAdvancedOptions.Controls.Add(this.settingsNumberOfBuffers);
            this.panelAdvancedOptions.Controls.Add(this.settingsLatency);
            this.panelAdvancedOptions.Controls.Add(this.label4);
            this.panelAdvancedOptions.Controls.Add(this.label3);
            this.panelAdvancedOptions.Controls.Add(this.label2);
            this.panelAdvancedOptions.Location = new System.Drawing.Point(6, 106);
            this.panelAdvancedOptions.Name = "panelAdvancedOptions";
            this.panelAdvancedOptions.Size = new System.Drawing.Size(248, 130);
            this.panelAdvancedOptions.TabIndex = 7;
            this.panelAdvancedOptions.TabStop = false;
            this.panelAdvancedOptions.Text = "Advanced Wave Options";
            this.panelAdvancedOptions.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Volume:";
            // 
            // settingsVolume
            // 
            this.settingsVolume.Location = new System.Drawing.Point(57, 72);
            this.settingsVolume.Maximum = 100;
            this.settingsVolume.Name = "settingsVolume";
            this.settingsVolume.Size = new System.Drawing.Size(185, 45);
            this.settingsVolume.TabIndex = 10;
            this.settingsVolume.TickFrequency = 10;
            this.settingsVolume.Value = 50;
            // 
            // settingsNumberOfBuffers
            // 
            this.settingsNumberOfBuffers.Location = new System.Drawing.Point(107, 46);
            this.settingsNumberOfBuffers.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.settingsNumberOfBuffers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.settingsNumberOfBuffers.Name = "settingsNumberOfBuffers";
            this.settingsNumberOfBuffers.Size = new System.Drawing.Size(135, 20);
            this.settingsNumberOfBuffers.TabIndex = 9;
            this.settingsNumberOfBuffers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.settingsNumberOfBuffers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // settingsLatency
            // 
            this.settingsLatency.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.settingsLatency.Location = new System.Drawing.Point(107, 20);
            this.settingsLatency.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.settingsLatency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.settingsLatency.Name = "settingsLatency";
            this.settingsLatency.Size = new System.Drawing.Size(109, 20);
            this.settingsLatency.TabIndex = 9;
            this.settingsLatency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.settingsLatency.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Buffers:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Latency:";
            // 
            // checkAdvancedOptions
            // 
            this.checkAdvancedOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAdvancedOptions.AutoSize = true;
            this.checkAdvancedOptions.Location = new System.Drawing.Point(6, 83);
            this.checkAdvancedOptions.Name = "checkAdvancedOptions";
            this.checkAdvancedOptions.Size = new System.Drawing.Size(114, 17);
            this.checkAdvancedOptions.TabIndex = 6;
            this.checkAdvancedOptions.Text = "Advanced Options";
            this.checkAdvancedOptions.UseVisualStyleBackColor = true;
            this.checkAdvancedOptions.CheckStateChanged += new System.EventHandler(this.toggleAdvancedOptions);
            // 
            // devicesList
            // 
            this.devicesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(260, 52);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(243, 184);
            this.devicesList.TabIndex = 5;
            this.devicesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.toggleDevice);
            // 
            // btnAddOutput
            // 
            this.btnAddOutput.Location = new System.Drawing.Point(140, 48);
            this.btnAddOutput.Name = "btnAddOutput";
            this.btnAddOutput.Size = new System.Drawing.Size(114, 23);
            this.btnAddOutput.TabIndex = 4;
            this.btnAddOutput.Text = "Add Output";
            this.btnAddOutput.UseVisualStyleBackColor = true;
            this.btnAddOutput.Click += new System.EventHandler(this.addOutputDevice);
            // 
            // cmbDevice
            // 
            this.cmbDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(91, 21);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(163, 21);
            this.cmbDevice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Device:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(430, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.streamEnd);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.textServiceStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 290);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Service Status:";
            // 
            // textServiceStatus
            // 
            this.textServiceStatus.Name = "textServiceStatus";
            this.textServiceStatus.Size = new System.Drawing.Size(51, 17);
            this.textServiceStatus.Text = "Stopped";
            // 
            // AudioStreamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 312);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioStreamer";
            this.Text = "AudioStreamer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAdvancedOptions.ResumeLayout(false);
            this.panelAdvancedOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsNumberOfBuffers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsLatency)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox devicesList;
        private System.Windows.Forms.Button btnAddOutput;
        private System.Windows.Forms.CheckBox checkAdvancedOptions;
        private System.Windows.Forms.GroupBox panelAdvancedOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel textServiceStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveOutput;
        private System.Windows.Forms.NumericUpDown settingsLatency;
        private System.Windows.Forms.NumericUpDown settingsNumberOfBuffers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar settingsVolume;
    }
}

