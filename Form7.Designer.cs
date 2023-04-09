namespace UI
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TypeRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnJoin = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.checkBoxCamera = new System.Windows.Forms.CheckBox();
            this.checkBoxMicro = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Join Meeting";
            // 
            // TextID
            // 
            this.TextID.BorderColor = System.Drawing.Color.Silver;
            this.TextID.BorderRadius = 8;
            this.TextID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.TextID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextID.DefaultText = "";
            this.TextID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextID.FillColor = System.Drawing.Color.Azure;
            this.TextID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextID.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextID.Location = new System.Drawing.Point(39, 183);
            this.TextID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextID.Name = "TextID";
            this.TextID.PasswordChar = '\0';
            this.TextID.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextID.PlaceholderText = "";
            this.TextID.SelectedText = "";
            this.TextID.Size = new System.Drawing.Size(404, 46);
            this.TextID.TabIndex = 1;
            // 
            // TypeRoom
            // 
            this.TypeRoom.BackColor = System.Drawing.Color.Azure;
            this.TypeRoom.BorderRadius = 8;
            this.TypeRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeRoom.FillColor = System.Drawing.Color.Azure;
            this.TypeRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeRoom.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TypeRoom.ItemHeight = 30;
            this.TypeRoom.Items.AddRange(new object[] {
            "Private room",
            "Public room"});
            this.TypeRoom.Location = new System.Drawing.Point(39, 114);
            this.TypeRoom.Name = "TypeRoom";
            this.TypeRoom.Size = new System.Drawing.Size(404, 36);
            this.TypeRoom.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPassword.BorderRadius = 8;
            this.TextBoxPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.DefaultText = "";
            this.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.FillColor = System.Drawing.Color.Azure;
            this.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(39, 263);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '●';
            this.TextBoxPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextBoxPassword.PlaceholderText = "";
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.Size = new System.Drawing.Size(404, 46);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // BtnJoin
            // 
            this.BtnJoin.BorderRadius = 5;
            this.BtnJoin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnJoin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnJoin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnJoin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnJoin.FillColor = System.Drawing.Color.RoyalBlue;
            this.BtnJoin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJoin.ForeColor = System.Drawing.Color.White;
            this.BtnJoin.Location = new System.Drawing.Point(213, 409);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(101, 38);
            this.BtnJoin.TabIndex = 25;
            this.BtnJoin.Text = "Join";
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
            this.BtnCancel.Location = new System.Drawing.Point(331, 409);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(101, 38);
            this.BtnCancel.TabIndex = 26;
            this.BtnCancel.Text = "Cancel";
            // 
            // checkBoxCamera
            // 
            this.checkBoxCamera.AutoSize = true;
            this.checkBoxCamera.Location = new System.Drawing.Point(39, 327);
            this.checkBoxCamera.Name = "checkBoxCamera";
            this.checkBoxCamera.Size = new System.Drawing.Size(122, 21);
            this.checkBoxCamera.TabIndex = 28;
            this.checkBoxCamera.Text = "Turn off camera";
            this.checkBoxCamera.UseVisualStyleBackColor = true;
            // 
            // checkBoxMicro
            // 
            this.checkBoxMicro.AutoSize = true;
            this.checkBoxMicro.Location = new System.Drawing.Point(39, 354);
            this.checkBoxMicro.Name = "checkBoxMicro";
            this.checkBoxMicro.Size = new System.Drawing.Size(158, 21);
            this.checkBoxMicro.TabIndex = 29;
            this.checkBoxMicro.Text = "Don\'t use microphone";
            this.checkBoxMicro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Type room: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID Meeting: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Password: ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(479, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxMicro);
            this.Controls.Add(this.checkBoxCamera);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnJoin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TypeRoom);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextID;
        private Guna.UI2.WinForms.Guna2ComboBox TypeRoom;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;
        private Guna.UI2.WinForms.Guna2Button BtnJoin;
        private Guna.UI2.WinForms.Guna2Button BtnCancel;
        private System.Windows.Forms.CheckBox checkBoxCamera;
        private System.Windows.Forms.CheckBox checkBoxMicro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}