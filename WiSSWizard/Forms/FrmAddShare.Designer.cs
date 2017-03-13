namespace Actemium.WiSSWizard.Pages
{
    partial class AddShare
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddShare));
      this.gbAddShareFolder = new System.Windows.Forms.GroupBox();
      this.btSharedCancel = new System.Windows.Forms.Button();
      this.btSharedOK = new System.Windows.Forms.Button();
      this.tbShareComment = new System.Windows.Forms.TextBox();
      this.tbShareName = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.nudSharedUsers = new System.Windows.Forms.NumericUpDown();
      this.rbSharedAllowNumberOfUser = new System.Windows.Forms.RadioButton();
      this.rbSharedMaximum = new System.Windows.Forms.RadioButton();
      this.lbSharedComment = new System.Windows.Forms.Label();
      this.lbShareName = new System.Windows.Forms.Label();
      this.btSharedBrowse = new System.Windows.Forms.Button();
      this.tbShareFolder = new System.Windows.Forms.TextBox();
      this.lbFolderToShare = new System.Windows.Forms.Label();
      this.gbAddShareFolder.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudSharedUsers)).BeginInit();
      this.SuspendLayout();
      // 
      // gbAddShareFolder
      // 
      this.gbAddShareFolder.Controls.Add(this.btSharedCancel);
      this.gbAddShareFolder.Controls.Add(this.btSharedOK);
      this.gbAddShareFolder.Controls.Add(this.tbShareComment);
      this.gbAddShareFolder.Controls.Add(this.tbShareName);
      this.gbAddShareFolder.Controls.Add(this.groupBox2);
      this.gbAddShareFolder.Controls.Add(this.lbSharedComment);
      this.gbAddShareFolder.Controls.Add(this.lbShareName);
      this.gbAddShareFolder.Controls.Add(this.btSharedBrowse);
      this.gbAddShareFolder.Controls.Add(this.tbShareFolder);
      this.gbAddShareFolder.Controls.Add(this.lbFolderToShare);
      this.gbAddShareFolder.Location = new System.Drawing.Point(10, 9);
      this.gbAddShareFolder.MaximumSize = new System.Drawing.Size(355, 182);
      this.gbAddShareFolder.MinimumSize = new System.Drawing.Size(355, 182);
      this.gbAddShareFolder.Name = "gbAddShareFolder";
      this.gbAddShareFolder.Size = new System.Drawing.Size(355, 182);
      this.gbAddShareFolder.TabIndex = 0;
      this.gbAddShareFolder.TabStop = false;
      this.gbAddShareFolder.Text = "Add a new share";
      // 
      // btSharedCancel
      // 
      this.btSharedCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btSharedCancel.Location = new System.Drawing.Point(269, 117);
      this.btSharedCancel.Name = "btSharedCancel";
      this.btSharedCancel.Size = new System.Drawing.Size(75, 23);
      this.btSharedCancel.TabIndex = 9;
      this.btSharedCancel.Text = "Cancel";
      this.btSharedCancel.UseVisualStyleBackColor = true;
      this.btSharedCancel.Click += new System.EventHandler(this.btSharedCancel_Click);
      // 
      // btSharedOK
      // 
      this.btSharedOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btSharedOK.Location = new System.Drawing.Point(269, 88);
      this.btSharedOK.Name = "btSharedOK";
      this.btSharedOK.Size = new System.Drawing.Size(75, 23);
      this.btSharedOK.TabIndex = 8;
      this.btSharedOK.Text = "Save";
      this.btSharedOK.UseVisualStyleBackColor = true;
      this.btSharedOK.Click += new System.EventHandler(this.btSharedOK_Click);
      // 
      // tbShareComment
      // 
      this.tbShareComment.Location = new System.Drawing.Point(96, 65);
      this.tbShareComment.Name = "tbShareComment";
      this.tbShareComment.Size = new System.Drawing.Size(167, 20);
      this.tbShareComment.TabIndex = 7;
      // 
      // tbShareName
      // 
      this.tbShareName.Location = new System.Drawing.Point(96, 40);
      this.tbShareName.Name = "tbShareName";
      this.tbShareName.Size = new System.Drawing.Size(167, 20);
      this.tbShareName.TabIndex = 6;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.nudSharedUsers);
      this.groupBox2.Controls.Add(this.rbSharedAllowNumberOfUser);
      this.groupBox2.Controls.Add(this.rbSharedMaximum);
      this.groupBox2.Location = new System.Drawing.Point(6, 88);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(257, 80);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "User limit";
      // 
      // nudSharedUsers
      // 
      this.nudSharedUsers.Location = new System.Drawing.Point(166, 44);
      this.nudSharedUsers.Name = "nudSharedUsers";
      this.nudSharedUsers.Size = new System.Drawing.Size(48, 20);
      this.nudSharedUsers.TabIndex = 2;
      // 
      // rbSharedAllowNumberOfUser
      // 
      this.rbSharedAllowNumberOfUser.AutoSize = true;
      this.rbSharedAllowNumberOfUser.Location = new System.Drawing.Point(15, 46);
      this.rbSharedAllowNumberOfUser.Name = "rbSharedAllowNumberOfUser";
      this.rbSharedAllowNumberOfUser.Size = new System.Drawing.Size(145, 17);
      this.rbSharedAllowNumberOfUser.TabIndex = 1;
      this.rbSharedAllowNumberOfUser.Text = "Allow this number of user:";
      this.rbSharedAllowNumberOfUser.UseVisualStyleBackColor = true;
      // 
      // rbSharedMaximum
      // 
      this.rbSharedMaximum.AutoSize = true;
      this.rbSharedMaximum.Checked = true;
      this.rbSharedMaximum.Location = new System.Drawing.Point(15, 22);
      this.rbSharedMaximum.Name = "rbSharedMaximum";
      this.rbSharedMaximum.Size = new System.Drawing.Size(108, 17);
      this.rbSharedMaximum.TabIndex = 0;
      this.rbSharedMaximum.TabStop = true;
      this.rbSharedMaximum.Text = "Maximum allowed";
      this.rbSharedMaximum.UseVisualStyleBackColor = true;
      this.rbSharedMaximum.CheckedChanged += new System.EventHandler(this.rbSharedMaximum_CheckedChanged);
      // 
      // lbSharedComment
      // 
      this.lbSharedComment.AutoSize = true;
      this.lbSharedComment.Location = new System.Drawing.Point(23, 68);
      this.lbSharedComment.Name = "lbSharedComment";
      this.lbSharedComment.Size = new System.Drawing.Size(54, 13);
      this.lbSharedComment.TabIndex = 4;
      this.lbSharedComment.Text = "Comment:";
      // 
      // lbShareName
      // 
      this.lbShareName.AutoSize = true;
      this.lbShareName.Location = new System.Drawing.Point(10, 43);
      this.lbShareName.Name = "lbShareName";
      this.lbShareName.Size = new System.Drawing.Size(67, 13);
      this.lbShareName.TabIndex = 3;
      this.lbShareName.Text = "Share name:";
      // 
      // btSharedBrowse
      // 
      this.btSharedBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btSharedBrowse.Location = new System.Drawing.Point(269, 14);
      this.btSharedBrowse.Name = "btSharedBrowse";
      this.btSharedBrowse.Size = new System.Drawing.Size(31, 23);
      this.btSharedBrowse.TabIndex = 2;
      this.btSharedBrowse.Text = "...";
      this.btSharedBrowse.UseVisualStyleBackColor = true;
      this.btSharedBrowse.Click += new System.EventHandler(this.btSharedBrowse_Click);
      // 
      // tbShareFolder
      // 
      this.tbShareFolder.Location = new System.Drawing.Point(96, 16);
      this.tbShareFolder.Name = "tbShareFolder";
      this.tbShareFolder.Size = new System.Drawing.Size(167, 20);
      this.tbShareFolder.TabIndex = 1;
      // 
      // lbFolderToShare
      // 
      this.lbFolderToShare.AutoSize = true;
      this.lbFolderToShare.Location = new System.Drawing.Point(10, 23);
      this.lbFolderToShare.Name = "lbFolderToShare";
      this.lbFolderToShare.Size = new System.Drawing.Size(80, 13);
      this.lbFolderToShare.TabIndex = 0;
      this.lbFolderToShare.Text = "Folder to share:";
      // 
      // AddShare
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(376, 198);
      this.Controls.Add(this.gbAddShareFolder);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(384, 231);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(384, 231);
      this.Name = "AddShare";
      this.Text = "Add a share folder";
      this.gbAddShareFolder.ResumeLayout(false);
      this.gbAddShareFolder.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudSharedUsers)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddShareFolder;
        private System.Windows.Forms.TextBox tbShareComment;
        private System.Windows.Forms.TextBox tbShareName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudSharedUsers;
        private System.Windows.Forms.RadioButton rbSharedAllowNumberOfUser;
        private System.Windows.Forms.RadioButton rbSharedMaximum;
        private System.Windows.Forms.Label lbSharedComment;
        private System.Windows.Forms.Label lbShareName;
        private System.Windows.Forms.Button btSharedBrowse;
        private System.Windows.Forms.TextBox tbShareFolder;
        private System.Windows.Forms.Label lbFolderToShare;
        private System.Windows.Forms.Button btSharedCancel;
        private System.Windows.Forms.Button btSharedOK;
    }
}