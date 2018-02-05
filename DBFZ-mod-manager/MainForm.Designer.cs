﻿namespace ModManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startGameBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.installModBtn = new System.Windows.Forms.Button();
            this.modsList = new System.Windows.Forms.DataGridView();
            this.patchExe = new System.Windows.Forms.Button();
            this.openModsFolderBtn = new System.Windows.Forms.Button();
            this.refreshModsListBtn = new System.Windows.Forms.Button();
            this.disableEasyAntiCheatBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gamePathBtn = new System.Windows.Forms.Button();
            this.gamePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.modsFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modsList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startGameBtn.Location = new System.Drawing.Point(10, 642);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(174, 35);
            this.startGameBtn.TabIndex = 1;
            this.startGameBtn.Text = "Save and Play";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Location = new System.Drawing.Point(189, 642);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(174, 35);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save ";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 638);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.installModBtn);
            this.tabPage1.Controls.Add(this.modsList);
            this.tabPage1.Controls.Add(this.patchExe);
            this.tabPage1.Controls.Add(this.openModsFolderBtn);
            this.tabPage1.Controls.Add(this.refreshModsListBtn);
            this.tabPage1.Controls.Add(this.disableEasyAntiCheatBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // installModBtn
            // 
            this.installModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installModBtn.Location = new System.Drawing.Point(6, 567);
            this.installModBtn.Name = "installModBtn";
            this.installModBtn.Size = new System.Drawing.Size(174, 35);
            this.installModBtn.TabIndex = 8;
            this.installModBtn.Text = "Install Mod";
            this.installModBtn.UseVisualStyleBackColor = true;
            this.installModBtn.Click += new System.EventHandler(this.installModBtn_Click);
            // 
            // modsList
            // 
            this.modsList.AllowUserToAddRows = false;
            this.modsList.AllowUserToDeleteRows = false;
            this.modsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modsFileName,
            this.modsActive,
            this.modsName,
            this.modAuthor,
            this.modVersion,
            this.modDescription});
            this.modsList.Location = new System.Drawing.Point(6, 6);
            this.modsList.Name = "modsList";
            this.modsList.RowHeadersVisible = false;
            this.modsList.RowTemplate.Height = 24;
            this.modsList.Size = new System.Drawing.Size(1060, 554);
            this.modsList.TabIndex = 0;
            // 
            // patchExe
            // 
            this.patchExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.patchExe.Location = new System.Drawing.Point(892, 567);
            this.patchExe.Name = "patchExe";
            this.patchExe.Size = new System.Drawing.Size(174, 35);
            this.patchExe.TabIndex = 6;
            this.patchExe.Text = "Patch Exe";
            this.patchExe.UseVisualStyleBackColor = true;
            this.patchExe.Click += new System.EventHandler(this.patchExe_Click);
            // 
            // openModsFolderBtn
            // 
            this.openModsFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openModsFolderBtn.Location = new System.Drawing.Point(365, 567);
            this.openModsFolderBtn.Name = "openModsFolderBtn";
            this.openModsFolderBtn.Size = new System.Drawing.Size(174, 35);
            this.openModsFolderBtn.TabIndex = 2;
            this.openModsFolderBtn.Text = "Open Mods Folder";
            this.openModsFolderBtn.UseVisualStyleBackColor = true;
            this.openModsFolderBtn.Click += new System.EventHandler(this.openModsFolderBtn_Click);
            // 
            // refreshModsListBtn
            // 
            this.refreshModsListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshModsListBtn.Location = new System.Drawing.Point(185, 567);
            this.refreshModsListBtn.Name = "refreshModsListBtn";
            this.refreshModsListBtn.Size = new System.Drawing.Size(174, 35);
            this.refreshModsListBtn.TabIndex = 3;
            this.refreshModsListBtn.Text = "Refresh Mods List";
            this.refreshModsListBtn.UseVisualStyleBackColor = true;
            this.refreshModsListBtn.Click += new System.EventHandler(this.refreshModsList_Click);
            // 
            // disableEasyAntiCheatBtn
            // 
            this.disableEasyAntiCheatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disableEasyAntiCheatBtn.Location = new System.Drawing.Point(712, 567);
            this.disableEasyAntiCheatBtn.Name = "disableEasyAntiCheatBtn";
            this.disableEasyAntiCheatBtn.Size = new System.Drawing.Size(174, 35);
            this.disableEasyAntiCheatBtn.TabIndex = 7;
            this.disableEasyAntiCheatBtn.Text = "Disable EasyAntiCheat";
            this.disableEasyAntiCheatBtn.UseVisualStyleBackColor = true;
            this.disableEasyAntiCheatBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.gamePathBtn);
            this.tabPage2.Controls.Add(this.gamePathTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gamePathBtn
            // 
            this.gamePathBtn.Location = new System.Drawing.Point(638, 15);
            this.gamePathBtn.Name = "gamePathBtn";
            this.gamePathBtn.Size = new System.Drawing.Size(35, 26);
            this.gamePathBtn.TabIndex = 4;
            this.gamePathBtn.Text = "...";
            this.gamePathBtn.UseVisualStyleBackColor = true;
            this.gamePathBtn.Click += new System.EventHandler(this.gamePathBtn_Click);
            // 
            // gamePathTextBox
            // 
            this.gamePathTextBox.Location = new System.Drawing.Point(102, 16);
            this.gamePathTextBox.Name = "gamePathTextBox";
            this.gamePathTextBox.ReadOnly = true;
            this.gamePathTextBox.Size = new System.Drawing.Size(530, 22);
            this.gamePathTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "(change this if the game is installed in a different directory)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Path:";
            // 
            // modName
            // 
            this.modName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modName.FillWeight = 200F;
            this.modName.HeaderText = "Name";
            this.modName.Name = "modName";
            this.modName.ReadOnly = true;
            // 
            // modActive
            // 
            this.modActive.FillWeight = 70F;
            this.modActive.HeaderText = "Active";
            this.modActive.Name = "modActive";
            this.modActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modActive.Width = 70;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(400, 577);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(258, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.paypal.me/danielgriffithsdev";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Find this tool useful? Consider buying me a cup of coffee 😉";
            // 
            // modsFileName
            // 
            this.modsFileName.HeaderText = "FileName";
            this.modsFileName.Name = "modsFileName";
            this.modsFileName.Visible = false;
            // 
            // modsActive
            // 
            this.modsActive.FillWeight = 70F;
            this.modsActive.HeaderText = "Active";
            this.modsActive.Name = "modsActive";
            this.modsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modsActive.Width = 70;
            // 
            // modsName
            // 
            this.modsName.HeaderText = "Name";
            this.modsName.Name = "modsName";
            this.modsName.ReadOnly = true;
            this.modsName.Width = 200;
            // 
            // modAuthor
            // 
            this.modAuthor.HeaderText = "Author";
            this.modAuthor.Name = "modAuthor";
            this.modAuthor.ReadOnly = true;
            // 
            // modVersion
            // 
            this.modVersion.HeaderText = "Version";
            this.modVersion.Name = "modVersion";
            this.modVersion.ReadOnly = true;
            // 
            // modDescription
            // 
            this.modDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modDescription.HeaderText = "Description";
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 682);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startGameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 729);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBFZ Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modsList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button patchExe;
        private System.Windows.Forms.Button refreshModsListBtn;
        private System.Windows.Forms.Button disableEasyAntiCheatBtn;
        private System.Windows.Forms.Button openModsFolderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modActive;
        private System.Windows.Forms.DataGridView modsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gamePathBtn;
        private System.Windows.Forms.TextBox gamePathTextBox;
        private System.Windows.Forms.Button installModBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modsFileName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn modsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn modVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDescription;
    }
}

