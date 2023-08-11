namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelAbout = new System.Windows.Forms.Label();
            this.buttonFetchLikes = new System.Windows.Forms.Button();
            this.listBoxPhotosTaggedIn = new System.Windows.Forms.ListBox();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonLikePages = new System.Windows.Forms.Button();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(209, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(95, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonSettings);
            this.tabPage1.Controls.Add(this.labelAbout);
            this.tabPage1.Controls.Add(this.buttonFetchLikes);
            this.tabPage1.Controls.Add(this.listBoxPhotosTaggedIn);
            this.tabPage1.Controls.Add(this.buttonCheckIn);
            this.tabPage1.Controls.Add(this.buttonFetchGroups);
            this.tabPage1.Controls.Add(this.listBoxCheckIn);
            this.tabPage1.Controls.Add(this.listBoxGroups);
            this.tabPage1.Controls.Add(this.buttonLikePages);
            this.tabPage1.Controls.Add(this.listBoxPostComments);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.buttonFetchAlbums);
            this.tabPage1.Controls.Add(this.listBoxLikePages);
            this.tabPage1.Controls.Add(this.listBoxAlbums);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(15, 304);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(80, 18);
            this.labelAbout.TabIndex = 70;
            this.labelAbout.Text = "_________";
            // 
            // buttonFetchLikes
            // 
            this.buttonFetchLikes.Location = new System.Drawing.Point(515, 407);
            this.buttonFetchLikes.Name = "buttonFetchLikes";
            this.buttonFetchLikes.Size = new System.Drawing.Size(178, 31);
            this.buttonFetchLikes.TabIndex = 69;
            this.buttonFetchLikes.Text = "Fetch Photos Tagged In";
            this.buttonFetchLikes.UseVisualStyleBackColor = true;
            this.buttonFetchLikes.Click += new System.EventHandler(this.buttonFetchPhotosTaggedIn_Click);
            // 
            // listBoxPhotosTaggedIn
            // 
            this.listBoxPhotosTaggedIn.FormattingEnabled = true;
            this.listBoxPhotosTaggedIn.ItemHeight = 18;
            this.listBoxPhotosTaggedIn.Location = new System.Drawing.Point(499, 289);
            this.listBoxPhotosTaggedIn.Name = "listBoxPhotosTaggedIn";
            this.listBoxPhotosTaggedIn.Size = new System.Drawing.Size(209, 130);
            this.listBoxPhotosTaggedIn.TabIndex = 67;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(273, 578);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(178, 31);
            this.buttonCheckIn.TabIndex = 66;
            this.buttonCheckIn.Text = "Fetch Check In";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Location = new System.Drawing.Point(273, 407);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(178, 31);
            this.buttonFetchGroups.TabIndex = 65;
            this.buttonFetchGroups.Text = "Fetch Groups ";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.ItemHeight = 18;
            this.listBoxCheckIn.Location = new System.Drawing.Point(258, 462);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(209, 130);
            this.listBoxCheckIn.TabIndex = 64;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 18;
            this.listBoxGroups.Location = new System.Drawing.Point(258, 289);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(209, 130);
            this.listBoxGroups.TabIndex = 63;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonLikePages
            // 
            this.buttonLikePages.Location = new System.Drawing.Point(31, 578);
            this.buttonLikePages.Name = "buttonLikePages";
            this.buttonLikePages.Size = new System.Drawing.Size(178, 31);
            this.buttonLikePages.TabIndex = 62;
            this.buttonLikePages.Text = "Fetch Like Pages";
            this.buttonLikePages.UseVisualStyleBackColor = true;
            this.buttonLikePages.Click += new System.EventHandler(this.buttonFetchLikePages_Click);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 18;
            this.listBoxPostComments.Location = new System.Drawing.Point(489, 143);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(234, 130);
            this.listBoxPostComments.TabIndex = 61;
            this.listBoxPostComments.SelectedIndexChanged += new System.EventHandler(this.listBoxPostComments_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 18;
            this.listBoxPosts.Location = new System.Drawing.Point(258, 96);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(450, 148);
            this.listBoxPosts.TabIndex = 60;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 30);
            this.button2.TabIndex = 59;
            this.button2.Text = "Fetch Posts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(515, 578);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(178, 31);
            this.buttonFetchAlbums.TabIndex = 58;
            this.buttonFetchAlbums.Text = "Fetch Albums ";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 18;
            this.listBoxLikePages.Location = new System.Drawing.Point(18, 462);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(209, 130);
            this.listBoxLikePages.TabIndex = 57;
            this.listBoxLikePages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikePages_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 18;
            this.listBoxAlbums.Location = new System.Drawing.Point(499, 462);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(209, 130);
            this.listBoxAlbums.TabIndex = 56;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(209, 148);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Enabled = false;
            this.buttonSettings.Location = new System.Drawing.Point(132, 57);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(95, 32);
            this.buttonSettings.TabIndex = 71;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(15, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "ABOUT:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxLikePages;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.Button buttonLikePages;
        private System.Windows.Forms.Button buttonFetchLikes;
        private System.Windows.Forms.ListBox listBoxPhotosTaggedIn;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.ListBox listBoxCheckIn;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSettings;
    }
}

