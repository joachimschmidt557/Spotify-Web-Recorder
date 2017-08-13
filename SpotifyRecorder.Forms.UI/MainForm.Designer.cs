namespace SpotifyWebRecorder.Forms.UI
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.encodingLabel = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label5 = new System.Windows.Forms.Label();
			this.songLabel = new System.Windows.Forms.Label();
			this.donateLink = new System.Windows.Forms.LinkLabel();
			this.buttonStartRecording = new System.Windows.Forms.Button();
			this.versionLabel = new System.Windows.Forms.Label();
			this.buttonStopRecording = new System.Windows.Forms.Button();
			this.listBoxRecordings = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_Play = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_ClearList = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.MuteOnAdsCheckBox = new System.Windows.Forms.CheckBox();
			this.openRecordingDevicesButton = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.openMixerButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.thresholdTextBox = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.thresholdCheckBox = new System.Windows.Forms.CheckBox();
			this.deviceListBox = new System.Windows.Forms.ComboBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.outputFolderTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bitrateComboBox = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPageAbout = new System.Windows.Forms.TabPage();
			this.tabPageHelp = new System.Windows.Forms.TabPage();
			this.tabPageLog = new System.Windows.Forms.TabPage();
			this.listBoxLog = new System.Windows.Forms.ListBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton_Back = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Home = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonHideSidebar = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.thresholdTextBox)).BeginInit();
			this.tabPageLog.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 28);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Size = new System.Drawing.Size(919, 638);
			this.splitContainer1.SplitterDistance = 253;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPageAbout);
			this.tabControl1.Controls.Add(this.tabPageHelp);
			this.tabControl1.Controls.Add(this.tabPageLog);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(253, 638);
			this.tabControl1.TabIndex = 79;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.encodingLabel);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.linkLabel1);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.songLabel);
			this.tabPage1.Controls.Add(this.donateLink);
			this.tabPage1.Controls.Add(this.buttonStartRecording);
			this.tabPage1.Controls.Add(this.versionLabel);
			this.tabPage1.Controls.Add(this.buttonStopRecording);
			this.tabPage1.Controls.Add(this.listBoxRecordings);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(245, 612);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = " Record ";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// encodingLabel
			// 
			this.encodingLabel.AutoSize = true;
			this.encodingLabel.Location = new System.Drawing.Point(73, 61);
			this.encodingLabel.Name = "encodingLabel";
			this.encodingLabel.Size = new System.Drawing.Size(16, 13);
			this.encodingLabel.TabIndex = 80;
			this.encodingLabel.Text = "...";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(5, 87);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(106, 13);
			this.label12.TabIndex = 79;
			this.label12.Text = "Finished Recordings:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 61);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 13);
			this.label11.TabIndex = 78;
			this.label11.Text = "Encoding:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 13);
			this.label6.TabIndex = 76;
			this.label6.Text = "Now Recording:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.linkLabel1.Location = new System.Drawing.Point(28, 691);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(181, 13);
			this.linkLabel1.TabIndex = 75;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://spotifyrecorder.codeplex.com";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 668);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(210, 13);
			this.label5.TabIndex = 74;
			this.label5.Text = "For more information, check the online help";
			// 
			// songLabel
			// 
			this.songLabel.AutoSize = true;
			this.songLabel.Location = new System.Drawing.Point(102, 42);
			this.songLabel.Name = "songLabel";
			this.songLabel.Size = new System.Drawing.Size(16, 13);
			this.songLabel.TabIndex = 58;
			this.songLabel.Text = "...";
			// 
			// donateLink
			// 
			this.donateLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.donateLink.AutoSize = true;
			this.donateLink.BackColor = System.Drawing.SystemColors.Control;
			this.donateLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.donateLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.donateLink.Location = new System.Drawing.Point(45, 716);
			this.donateLink.Name = "donateLink";
			this.donateLink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.donateLink.Size = new System.Drawing.Size(100, 13);
			this.donateLink.TabIndex = 73;
			this.donateLink.TabStop = true;
			this.donateLink.Text = "Donate with PayPal";
			this.donateLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			// 
			// buttonStartRecording
			// 
			this.buttonStartRecording.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartRecording.Image")));
			this.buttonStartRecording.Location = new System.Drawing.Point(8, 6);
			this.buttonStartRecording.Name = "buttonStartRecording";
			this.buttonStartRecording.Size = new System.Drawing.Size(112, 29);
			this.buttonStartRecording.TabIndex = 65;
			this.buttonStartRecording.Text = "Start Monitoring";
			this.buttonStartRecording.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonStartRecording.UseVisualStyleBackColor = true;
			this.buttonStartRecording.Click += new System.EventHandler(this.ButtonStartRecordingClick);
			// 
			// versionLabel
			// 
			this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(28, 716);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(35, 13);
			this.versionLabel.TabIndex = 72;
			this.versionLabel.Text = "label5";
			// 
			// buttonStopRecording
			// 
			this.buttonStopRecording.Image = ((System.Drawing.Image)(resources.GetObject("buttonStopRecording.Image")));
			this.buttonStopRecording.Location = new System.Drawing.Point(126, 6);
			this.buttonStopRecording.Name = "buttonStopRecording";
			this.buttonStopRecording.Size = new System.Drawing.Size(112, 29);
			this.buttonStopRecording.TabIndex = 63;
			this.buttonStopRecording.Text = "Stop Monitoring";
			this.buttonStopRecording.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonStopRecording.UseVisualStyleBackColor = true;
			this.buttonStopRecording.Click += new System.EventHandler(this.ButtonStopRecordingClick);
			// 
			// listBoxRecordings
			// 
			this.listBoxRecordings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxRecordings.ContextMenuStrip = this.contextMenuStrip1;
			this.listBoxRecordings.FormattingEnabled = true;
			this.listBoxRecordings.IntegralHeight = false;
			this.listBoxRecordings.Location = new System.Drawing.Point(8, 103);
			this.listBoxRecordings.Name = "listBoxRecordings";
			this.listBoxRecordings.ScrollAlwaysVisible = true;
			this.listBoxRecordings.Size = new System.Drawing.Size(231, 501);
			this.listBoxRecordings.TabIndex = 66;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Open,
            this.toolStripSeparator2,
            this.toolStripMenuItem_Play,
            this.toolStripMenuItem_Delete,
            this.toolStripSeparator1,
            this.toolStripMenuItem_ClearList});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(167, 104);
			// 
			// toolStripMenuItem_Open
			// 
			this.toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
			this.toolStripMenuItem_Open.Size = new System.Drawing.Size(166, 22);
			this.toolStripMenuItem_Open.Text = "Open output folder";
			this.toolStripMenuItem_Open.Click += new System.EventHandler(this.toolStripMenuItem_Open_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
			// 
			// toolStripMenuItem_Play
			// 
			this.toolStripMenuItem_Play.Name = "toolStripMenuItem_Play";
			this.toolStripMenuItem_Play.Size = new System.Drawing.Size(166, 22);
			this.toolStripMenuItem_Play.Text = "Play selected";
			this.toolStripMenuItem_Play.Click += new System.EventHandler(this.toolStripMenuItem_Play_Click);
			// 
			// toolStripMenuItem_Delete
			// 
			this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
			this.toolStripMenuItem_Delete.Size = new System.Drawing.Size(166, 22);
			this.toolStripMenuItem_Delete.Text = "Delete selected";
			this.toolStripMenuItem_Delete.Click += new System.EventHandler(this.toolStripMenuItem_Delete_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
			// 
			// toolStripMenuItem_ClearList
			// 
			this.toolStripMenuItem_ClearList.Name = "toolStripMenuItem_ClearList";
			this.toolStripMenuItem_ClearList.Size = new System.Drawing.Size(166, 22);
			this.toolStripMenuItem_ClearList.Text = "Clear List";
			this.toolStripMenuItem_ClearList.Click += new System.EventHandler(this.toolStripMenuItem_ClearList_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.MuteOnAdsCheckBox);
			this.tabPage2.Controls.Add(this.openRecordingDevicesButton);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.openMixerButton);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.thresholdTextBox);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.thresholdCheckBox);
			this.tabPage2.Controls.Add(this.deviceListBox);
			this.tabPage2.Controls.Add(this.browseButton);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.outputFolderTextBox);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.bitrateComboBox);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(245, 612);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = " Settings ";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MuteOnAdsCheckBox
			// 
			this.MuteOnAdsCheckBox.AutoSize = true;
			this.MuteOnAdsCheckBox.Location = new System.Drawing.Point(12, 219);
			this.MuteOnAdsCheckBox.Name = "MuteOnAdsCheckBox";
			this.MuteOnAdsCheckBox.Size = new System.Drawing.Size(163, 17);
			this.MuteOnAdsCheckBox.TabIndex = 85;
			this.MuteOnAdsCheckBox.Text = "Mute sound if ad is detected ";
			this.MuteOnAdsCheckBox.UseVisualStyleBackColor = true;
			// 
			// openRecordingDevicesButton
			// 
			this.openRecordingDevicesButton.Image = ((System.Drawing.Image)(resources.GetObject("openRecordingDevicesButton.Image")));
			this.openRecordingDevicesButton.Location = new System.Drawing.Point(24, 79);
			this.openRecordingDevicesButton.Name = "openRecordingDevicesButton";
			this.openRecordingDevicesButton.Size = new System.Drawing.Size(101, 36);
			this.openRecordingDevicesButton.TabIndex = 83;
			this.openRecordingDevicesButton.Text = "Open Rec. Devices";
			this.openRecordingDevicesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.openRecordingDevicesButton.UseVisualStyleBackColor = false;
			this.openRecordingDevicesButton.Click += new System.EventHandler(this.openRecordingDevicesButton_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(215, 247);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(27, 13);
			this.label9.TabIndex = 82;
			this.label9.Text = "sec.";
			// 
			// openMixerButton
			// 
			this.openMixerButton.Image = ((System.Drawing.Image)(resources.GetObject("openMixerButton.Image")));
			this.openMixerButton.Location = new System.Drawing.Point(131, 79);
			this.openMixerButton.Name = "openMixerButton";
			this.openMixerButton.Size = new System.Drawing.Size(101, 36);
			this.openMixerButton.TabIndex = 64;
			this.openMixerButton.Text = "Open Sound Mixer";
			this.openMixerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.openMixerButton.UseVisualStyleBackColor = false;
			this.openMixerButton.Click += new System.EventHandler(this.OpenMixerButtonClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 12);
			this.label2.TabIndex = 81;
			this.label2.Text = "Normally \'Stereo Mix\'. See help for more info.";
			// 
			// thresholdTextBox
			// 
			this.thresholdTextBox.Enabled = false;
			this.thresholdTextBox.Location = new System.Drawing.Point(158, 245);
			this.thresholdTextBox.Name = "thresholdTextBox";
			this.thresholdTextBox.Size = new System.Drawing.Size(56, 20);
			this.thresholdTextBox.TabIndex = 78;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 60;
			this.label1.Text = "Recording device:";
			// 
			// thresholdCheckBox
			// 
			this.thresholdCheckBox.AutoSize = true;
			this.thresholdCheckBox.Location = new System.Drawing.Point(12, 246);
			this.thresholdCheckBox.Name = "thresholdCheckBox";
			this.thresholdCheckBox.Size = new System.Drawing.Size(140, 17);
			this.thresholdCheckBox.TabIndex = 77;
			this.thresholdCheckBox.Text = "Skip songs shorter than:";
			this.thresholdCheckBox.UseVisualStyleBackColor = true;
			this.thresholdCheckBox.CheckedChanged += new System.EventHandler(this.thresholdCheckBox_CheckedChanged);
			// 
			// deviceListBox
			// 
			this.deviceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deviceListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.deviceListBox.FormattingEnabled = true;
			this.deviceListBox.Location = new System.Drawing.Point(24, 29);
			this.deviceListBox.Name = "deviceListBox";
			this.deviceListBox.Size = new System.Drawing.Size(215, 21);
			this.deviceListBox.TabIndex = 55;
			// 
			// browseButton
			// 
			this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.browseButton.Image = ((System.Drawing.Image)(resources.GetObject("browseButton.Image")));
			this.browseButton.Location = new System.Drawing.Point(211, 150);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(28, 28);
			this.browseButton.TabIndex = 76;
			this.browseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(169, 13);
			this.label3.TabIndex = 61;
			this.label3.Text = "Save recorded mp3\'s in this folder:";
			// 
			// outputFolderTextBox
			// 
			this.outputFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputFolderTextBox.Location = new System.Drawing.Point(24, 155);
			this.outputFolderTextBox.Name = "outputFolderTextBox";
			this.outputFolderTextBox.ReadOnly = true;
			this.outputFolderTextBox.Size = new System.Drawing.Size(181, 20);
			this.outputFolderTextBox.TabIndex = 71;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 62;
			this.label4.Text = "Mp3 bitrate:";
			// 
			// bitrateComboBox
			// 
			this.bitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bitrateComboBox.FormattingEnabled = true;
			this.bitrateComboBox.Location = new System.Drawing.Point(78, 188);
			this.bitrateComboBox.Name = "bitrateComboBox";
			this.bitrateComboBox.Size = new System.Drawing.Size(136, 21);
			this.bitrateComboBox.TabIndex = 54;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(30, 270);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 42);
			this.label7.TabIndex = 57;
			this.label7.Text = "For skipping commercials and allowing to manually stop/skip songs that you don\'t " +
    "want to record.";
			// 
			// tabPageAbout
			// 
			this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
			this.tabPageAbout.Name = "tabPageAbout";
			this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAbout.Size = new System.Drawing.Size(245, 612);
			this.tabPageAbout.TabIndex = 3;
			this.tabPageAbout.Text = " About ";
			this.tabPageAbout.UseVisualStyleBackColor = true;
			// 
			// tabPageHelp
			// 
			this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
			this.tabPageHelp.Name = "tabPageHelp";
			this.tabPageHelp.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHelp.Size = new System.Drawing.Size(245, 612);
			this.tabPageHelp.TabIndex = 4;
			this.tabPageHelp.Text = "Help";
			this.tabPageHelp.UseVisualStyleBackColor = true;
			// 
			// tabPageLog
			// 
			this.tabPageLog.Controls.Add(this.listBoxLog);
			this.tabPageLog.Location = new System.Drawing.Point(4, 22);
			this.tabPageLog.Name = "tabPageLog";
			this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLog.Size = new System.Drawing.Size(245, 612);
			this.tabPageLog.TabIndex = 5;
			this.tabPageLog.Text = "Dev Log";
			this.tabPageLog.UseVisualStyleBackColor = true;
			// 
			// listBoxLog
			// 
			this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxLog.FormattingEnabled = true;
			this.listBoxLog.Location = new System.Drawing.Point(8, 6);
			this.listBoxLog.Name = "listBoxLog";
			this.listBoxLog.Size = new System.Drawing.Size(231, 589);
			this.listBoxLog.TabIndex = 1;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Back,
            this.toolStripButton_Home,
            this.toolStripSeparator3,
            this.toolStripButtonHideSidebar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(919, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton_Back
			// 
			this.toolStripButton_Back.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Back.Image")));
			this.toolStripButton_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Back.Name = "toolStripButton_Back";
			this.toolStripButton_Back.Size = new System.Drawing.Size(49, 22);
			this.toolStripButton_Back.Text = "Back";
			this.toolStripButton_Back.Click += new System.EventHandler(this.toolStripButton_Back_Click);
			// 
			// toolStripButton_Home
			// 
			this.toolStripButton_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton_Home.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Home.Image")));
			this.toolStripButton_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Home.Name = "toolStripButton_Home";
			this.toolStripButton_Home.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton_Home.Text = "Reload";
			this.toolStripButton_Home.ToolTipText = "Reload page";
			this.toolStripButton_Home.Click += new System.EventHandler(this.toolStripButton_Home_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonHideSidebar
			// 
			this.toolStripButtonHideSidebar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHideSidebar.Image")));
			this.toolStripButtonHideSidebar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonHideSidebar.Name = "toolStripButtonHideSidebar";
			this.toolStripButtonHideSidebar.Size = new System.Drawing.Size(115, 22);
			this.toolStripButtonHideSidebar.Text = "Hide Control Panel";
			this.toolStripButtonHideSidebar.Click += new System.EventHandler(this.toolStripButtonHideSidebar_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 666);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Spotify Web Recorder";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.splitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.thresholdTextBox)).EndInit();
			this.tabPageLog.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.NumericUpDown thresholdTextBox;
		private System.Windows.Forms.CheckBox thresholdCheckBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel donateLink;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.TextBox outputFolderTextBox;
		private System.Windows.Forms.ListBox listBoxRecordings;
		private System.Windows.Forms.Button openMixerButton;
		private System.Windows.Forms.Button buttonStopRecording;
		private System.Windows.Forms.Button buttonStartRecording;
		private System.Windows.Forms.Label songLabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox bitrateComboBox;
		private System.Windows.Forms.ComboBox deviceListBox;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton_Back;
		private System.Windows.Forms.ToolStripButton toolStripButton_Home;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPageAbout;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Play;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Open;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Delete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ClearList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.TabPage tabPageHelp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button openRecordingDevicesButton;
		private System.Windows.Forms.CheckBox MuteOnAdsCheckBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label encodingLabel;
		private System.Windows.Forms.TabPage tabPageLog;
		private System.Windows.Forms.ListBox listBoxLog;
		private System.Windows.Forms.ToolStripButton toolStripButtonHideSidebar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;


	}
}

