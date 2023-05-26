using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace UI
{
    public partial class Form6 : Form
    {
        string code;
        string acc_name;
        public Form6(string username, string randomcode)
        {
            InitializeComponent();
            code = randomcode;
            acc_name = username;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private bool checkCode(string code)
        {
            return Regex.IsMatch(code, @"^[0-9]{6}$");
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text == "")
            {
                MessageBox.Show("Please enter a code");
                return;
            }
            if (!checkCode(guna2TextBox1.Text))
            {
                MessageBox.Show("Please enter code in correct format");
                return;
            }
            if (code == (guna2TextBox1.Text).ToString())
            {
                MessageBox.Show("Verify successfully!");
                NewPass newPass = new NewPass(acc_name);
                this.Hide();
                newPass.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Code. Try again!");
                return;
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
