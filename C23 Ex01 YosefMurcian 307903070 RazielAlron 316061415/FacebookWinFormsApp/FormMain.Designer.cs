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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.textBoxPostsSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhotosTaggedIn = new System.Windows.Forms.PictureBox();
            this.textBoxLikedPagesSearch = new System.Windows.Forms.TextBox();
            this.textBoxCheckInSearch = new System.Windows.Forms.TextBox();
            this.textBoxPhotosTaggenInSearch = new System.Windows.Forms.TextBox();
            this.textBoxGroupSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.listBoxPictures = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxPhotos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.buttonFetchLikes = new System.Windows.Forms.Button();
            this.listBoxPhotosTaggedIn = new System.Windows.Forms.ListBox();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonLikePages = new System.Windows.Forms.Button();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxSortedPhotos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxItemsOfCategory = new System.Windows.Forms.ListBox();
            this.pictureBoxCategoryPhoto = new System.Windows.Forms.PictureBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxStatistics = new System.Windows.Forms.ListBox();
            this.buttonFetchBestFriends = new System.Windows.Forms.Button();
            this.listBoxBestFriends = new System.Windows.Forms.ListBox();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotosTaggedIn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoryPhoto)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 24);
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
            this.buttonLogout.Location = new System.Drawing.Point(18, 59);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(209, 32);
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
            this.tabPage1.Controls.Add(this.checkBoxRememberUser);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.pictureBoxLikedPages);
            this.tabPage1.Controls.Add(this.pictureBoxCheckIn);
            this.tabPage1.Controls.Add(this.pictureBoxGroups);
            this.tabPage1.Controls.Add(this.pictureBoxPhotosTaggedIn);
            this.tabPage1.Controls.Add(this.textBoxLikedPagesSearch);
            this.tabPage1.Controls.Add(this.textBoxCheckInSearch);
            this.tabPage1.Controls.Add(this.textBoxPhotosTaggenInSearch);
            this.tabPage1.Controls.Add(this.textBoxGroupSearch);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelAbout);
            this.tabPage1.Controls.Add(this.buttonFetchLikes);
            this.tabPage1.Controls.Add(this.listBoxPhotosTaggedIn);
            this.tabPage1.Controls.Add(this.buttonCheckIn);
            this.tabPage1.Controls.Add(this.buttonFetchGroups);
            this.tabPage1.Controls.Add(this.listBoxCheckIn);
            this.tabPage1.Controls.Add(this.listBoxGroups);
            this.tabPage1.Controls.Add(this.buttonLikePages);
            this.tabPage1.Controls.Add(this.listBoxLikePages);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Features";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(266, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(857, 95);
            this.textBox1.TabIndex = 100;
            this.textBox1.Text = "FACEBOOK FEATURES APP";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.listBoxPostComments);
            this.panel3.Controls.Add(this.listBoxPosts);
            this.panel3.Controls.Add(this.buttonFetchPosts);
            this.panel3.Controls.Add(this.textBoxPostsSearch);
            this.panel3.Location = new System.Drawing.Point(613, 411);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 236);
            this.panel3.TabIndex = 85;
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 18;
            this.listBoxPostComments.Location = new System.Drawing.Point(239, 90);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(280, 130);
            this.listBoxPostComments.TabIndex = 61;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 18;
            this.listBoxPosts.Location = new System.Drawing.Point(15, 36);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(345, 148);
            this.listBoxPosts.TabIndex = 60;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.BackColor = System.Drawing.Color.MintCream;
            this.buttonFetchPosts.Location = new System.Drawing.Point(17, 190);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(178, 30);
            this.buttonFetchPosts.TabIndex = 59;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = false;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // textBoxPostsSearch
            // 
            this.textBoxPostsSearch.AccessibleDescription = "";
            this.textBoxPostsSearch.Location = new System.Drawing.Point(15, 16);
            this.textBoxPostsSearch.Name = "textBoxPostsSearch";
            this.textBoxPostsSearch.Size = new System.Drawing.Size(345, 24);
            this.textBoxPostsSearch.TabIndex = 77;
            this.textBoxPostsSearch.TextChanged += new System.EventHandler(this.textBoxPostsSearch_TextChanged);
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBoxLikedPages.InitialImage = null;
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(511, 545);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxLikedPages.TabIndex = 84;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // pictureBoxCheckIn
            // 
            this.pictureBoxCheckIn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBoxCheckIn.InitialImage = null;
            this.pictureBoxCheckIn.Location = new System.Drawing.Point(218, 545);
            this.pictureBoxCheckIn.Name = "pictureBoxCheckIn";
            this.pictureBoxCheckIn.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxCheckIn.TabIndex = 83;
            this.pictureBoxCheckIn.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBoxGroups.InitialImage = null;
            this.pictureBoxGroups.Location = new System.Drawing.Point(220, 340);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxGroups.TabIndex = 82;
            this.pictureBoxGroups.TabStop = false;
            // 
            // pictureBoxPhotosTaggedIn
            // 
            this.pictureBoxPhotosTaggedIn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBoxPhotosTaggedIn.InitialImage = null;
            this.pictureBoxPhotosTaggedIn.Location = new System.Drawing.Point(511, 341);
            this.pictureBoxPhotosTaggedIn.Name = "pictureBoxPhotosTaggedIn";
            this.pictureBoxPhotosTaggedIn.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxPhotosTaggedIn.TabIndex = 81;
            this.pictureBoxPhotosTaggedIn.TabStop = false;
            // 
            // textBoxLikedPagesSearch
            // 
            this.textBoxLikedPagesSearch.AccessibleDescription = "";
            this.textBoxLikedPagesSearch.Location = new System.Drawing.Point(309, 461);
            this.textBoxLikedPagesSearch.Name = "textBoxLikedPagesSearch";
            this.textBoxLikedPagesSearch.Size = new System.Drawing.Size(272, 24);
            this.textBoxLikedPagesSearch.TabIndex = 80;
            this.textBoxLikedPagesSearch.TextChanged += new System.EventHandler(this.textBoxLikedPagesSearch_TextChanged);
            // 
            // textBoxCheckInSearch
            // 
            this.textBoxCheckInSearch.AccessibleDescription = "";
            this.textBoxCheckInSearch.Location = new System.Drawing.Point(18, 461);
            this.textBoxCheckInSearch.Name = "textBoxCheckInSearch";
            this.textBoxCheckInSearch.Size = new System.Drawing.Size(272, 24);
            this.textBoxCheckInSearch.TabIndex = 79;
            this.textBoxCheckInSearch.TextChanged += new System.EventHandler(this.textBoxCheckInSearch_TextChanged);
            // 
            // textBoxPhotosTaggenInSearch
            // 
            this.textBoxPhotosTaggenInSearch.AccessibleDescription = "";
            this.textBoxPhotosTaggenInSearch.Location = new System.Drawing.Point(309, 260);
            this.textBoxPhotosTaggenInSearch.Name = "textBoxPhotosTaggenInSearch";
            this.textBoxPhotosTaggenInSearch.Size = new System.Drawing.Size(272, 24);
            this.textBoxPhotosTaggenInSearch.TabIndex = 78;
            this.textBoxPhotosTaggenInSearch.TextChanged += new System.EventHandler(this.textBoxPhotosTaggenInSearch_TextChanged);
            // 
            // textBoxGroupSearch
            // 
            this.textBoxGroupSearch.AccessibleDescription = "";
            this.textBoxGroupSearch.Location = new System.Drawing.Point(18, 260);
            this.textBoxGroupSearch.Name = "textBoxGroupSearch";
            this.textBoxGroupSearch.Size = new System.Drawing.Size(272, 24);
            this.textBoxGroupSearch.TabIndex = 76;
            this.textBoxGroupSearch.TextChanged += new System.EventHandler(this.textBoxGroupSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.buttonFetchAlbums);
            this.panel1.Controls.Add(this.listBoxPictures);
            this.panel1.Controls.Add(this.listBoxAlbums);
            this.panel1.Controls.Add(this.pictureBoxPhotos);
            this.panel1.Location = new System.Drawing.Point(613, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 225);
            this.panel1.TabIndex = 75;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.BackColor = System.Drawing.Color.MintCream;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(17, 173);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(178, 31);
            this.buttonFetchAlbums.TabIndex = 58;
            this.buttonFetchAlbums.Text = "Fetch Albums ";
            this.buttonFetchAlbums.UseVisualStyleBackColor = false;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // listBoxPictures
            // 
            this.listBoxPictures.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPictures.FormattingEnabled = true;
            this.listBoxPictures.ItemHeight = 18;
            this.listBoxPictures.Location = new System.Drawing.Point(201, 95);
            this.listBoxPictures.Name = "listBoxPictures";
            this.listBoxPictures.Size = new System.Drawing.Size(192, 112);
            this.listBoxPictures.TabIndex = 74;
            this.listBoxPictures.SelectedIndexChanged += new System.EventHandler(this.listBoxPictures_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 18;
            this.listBoxAlbums.Location = new System.Drawing.Point(15, 19);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(345, 148);
            this.listBoxAlbums.TabIndex = 56;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxPhotos
            // 
            this.pictureBoxPhotos.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxPhotos.Location = new System.Drawing.Point(409, 42);
            this.pictureBoxPhotos.Name = "pictureBoxPhotos";
            this.pictureBoxPhotos.Size = new System.Drawing.Size(163, 143);
            this.pictureBoxPhotos.TabIndex = 73;
            this.pictureBoxPhotos.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(197, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "ABOUT:";
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(197, 152);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(80, 18);
            this.labelAbout.TabIndex = 70;
            this.labelAbout.Text = "_________";
            // 
            // buttonFetchLikes
            // 
            this.buttonFetchLikes.BackColor = System.Drawing.Color.MintCream;
            this.buttonFetchLikes.Location = new System.Drawing.Point(357, 411);
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
            this.listBoxPhotosTaggedIn.ItemHeight = 18;
            this.listBoxPhotosTaggedIn.Location = new System.Drawing.Point(309, 281);
            this.listBoxPhotosTaggedIn.Name = "listBoxPhotosTaggedIn";
            this.listBoxPhotosTaggedIn.Size = new System.Drawing.Size(272, 130);
            this.listBoxPhotosTaggedIn.TabIndex = 67;
            this.listBoxPhotosTaggedIn.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotosTaggedIn_SelectedIndexChanged);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.MintCream;
            this.buttonCheckIn.Location = new System.Drawing.Point(63, 616);
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
            this.buttonFetchGroups.Location = new System.Drawing.Point(63, 411);
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
            this.listBoxCheckIn.ItemHeight = 18;
            this.listBoxCheckIn.Location = new System.Drawing.Point(18, 485);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(272, 130);
            this.listBoxCheckIn.TabIndex = 64;
            this.listBoxCheckIn.SelectedIndexChanged += new System.EventHandler(this.listBoxCheckIn_SelectedIndexChanged);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 18;
            this.listBoxGroups.Location = new System.Drawing.Point(18, 281);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(272, 130);
            this.listBoxGroups.TabIndex = 63;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonLikePages
            // 
            this.buttonLikePages.BackColor = System.Drawing.Color.MintCream;
            this.buttonLikePages.Location = new System.Drawing.Point(357, 616);
            this.buttonLikePages.Name = "buttonLikePages";
            this.buttonLikePages.Size = new System.Drawing.Size(178, 31);
            this.buttonLikePages.TabIndex = 62;
            this.buttonLikePages.Text = "Fetch Liked Pages";
            this.buttonLikePages.UseVisualStyleBackColor = false;
            this.buttonLikePages.Click += new System.EventHandler(this.buttonFetchLikePages_Click);
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 18;
            this.listBoxLikePages.Location = new System.Drawing.Point(309, 485);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(272, 130);
            this.listBoxLikePages.TabIndex = 57;
            this.listBoxLikePages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikePages_SelectedIndexChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 124);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(146, 114);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Features";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.listBoxSortedPhotos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listBoxItemsOfCategory);
            this.panel2.Controls.Add(this.pictureBoxCategoryPhoto);
            this.panel2.Controls.Add(this.comboBoxCategories);
            this.panel2.Location = new System.Drawing.Point(85, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 302);
            this.panel2.TabIndex = 92;
            // 
            // listBoxSortedPhotos
            // 
            this.listBoxSortedPhotos.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxSortedPhotos.FormattingEnabled = true;
            this.listBoxSortedPhotos.ItemHeight = 18;
            this.listBoxSortedPhotos.Location = new System.Drawing.Point(376, 141);
            this.listBoxSortedPhotos.Name = "listBoxSortedPhotos";
            this.listBoxSortedPhotos.Size = new System.Drawing.Size(230, 148);
            this.listBoxSortedPhotos.TabIndex = 4;
            this.listBoxSortedPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxSortedPhotos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "Select the way you wish to group your photos";
            // 
            // listBoxItemsOfCategory
            // 
            this.listBoxItemsOfCategory.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxItemsOfCategory.FormattingEnabled = true;
            this.listBoxItemsOfCategory.ItemHeight = 18;
            this.listBoxItemsOfCategory.Location = new System.Drawing.Point(72, 89);
            this.listBoxItemsOfCategory.Name = "listBoxItemsOfCategory";
            this.listBoxItemsOfCategory.Size = new System.Drawing.Size(416, 184);
            this.listBoxItemsOfCategory.TabIndex = 3;
            this.listBoxItemsOfCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxItemsOfCategory_SelectedIndexChanged);
            // 
            // pictureBoxCategoryPhoto
            // 
            this.pictureBoxCategoryPhoto.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxCategoryPhoto.InitialImage = null;
            this.pictureBoxCategoryPhoto.Location = new System.Drawing.Point(649, 66);
            this.pictureBoxCategoryPhoto.Name = "pictureBoxCategoryPhoto";
            this.pictureBoxCategoryPhoto.Size = new System.Drawing.Size(174, 172);
            this.pictureBoxCategoryPhoto.TabIndex = 91;
            this.pictureBoxCategoryPhoto.TabStop = false;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(72, 57);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(169, 26);
            this.comboBoxCategories.TabIndex = 2;
            this.comboBoxCategories.Text = "Select Category...";
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.listBoxStatistics);
            this.panel4.Controls.Add(this.buttonFetchBestFriends);
            this.panel4.Controls.Add(this.listBoxBestFriends);
            this.panel4.Location = new System.Drawing.Point(85, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(858, 267);
            this.panel4.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(627, 24);
            this.label3.TabIndex = 95;
            this.label3.Text = "See sorted list of your best friends who complements you the most";
            // 
            // listBoxStatistics
            // 
            this.listBoxStatistics.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxStatistics.FormattingEnabled = true;
            this.listBoxStatistics.ItemHeight = 18;
            this.listBoxStatistics.Location = new System.Drawing.Point(543, 72);
            this.listBoxStatistics.Name = "listBoxStatistics";
            this.listBoxStatistics.Size = new System.Drawing.Size(153, 112);
            this.listBoxStatistics.TabIndex = 93;
            // 
            // buttonFetchBestFriends
            // 
            this.buttonFetchBestFriends.BackColor = System.Drawing.Color.MintCream;
            this.buttonFetchBestFriends.Location = new System.Drawing.Point(100, 219);
            this.buttonFetchBestFriends.Name = "buttonFetchBestFriends";
            this.buttonFetchBestFriends.Size = new System.Drawing.Size(197, 35);
            this.buttonFetchBestFriends.TabIndex = 90;
            this.buttonFetchBestFriends.Text = "Fetch Best Friends";
            this.buttonFetchBestFriends.UseVisualStyleBackColor = false;
            this.buttonFetchBestFriends.Click += new System.EventHandler(this.buttonFetchBestFriends_Click);
            // 
            // listBoxBestFriends
            // 
            this.listBoxBestFriends.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxBestFriends.FormattingEnabled = true;
            this.listBoxBestFriends.ItemHeight = 18;
            this.listBoxBestFriends.Location = new System.Drawing.Point(72, 47);
            this.listBoxBestFriends.Name = "listBoxBestFriends";
            this.listBoxBestFriends.Size = new System.Drawing.Size(416, 166);
            this.listBoxBestFriends.TabIndex = 88;
            this.listBoxBestFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxBestFriends_SelectedIndexChanged);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(18, 96);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(126, 22);
            this.checkBoxRememberUser.TabIndex = 101;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotosTaggedIn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoryPhoto)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Button buttonFetchPosts;
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
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.ListBox listBoxItemsOfCategory;
        private System.Windows.Forms.ListBox listBoxSortedPhotos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxCategoryPhoto;
        private System.Windows.Forms.Button buttonFetchBestFriends;
        private System.Windows.Forms.ListBox listBoxBestFriends;
        private System.Windows.Forms.ListBox listBoxStatistics;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
    }
}

