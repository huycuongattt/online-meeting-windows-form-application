using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class Form5 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

     );
        public Form5()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
            btnProfile.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void avatar_Click(object sender, EventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(32, 178, 170);

            this.PnlFormLoader.Controls.Clear();
            Home_Form5 Home_Form5_Vrb = new Home_Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Home_Form5_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Home_Form5_Vrb);
            Home_Form5_Vrb.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
            btnProfile.BackColor = Color.FromArgb(32, 178, 170);

            this.PnlFormLoader.Controls.Clear();
            Profile_Form5 Profile_Form5_Vrb = new Profile_Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Profile_Form5_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Profile_Form5_Vrb);
            Profile_Form5_Vrb.Show();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFriends.Height;
            pnlNav.Top = btnFriends.Top;
            btnFriends.BackColor = Color.FromArgb(32, 178, 170);

            this.PnlFormLoader.Controls.Clear();
            Friends_Form5 Friends_Form5_Vrb = new Friends_Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Friends_Form5_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Friends_Form5_Vrb);
            Friends_Form5_Vrb.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendar.Height;
            pnlNav.Top = btnCalendar.Top;
            btnCalendar.BackColor = Color.FromArgb(32, 178, 170);

            this.PnlFormLoader.Controls.Clear();
            Calendar_Form5 Calendar_Form5_Vrb = new Calendar_Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Calendar_Form5_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Calendar_Form5_Vrb);
            Calendar_Form5_Vrb.Show();
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSetting.Height;
            pnlNav.Top = btnSetting.Top;
            btnSetting.BackColor = Color.FromArgb(32, 178, 170);

            this.PnlFormLoader.Controls.Clear();
            Setting_Form5 Setting_Form5_Vrb = new Setting_Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Setting_Form5_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Setting_Form5_Vrb);
            Setting_Form5_Vrb.Show();
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void btnFriends_Leave(object sender, EventArgs e)
        {
            btnFriends.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void btnContactme_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
