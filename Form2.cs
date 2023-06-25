using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using System.Security.Cryptography;

namespace UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://nt206-n21-antt-meeting-app-default-rtdb.firebaseio.com/",
            AuthSecret = "t7ukuZgEIMeXMd6xkkDuSm7J4MJ89ET7kEvq3Ot5"

        };
        IFirebaseClient client;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.ShowDialog();
            this.Visible = true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkUsername(string name)
        {
            return Regex.IsMatch(name, @"^(?=.*[a-z])(?=.*[A-Z])(?!.*[^a-zA-Z0-9_]).{8,}$");
        }
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text) || string.IsNullOrEmpty(guna2TextBox3.Text))
            {
                MessageBox.Show("All fields must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!checkUsername(guna2TextBox1.Text.Trim()))
                {
                    MessageBox.Show("Username has fulfill below requirements:\n1.Minimun 8 chars\n2.Contain a-z, A-Z\n3.Contain numbers: 0-9 or '_'(optional)\n", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (guna2TextBox2.Text != guna2TextBox3.Text)
                {
                    MessageBox.Show("Password doesn't match, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var register = new Register
                {
                    username = guna2TextBox1.Text.Trim(),
                    passwd = HashPassword(guna2TextBox2.Text.Trim()),
                    // Gmail = "hnuynnhi@gmail.com",
                    Gmail = "",
                    Location ="",
                    CompanyName = "",
                    Phone = ""
                };
                FirebaseResponse response = await client.GetAsync("Account/");
                Dictionary<string,Register> map = response.ResultAs<Dictionary<string,Register>>();
                if (map != null)
                {
                    foreach (var get in map)
                    {
                        string username = get.Value.username;
                        string passwd = get.Value.passwd;
                        if (guna2TextBox1.Text.Trim() == username)
                        {
                            MessageBox.Show("Username has existed. Change another to register", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            return;

                        }
                    }
                    
                    response = await client.SetAsync("Account/" + guna2TextBox1.Text.Trim(), register);
                    Register res = response.ResultAs<Register>();
                    MessageBox.Show("Register successfully!", "Notification", MessageBoxButtons.OK);

                    
                }
                else
                {
                    response = await client.SetAsync("Account/" + guna2TextBox1.Text.Trim(), register);
                    Register res = response.ResultAs<Register>();
                    MessageBox.Show("Register successfully!", "Notification", MessageBoxButtons.OK);
                }
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check your connection!");
            }
        }
    }
}
