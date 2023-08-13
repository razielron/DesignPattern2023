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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.pictureBoxPhotos = new System.Windows.Forms.PictureBox();
            this.listBoxPictures = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
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
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxGroupSearch = new System.Windows.Forms.TextBox();
            this.textBoxPostsSearch = new System.Windows.Forms.TextBox();
            this.textBoxPhotosTaggenInSearch = new System.Windows.Forms.TextBox();
            this.textBoxCheckInSearch = new System.Windows.Forms.TextBox();
            this.textBoxLikedPagesSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxPhotosTaggedIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotosTaggedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
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
            this.tabPage1.Controls.Add(this.pictureBoxLikedPages);
            this.tabPage1.Controls.Add(this.pictureBoxCheckIn);
            this.tabPage1.Controls.Add(this.pictureBoxGroups);
            this.tabPage1.Controls.Add(this.pictureBoxPhotosTaggedIn);
            this.tabPage1.Controls.Add(this.textBoxLikedPagesSearch);
            this.tabPage1.Controls.Add(this.textBoxCheckInSearch);
            this.tabPage1.Controls.Add(this.textBoxPhotosTaggenInSearch);
            this.tabPage1.Controls.Add(this.textBoxPostsSearch);
            this.tabPage1.Controls.Add(this.textBoxGroupSearch);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button2);
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
            this.tabPage1.Controls.Add(this.listBoxLikePages);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.buttonFetchAlbums);
            this.panel1.Controls.Add(this.pictureBoxPhotos);
            this.panel1.Controls.Add(this.listBoxPictures);
            this.panel1.Controls.Add(this.listBoxAlbums);
            this.panel1.Location = new System.Drawing.Point(502, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 183);
            this.panel1.TabIndex = 75;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.BackColor = System.Drawing.Color.MintCream;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(24, 132);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(178, 31);
            this.buttonFetchAlbums.TabIndex = 58;
            this.buttonFetchAlbums.Text = "Fetch Albums ";
            this.buttonFetchAlbums.UseVisualStyleBackColor = false;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // pictureBoxPhotos
            // 
            this.pictureBoxPhotos.Location = new System.Drawing.Point(415, 20);
            this.pictureBoxPhotos.Name = "pictureBoxPhotos";
            this.pictureBoxPhotos.Size = new System.Drawing.Size(163, 143);
            this.pictureBoxPhotos.TabIndex = 73;
            this.pictureBoxPhotos.TabStop = false;
            // 
            // listBoxPictures
            // 
            this.listBoxPictures.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPictures.FormattingEnabled = true;
            this.listBoxPictures.ItemHeight = 22;
            this.listBoxPictures.Location = new System.Drawing.Point(208, 71);
            this.listBoxPictures.Name = "listBoxPictures";
            this.listBoxPictures.Size = new System.Drawing.Size(192, 92);
            this.listBoxPictures.TabIndex = 74;
            this.listBoxPictures.SelectedIndexChanged += new System.EventHandler(this.listBoxPictures_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 22;
            this.listBoxAlbums.Location = new System.Drawing.Point(9, 12);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(345, 114);
            this.listBoxAlbums.TabIndex = 56;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Location = new System.Drawing.Point(526, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 30);
            this.button2.TabIndex = 59;
            this.button2.Text = "Fetch Posts";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(255, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "ABOUT:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
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
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(255, 35);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(100, 24);
            this.labelAbout.TabIndex = 70;
            this.labelAbout.Text = "_________";
            // 
            // buttonFetchLikes
            // 
            this.buttonFetchLikes.BackColor = System.Drawing.Color.MintCream;
            this.buttonFetchLikes.Location = new System.Drawing.Point(276, 390);
            this.buttonFetchLikes.Name = "buttonFetchLikes";
            this.buttonFetchLikes.Size = new System.Drawing.Size(178, 31);
            this.buttonFetchLikes.TabIndex = 69;
            this.buttonFetchLikes.Text = "Fetch Photos Tagged In";
            this.buttonFetchLikes.UseVisualStyleBackColor = false;
            this.buttonFetchLikes.Click += new System.EventHandler(this.buttonFetchPhotosTaggedIn_Click);
            // 
            // listBoxPhotosTaggedIn
            // 
            this.listBoxPhotosTaggedIn.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPhotosTaggedIn.FormattingEnabled = true;
            this.listBoxPhotosTaggedIn.ItemHeight = 22;
            this.listBoxPhotosTaggedIn.Location = new System.Drawing.Point(258, 260);
            this.listBoxPhotosTaggedIn.Name = "listBoxPhotosTaggedIn";
            this.listBoxPhotosTaggedIn.Size = new System.Drawing.Size(209, 136);
            this.listBoxPhotosTaggedIn.TabIndex = 67;
            this.listBoxPhotosTaggedIn.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotosTaggedIn_SelectedIndexChanged);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.MintCream;
            this.buttonCheckIn.Location = new System.Drawing.Point(34, 616);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(178, 31);
            this.buttonCheckIn.TabIndex = 66;
            this.buttonCheckIn.Text = "Fetch Check In";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.BackColor = System.Drawing.Color.MintCream;
            this.buttonFetchGroups.Location = new System.Drawing.Point(34, 390);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(178, 31);
            this.buttonFetchGroups.TabIndex = 65;
            this.buttonFetchGroups.Text = "Fetch Groups ";
            this.buttonFetchGroups.UseVisualStyleBackColor = false;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.ItemHeight = 22;
            this.listBoxCheckIn.Location = new System.Drawing.Point(18, 485);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(209, 136);
            this.listBoxCheckIn.TabIndex = 64;
            this.listBoxCheckIn.SelectedIndexChanged += new System.EventHandler(this.listBoxCheckIn_SelectedIndexChanged);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 22;
            this.listBoxGroups.Location = new System.Drawing.Point(18, 260);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(209, 136);
            this.listBoxGroups.TabIndex = 63;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonLikePages
            // 
            this.buttonLikePages.BackColor = System.Drawing.Color.MintCream;
            this.buttonLikePages.Location = new System.Drawing.Point(276, 616);
            this.buttonLikePages.Name = "buttonLikePages";
            this.buttonLikePages.Size = new System.Drawing.Size(178, 31);
            this.buttonLikePages.TabIndex = 62;
            this.buttonLikePages.Text = "Fetch Liked Pages";
            this.buttonLikePages.UseVisualStyleBackColor = false;
            this.buttonLikePages.Click += new System.EventHandler(this.buttonFetchLikePages_Click);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 22;
            this.listBoxPostComments.Location = new System.Drawing.Point(722, 334);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(192, 92);
            this.listBoxPostComments.TabIndex = 61;
            this.listBoxPostComments.SelectedIndexChanged += new System.EventHandler(this.listBoxPostComments_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 22;
            this.listBoxPosts.Location = new System.Drawing.Point(502, 262);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(345, 136);
            this.listBoxPosts.TabIndex = 60;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 22;
            this.listBoxLikePages.Location = new System.Drawing.Point(259, 485);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(209, 136);
            this.listBoxLikePages.TabIndex = 57;
            this.listBoxLikePages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikePages_SelectedIndexChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(209, 122);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxGroupSearch
            // 
            this.textBoxGroupSearch.AccessibleDescription = "";
            this.textBoxGroupSearch.Location = new System.Drawing.Point(18, 236);
            this.textBoxGroupSearch.Name = "textBoxGroupSearch";
            this.textBoxGroupSearch.Size = new System.Drawing.Size(209, 28);
            this.textBoxGroupSearch.TabIndex = 76;
            this.textBoxGroupSearch.TextChanged += new System.EventHandler(this.textBoxGroupSearch_TextChanged);
            // 
            // textBoxPostsSearch
            // 
            this.textBoxPostsSearch.AccessibleDescription = "";
            this.textBoxPostsSearch.Location = new System.Drawing.Point(502, 236);
            this.textBoxPostsSearch.Name = "textBoxPostsSearch";
            this.textBoxPostsSearch.Size = new System.Drawing.Size(345, 28);
            this.textBoxPostsSearch.TabIndex = 77;
            this.textBoxPostsSearch.TextChanged += new System.EventHandler(this.textBoxPostsSearch_TextChanged);
            // 
            // textBoxPhotosTaggenInSearch
            // 
            this.textBoxPhotosTaggenInSearch.AccessibleDescription = "";
            this.textBoxPhotosTaggenInSearch.Location = new System.Drawing.Point(258, 236);
            this.textBoxPhotosTaggenInSearch.Name = "textBoxPhotosTaggenInSearch";
            this.textBoxPhotosTaggenInSearch.Size = new System.Drawing.Size(209, 28);
            this.textBoxPhotosTaggenInSearch.TabIndex = 78;
            this.textBoxPhotosTaggenInSearch.TextChanged += new System.EventHandler(this.textBoxPhotosTaggenInSearch_TextChanged);
            // 
            // textBoxCheckInSearch
            // 
            this.textBoxCheckInSearch.AccessibleDescription = "";
            this.textBoxCheckInSearch.Location = new System.Drawing.Point(18, 461);
            this.textBoxCheckInSearch.Name = "textBoxCheckInSearch";
            this.textBoxCheckInSearch.Size = new System.Drawing.Size(209, 28);
            this.textBoxCheckInSearch.TabIndex = 79;
            this.textBoxCheckInSearch.TextChanged += new System.EventHandler(this.textBoxCheckInSearch_TextChanged);
            // 
            // textBoxLikedPagesSearch
            // 
            this.textBoxLikedPagesSearch.AccessibleDescription = "";
            this.textBoxLikedPagesSearch.Location = new System.Drawing.Point(259, 461);
            this.textBoxLikedPagesSearch.Name = "textBoxLikedPagesSearch";
            this.textBoxLikedPagesSearch.Size = new System.Drawing.Size(209, 28);
            this.textBoxLikedPagesSearch.TabIndex = 80;
            this.textBoxLikedPagesSearch.TextChanged += new System.EventHandler(this.textBoxLikedPagesSearch_TextChanged);
            // 
            // pictureBoxPhotosTaggedIn
            // 
            this.pictureBoxPhotosTaggedIn.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxPhotosTaggedIn.InitialImage = null;
            this.pictureBoxPhotosTaggedIn.Location = new System.Drawing.Point(397, 324);
            this.pictureBoxPhotosTaggedIn.Name = "pictureBoxPhotosTaggedIn";
            this.pictureBoxPhotosTaggedIn.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxPhotosTaggedIn.TabIndex = 81;
            this.pictureBoxPhotosTaggedIn.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxGroups.InitialImage = null;
            this.pictureBoxGroups.Location = new System.Drawing.Point(157, 324);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxGroups.TabIndex = 82;
            this.pictureBoxGroups.TabStop = false;
            // 
            // pictureBoxCheckIn
            // 
            this.pictureBoxCheckIn.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxCheckIn.InitialImage = null;
            this.pictureBoxCheckIn.Location = new System.Drawing.Point(157, 549);
            this.pictureBoxCheckIn.Name = "pictureBoxCheckIn";
            this.pictureBoxCheckIn.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxCheckIn.TabIndex = 83;
            this.pictureBoxCheckIn.TabStop = false;
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxLikedPages.InitialImage = null;
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(398, 549);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxLikedPages.TabIndex = 84;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotosTaggedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxPhotos;
        private System.Windows.Forms.ListBox listBoxPictures;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxGroupSearch;
        private System.Windows.Forms.TextBox textBoxPostsSearch;
        private System.Windows.Forms.TextBox textBoxPhotosTaggenInSearch;
        private System.Windows.Forms.TextBox textBoxCheckInSearch;
        private System.Windows.Forms.TextBox textBoxLikedPagesSearch;
        private System.Windows.Forms.PictureBox pictureBoxLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxCheckIn;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxPhotosTaggedIn;
    }
}

