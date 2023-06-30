using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Home_Form5 : Form
    {
        private string UserName;
        public Home_Form5(string userName)
        {
            InitializeComponent();
            UserName = userName;    
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(UserName);
            form7.ShowDialog();
        }

        private void btnNewMeeting_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(UserName);
            form8.ShowDialog();
        }
    }
}
