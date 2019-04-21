namespace Test
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ActorImage = new System.Windows.Forms.PictureBox();
            this.SecondNameTextbox = new System.Windows.Forms.TextBox();
            this.GenderCombobox = new System.Windows.Forms.ComboBox();
            this.CreateNewNameButton = new System.Windows.Forms.Button();
            this.ShowImageCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.GenrateJapaneseNameButton = new System.Windows.Forms.Button();
            this.SaveFileWithActorName = new System.Windows.Forms.CheckBox();
            this.AboutLink = new System.Windows.Forms.LinkLabel();
            this.MutilTipLabel = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SingleTab = new System.Windows.Forms.TabPage();
            this.MultiTab = new System.Windows.Forms.TabPage();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.JumpNotPng = new System.Windows.Forms.CheckBox();
            this.SelectDirectory = new System.Windows.Forms.Button();
            this.RenameAtSame = new System.Windows.Forms.CheckBox();
            this.SameGenderTipLabel = new System.Windows.Forms.Label();
            this.GenrateChineseNameMultiButton = new System.Windows.Forms.Button();
            this.SaveFileWithActorNameMulti = new System.Windows.Forms.CheckBox();
            this.GenrateJapaneseNameMultiButton = new System.Windows.Forms.Button();
            this.GenderComboBoxMulti = new System.Windows.Forms.ComboBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ActorImage)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SingleTab.SuspendLayout();
            this.MultiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(259, 36);
            this.FirstNameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTextbox.MaxLength = 6;
            this.FirstNameTextbox.Multiline = true;
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(110, 30);
            this.FirstNameTextbox.TabIndex = 0;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "角色数据|*.png";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(259, 2);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(220, 30);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "打开文件";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActorImage
            // 
            this.ActorImage.Location = new System.Drawing.Point(3, 2);
            this.ActorImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActorImage.Name = "ActorImage";
            this.ActorImage.Size = new System.Drawing.Size(250, 216);
            this.ActorImage.TabIndex = 3;
            this.ActorImage.TabStop = false;
            // 
            // SecondNameTextbox
            // 
            this.SecondNameTextbox.Location = new System.Drawing.Point(369, 36);
            this.SecondNameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondNameTextbox.MaxLength = 6;
            this.SecondNameTextbox.Multiline = true;
            this.SecondNameTextbox.Name = "SecondNameTextbox";
            this.SecondNameTextbox.Size = new System.Drawing.Size(110, 30);
            this.SecondNameTextbox.TabIndex = 5;
            // 
            // GenderCombobox
            // 
            this.GenderCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCombobox.FormattingEnabled = true;
            this.GenderCombobox.Items.AddRange(new object[] {
            "女"});
            this.GenderCombobox.Location = new System.Drawing.Point(259, 70);
            this.GenderCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderCombobox.Name = "GenderCombobox";
            this.GenderCombobox.Size = new System.Drawing.Size(220, 23);
            this.GenderCombobox.TabIndex = 8;
            // 
            // CreateNewNameButton
            // 
            this.CreateNewNameButton.Enabled = false;
            this.CreateNewNameButton.Location = new System.Drawing.Point(256, 97);
            this.CreateNewNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewNameButton.Name = "CreateNewNameButton";
            this.CreateNewNameButton.Size = new System.Drawing.Size(220, 30);
            this.CreateNewNameButton.TabIndex = 9;
            this.CreateNewNameButton.Text = "生成中国名字";
            this.CreateNewNameButton.UseVisualStyleBackColor = true;
            this.CreateNewNameButton.Click += new System.EventHandler(this.CreateNewNameButton_Click);
            // 
            // ShowImageCheckbox
            // 
            this.ShowImageCheckbox.AutoSize = true;
            this.ShowImageCheckbox.Location = new System.Drawing.Point(8, 222);
            this.ShowImageCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowImageCheckbox.Name = "ShowImageCheckbox";
            this.ShowImageCheckbox.Size = new System.Drawing.Size(164, 19);
            this.ShowImageCheckbox.TabIndex = 10;
            this.ShowImageCheckbox.Text = "打开时显示人物图片";
            this.ShowImageCheckbox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(256, 188);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(220, 30);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.StatusStrip.Location = new System.Drawing.Point(0, 285);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.StatusStrip.Size = new System.Drawing.Size(504, 25);
            this.StatusStrip.TabIndex = 12;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(54, 20);
            this.Status.Text = "状态栏";
            // 
            // GenrateJapaneseNameButton
            // 
            this.GenrateJapaneseNameButton.Location = new System.Drawing.Point(256, 131);
            this.GenrateJapaneseNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenrateJapaneseNameButton.Name = "GenrateJapaneseNameButton";
            this.GenrateJapaneseNameButton.Size = new System.Drawing.Size(220, 30);
            this.GenrateJapaneseNameButton.TabIndex = 13;
            this.GenrateJapaneseNameButton.Text = "生成日本名字";
            this.GenrateJapaneseNameButton.UseVisualStyleBackColor = true;
            this.GenrateJapaneseNameButton.Visible = false;
            // 
            // SaveFileWithActorName
            // 
            this.SaveFileWithActorName.AutoSize = true;
            this.SaveFileWithActorName.Checked = true;
            this.SaveFileWithActorName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveFileWithActorName.Location = new System.Drawing.Point(271, 165);
            this.SaveFileWithActorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveFileWithActorName.Name = "SaveFileWithActorName";
            this.SaveFileWithActorName.Size = new System.Drawing.Size(179, 19);
            this.SaveFileWithActorName.TabIndex = 14;
            this.SaveFileWithActorName.Text = "使用人物名来保存文件";
            this.SaveFileWithActorName.UseVisualStyleBackColor = true;
            // 
            // AboutLink
            // 
            this.AboutLink.AutoSize = true;
            this.AboutLink.Location = new System.Drawing.Point(439, 226);
            this.AboutLink.Name = "AboutLink";
            this.AboutLink.Size = new System.Drawing.Size(37, 15);
            this.AboutLink.TabIndex = 15;
            this.AboutLink.TabStop = true;
            this.AboutLink.Text = "关于";
            this.AboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // MutilTipLabel
            // 
            this.MutilTipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MutilTipLabel.Location = new System.Drawing.Point(0, 83);
            this.MutilTipLabel.Name = "MutilTipLabel";
            this.MutilTipLabel.Size = new System.Drawing.Size(152, 30);
            this.MutilTipLabel.TabIndex = 0;
            this.MutilTipLabel.Text = "将png拖动到这里可\r\n以进行批量重命名";
            this.MutilTipLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SingleTab);
            this.TabControl.Controls.Add(this.MultiTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(504, 285);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 17;
            // 
            // SingleTab
            // 
            this.SingleTab.Controls.Add(this.FirstNameTextbox);
            this.SingleTab.Controls.Add(this.ActorImage);
            this.SingleTab.Controls.Add(this.CreateNewNameButton);
            this.SingleTab.Controls.Add(this.AboutLink);
            this.SingleTab.Controls.Add(this.ShowImageCheckbox);
            this.SingleTab.Controls.Add(this.GenderCombobox);
            this.SingleTab.Controls.Add(this.SaveFileWithActorName);
            this.SingleTab.Controls.Add(this.SaveButton);
            this.SingleTab.Controls.Add(this.OpenButton);
            this.SingleTab.Controls.Add(this.GenrateJapaneseNameButton);
            this.SingleTab.Controls.Add(this.SecondNameTextbox);
            this.SingleTab.Location = new System.Drawing.Point(4, 25);
            this.SingleTab.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.SingleTab.Name = "SingleTab";
            this.SingleTab.Size = new System.Drawing.Size(496, 256);
            this.SingleTab.TabIndex = 0;
            this.SingleTab.Text = "单个修改";
            this.SingleTab.UseVisualStyleBackColor = true;
            // 
            // MultiTab
            // 
            this.MultiTab.Controls.Add(this.SplitContainer);
            this.MultiTab.Location = new System.Drawing.Point(4, 25);
            this.MultiTab.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.MultiTab.Name = "MultiTab";
            this.MultiTab.Size = new System.Drawing.Size(496, 256);
            this.MultiTab.TabIndex = 1;
            this.MultiTab.Text = "批量修改";
            this.MultiTab.UseVisualStyleBackColor = true;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.AllowDrop = true;
            this.SplitContainer.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SplitContainer.Panel1.Controls.Add(this.MutilTipLabel);
            this.SplitContainer.Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.SplitContainer_Panel1_DragDrop);
            this.SplitContainer.Panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.SplitContainer_Panel1_DragEnter);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.JumpNotPng);
            this.SplitContainer.Panel2.Controls.Add(this.SelectDirectory);
            this.SplitContainer.Panel2.Controls.Add(this.RenameAtSame);
            this.SplitContainer.Panel2.Controls.Add(this.SameGenderTipLabel);
            this.SplitContainer.Panel2.Controls.Add(this.GenrateChineseNameMultiButton);
            this.SplitContainer.Panel2.Controls.Add(this.SaveFileWithActorNameMulti);
            this.SplitContainer.Panel2.Controls.Add(this.GenrateJapaneseNameMultiButton);
            this.SplitContainer.Panel2.Controls.Add(this.GenderComboBoxMulti);
            this.SplitContainer.Size = new System.Drawing.Size(496, 256);
            this.SplitContainer.SplitterDistance = 180;
            this.SplitContainer.TabIndex = 1;
            // 
            // JumpNotPng
            // 
            this.JumpNotPng.AutoSize = true;
            this.JumpNotPng.Location = new System.Drawing.Point(15, 9);
            this.JumpNotPng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JumpNotPng.Name = "JumpNotPng";
            this.JumpNotPng.Size = new System.Drawing.Size(128, 19);
            this.JumpNotPng.TabIndex = 22;
            this.JumpNotPng.Text = "跳过非png文件";
            this.JumpNotPng.UseVisualStyleBackColor = true;
            // 
            // SelectDirectory
            // 
            this.SelectDirectory.Location = new System.Drawing.Point(15, 33);
            this.SelectDirectory.Name = "SelectDirectory";
            this.SelectDirectory.Size = new System.Drawing.Size(210, 30);
            this.SelectDirectory.TabIndex = 21;
            this.SelectDirectory.Text = "直接选择文件夹";
            this.SelectDirectory.UseVisualStyleBackColor = true;
            this.SelectDirectory.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // RenameAtSame
            // 
            this.RenameAtSame.AutoSize = true;
            this.RenameAtSame.Checked = true;
            this.RenameAtSame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RenameAtSame.Location = new System.Drawing.Point(15, 133);
            this.RenameAtSame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RenameAtSame.Name = "RenameAtSame";
            this.RenameAtSame.Size = new System.Drawing.Size(134, 19);
            this.RenameAtSame.TabIndex = 20;
            this.RenameAtSame.Text = "防止重复角色名";
            this.RenameAtSame.UseVisualStyleBackColor = true;
            // 
            // SameGenderTipLabel
            // 
            this.SameGenderTipLabel.AutoSize = true;
            this.SameGenderTipLabel.Location = new System.Drawing.Point(72, 93);
            this.SameGenderTipLabel.Name = "SameGenderTipLabel";
            this.SameGenderTipLabel.Size = new System.Drawing.Size(97, 15);
            this.SameGenderTipLabel.TabIndex = 19;
            this.SameGenderTipLabel.Text = "性别必须相同";
            // 
            // GenrateChineseNameMultiButton
            // 
            this.GenrateChineseNameMultiButton.Enabled = false;
            this.GenrateChineseNameMultiButton.Location = new System.Drawing.Point(15, 156);
            this.GenrateChineseNameMultiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenrateChineseNameMultiButton.Name = "GenrateChineseNameMultiButton";
            this.GenrateChineseNameMultiButton.Size = new System.Drawing.Size(210, 30);
            this.GenrateChineseNameMultiButton.TabIndex = 15;
            this.GenrateChineseNameMultiButton.Text = "生成中国名字并保存";
            this.GenrateChineseNameMultiButton.UseVisualStyleBackColor = true;
            this.GenrateChineseNameMultiButton.Click += new System.EventHandler(this.GenrateChineseNameMultiButton_Click);
            // 
            // SaveFileWithActorNameMulti
            // 
            this.SaveFileWithActorNameMulti.AutoSize = true;
            this.SaveFileWithActorNameMulti.Checked = true;
            this.SaveFileWithActorNameMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveFileWithActorNameMulti.Location = new System.Drawing.Point(15, 110);
            this.SaveFileWithActorNameMulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveFileWithActorNameMulti.Name = "SaveFileWithActorNameMulti";
            this.SaveFileWithActorNameMulti.Size = new System.Drawing.Size(179, 19);
            this.SaveFileWithActorNameMulti.TabIndex = 18;
            this.SaveFileWithActorNameMulti.Text = "使用人物名来保存文件";
            this.SaveFileWithActorNameMulti.UseVisualStyleBackColor = true;
            // 
            // GenrateJapaneseNameMultiButton
            // 
            this.GenrateJapaneseNameMultiButton.Enabled = false;
            this.GenrateJapaneseNameMultiButton.Location = new System.Drawing.Point(15, 200);
            this.GenrateJapaneseNameMultiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenrateJapaneseNameMultiButton.Name = "GenrateJapaneseNameMultiButton";
            this.GenrateJapaneseNameMultiButton.Size = new System.Drawing.Size(210, 30);
            this.GenrateJapaneseNameMultiButton.TabIndex = 17;
            this.GenrateJapaneseNameMultiButton.Text = "生成日本名字并保存";
            this.GenrateJapaneseNameMultiButton.UseVisualStyleBackColor = true;
            this.GenrateJapaneseNameMultiButton.Visible = false;
            // 
            // GenderComboBoxMulti
            // 
            this.GenderComboBoxMulti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBoxMulti.FormattingEnabled = true;
            this.GenderComboBoxMulti.Items.AddRange(new object[] {
            "女",
            "男"});
            this.GenderComboBoxMulti.Location = new System.Drawing.Point(15, 68);
            this.GenderComboBoxMulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderComboBoxMulti.Name = "GenderComboBoxMulti";
            this.GenderComboBoxMulti.Size = new System.Drawing.Size(210, 23);
            this.GenderComboBoxMulti.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 310);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.StatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人工学园重命名";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActorImage)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.SingleTab.ResumeLayout(false);
            this.SingleTab.PerformLayout();
            this.MultiTab.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox ActorImage;
        private System.Windows.Forms.TextBox SecondNameTextbox;
        private System.Windows.Forms.ComboBox GenderCombobox;
        private System.Windows.Forms.Button CreateNewNameButton;
        private System.Windows.Forms.CheckBox ShowImageCheckbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.Button GenrateJapaneseNameButton;
        private System.Windows.Forms.CheckBox SaveFileWithActorName;
        private System.Windows.Forms.LinkLabel AboutLink;
        private System.Windows.Forms.Label MutilTipLabel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SingleTab;
        private System.Windows.Forms.TabPage MultiTab;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Label SameGenderTipLabel;
        private System.Windows.Forms.Button GenrateChineseNameMultiButton;
        private System.Windows.Forms.CheckBox SaveFileWithActorNameMulti;
        private System.Windows.Forms.Button GenrateJapaneseNameMultiButton;
        private System.Windows.Forms.CheckBox RenameAtSame;
        private System.Windows.Forms.Button SelectDirectory;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.CheckBox JumpNotPng;
        public System.Windows.Forms.ComboBox GenderComboBoxMulti;
    }
}

