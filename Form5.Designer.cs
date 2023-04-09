namespace UI
{
    partial class Form5
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btuSetting = new System.Windows.Forms.Button();
            this.btuContactme = new System.Windows.Forms.Button();
            this.btuCalendar = new System.Windows.Forms.Button();
            this.btuFriends = new System.Windows.Forms.Button();
            this.btuProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(183, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 28);
            this.panel4.TabIndex = 17;
            // 
            // avatar
            // 
            this.avatar.Image = global::UI.Properties.Resources.contact;
            this.avatar.Location = new System.Drawing.Point(247, 72);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(128, 128);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 11;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(463, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(463, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(463, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Locations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(35, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(463, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Display name";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.guna2TextBox1);
            this.panel3.Controls.Add(this.TextUserName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(428, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 127);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(33, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personal Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btuSetting
            // 
            this.btuSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btuSetting.FlatAppearance.BorderSize = 0;
            this.btuSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuSetting.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btuSetting.Image = global::UI.Properties.Resources.reload;
            this.btuSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuSetting.Location = new System.Drawing.Point(0, 488);
            this.btuSetting.Name = "btuSetting";
            this.btuSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btuSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btuSetting.Size = new System.Drawing.Size(183, 42);
            this.btuSetting.TabIndex = 5;
            this.btuSetting.Text = "   Setting       ";
            this.btuSetting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btuSetting.UseVisualStyleBackColor = true;
            // 
            // btuContactme
            // 
            this.btuContactme.FlatAppearance.BorderSize = 0;
            this.btuContactme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuContactme.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuContactme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btuContactme.Image = global::UI.Properties.Resources.communicate__1_;
            this.btuContactme.Location = new System.Drawing.Point(0, 270);
            this.btuContactme.Name = "btuContactme";
            this.btuContactme.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btuContactme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btuContactme.Size = new System.Drawing.Size(183, 42);
            this.btuContactme.TabIndex = 4;
            this.btuContactme.Text = "   Contact me ";
            this.btuContactme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuContactme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btuContactme.UseVisualStyleBackColor = true;
            // 
            // btuCalendar
            // 
            this.btuCalendar.FlatAppearance.BorderSize = 0;
            this.btuCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuCalendar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuCalendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btuCalendar.Image = global::UI.Properties.Resources.calendar1;
            this.btuCalendar.Location = new System.Drawing.Point(0, 228);
            this.btuCalendar.Name = "btuCalendar";
            this.btuCalendar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btuCalendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btuCalendar.Size = new System.Drawing.Size(183, 42);
            this.btuCalendar.TabIndex = 3;
            this.btuCalendar.Text = "   Calendar   ";
            this.btuCalendar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btuCalendar.UseVisualStyleBackColor = true;
            // 
            // btuFriends
            // 
            this.btuFriends.FlatAppearance.BorderSize = 0;
            this.btuFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuFriends.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuFriends.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btuFriends.Image = global::UI.Properties.Resources.consultation;
            this.btuFriends.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuFriends.Location = new System.Drawing.Point(0, 186);
            this.btuFriends.Name = "btuFriends";
            this.btuFriends.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btuFriends.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btuFriends.Size = new System.Drawing.Size(183, 42);
            this.btuFriends.TabIndex = 2;
            this.btuFriends.Text = "   Friends      ";
            this.btuFriends.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btuFriends.UseVisualStyleBackColor = true;
            // 
            // btuProfile
            // 
            this.btuProfile.FlatAppearance.BorderSize = 0;
            this.btuProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuProfile.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btuProfile.Image = global::UI.Properties.Resources.account;
            this.btuProfile.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btuProfile.Location = new System.Drawing.Point(0, 144);
            this.btuProfile.Name = "btuProfile";
            this.btuProfile.Size = new System.Drawing.Size(183, 42);
            this.btuProfile.TabIndex = 1;
            this.btuProfile.Text = "   Profile";
            this.btuProfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btuProfile.UseVisualStyleBackColor = true;
            this.btuProfile.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 144);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btuSetting);
            this.panel1.Controls.Add(this.btuContactme);
            this.panel1.Controls.Add(this.btuCalendar);
            this.panel1.Controls.Add(this.btuFriends);
            this.panel1.Controls.Add(this.btuProfile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 530);
            this.panel1.TabIndex = 10;
            // 
            // TextUserName
            // 
            this.TextUserName.BackColor = System.Drawing.Color.Azure;
            this.TextUserName.BorderRadius = 5;
            this.TextUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextUserName.DefaultText = "";
            this.TextUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextUserName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextUserName.Location = new System.Drawing.Point(36, 29);
            this.TextUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.PasswordChar = '\0';
            this.TextUserName.PlaceholderText = "";
            this.TextUserName.ReadOnly = true;
            this.TextUserName.SelectedText = "";
            this.TextUserName.Size = new System.Drawing.Size(363, 30);
            this.TextUserName.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Azure;
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(36, 82);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(363, 30);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.Color.Azure;
            this.guna2TextBox2.BorderRadius = 5;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(466, 246);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(363, 30);
            this.guna2TextBox2.TabIndex = 20;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BackColor = System.Drawing.Color.Azure;
            this.guna2TextBox3.BorderRadius = 5;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(466, 314);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.ReadOnly = true;
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(363, 30);
            this.guna2TextBox3.TabIndex = 21;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BackColor = System.Drawing.Color.Azure;
            this.guna2TextBox4.BorderRadius = 5;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(466, 375);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.ReadOnly = true;
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(363, 30);
            this.guna2TextBox4.TabIndex = 22;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BackColor = System.Drawing.Color.Azure;
            this.guna2TextBox5.BorderRadius = 5;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Location = new System.Drawing.Point(466, 442);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.ReadOnly = true;
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(363, 30);
            this.guna2TextBox5.TabIndex = 23;
            // 
            // BtnSave
            // 
            this.BtnSave.BorderRadius = 5;
            this.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSave.FillColor = System.Drawing.Color.RoyalBlue;
            this.BtnSave.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(466, 488);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(73, 39);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Save";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BorderRadius = 5;
            this.BtnCancel.BorderThickness = 1;
            this.BtnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCancel.FillColor = System.Drawing.Color.Azure;
            this.BtnCancel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Black;
            this.BtnCancel.Location = new System.Drawing.Point(558, 488);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(101, 38);
            this.BtnCancel.TabIndex = 25;
            this.BtnCancel.Text = "Cancel";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.guna2TextBox5);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btuSetting;
        public System.Windows.Forms.Button btuContactme;
        public System.Windows.Forms.Button btuCalendar;
        public System.Windows.Forms.Button btuFriends;
        public System.Windows.Forms.Button btuProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextUserName;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnCancel;
    }
}