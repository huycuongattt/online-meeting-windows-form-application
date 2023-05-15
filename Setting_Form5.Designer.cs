namespace UI
{
    partial class Setting_Form5
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
            this.Setting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Setting
            // 
            this.Setting.AutoSize = true;
            this.Setting.Location = new System.Drawing.Point(254, 173);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(75, 28);
            this.Setting.TabIndex = 0;
            this.Setting.Text = "Setting";
            // 
            // Setting_Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(750, 502);
            this.Controls.Add(this.Setting);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Setting_Form5";
            this.Text = "Setting_Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Setting;
    }
}