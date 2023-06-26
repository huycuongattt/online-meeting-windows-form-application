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
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System.Security.Principal;
using System.Security.Cryptography;

namespace UI
{
    public partial class NewPass : Form
    {
        string acc_name;
        public NewPass(string name)
        {
            InitializeComponent();
            acc_name = name;
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://nt206-n21-antt-meeting-app-default-rtdb.firebaseio.com/",
            AuthSecret = "t7ukuZgEIMeXMd6xkkDuSm7J4MJ89ET7kEvq3Ot5"

        };
        IFirebaseClient client;
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

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
            if(guna2TextBox1.Text != guna2TextBox2.Text)
            {
                MessageBox.Show("No matching password");
                return;
            }
            var reg = new Register();
            //string name, pass, c_name, locate, gmail, phone;
            FirebaseResponse response = await client.GetAsync("Account/");
            Dictionary<string, Register> map = response.ResultAs<Dictionary<string, Register>>();

            if (map != null)
            {
                foreach (var get in map)
                {
                    string username = get.Value.username;

                    if (acc_name == username)
                    {
                        reg.username = get.Value.username;
                        
                        reg.Location = get.Value.Location;
                        reg.Gmail = get.Value.Gmail;
                        reg.Phone = get.Value.Phone;
                        reg.CompanyName = get.Value.CompanyName;
                        break;

                    }
                }

            }

            reg.passwd = HashPassword(guna2TextBox2.Text);
            SetResponse response1 = await client.SetAsync("Account/" + acc_name, reg);
            Register result = response1.ResultAs<Register>();
            MessageBox.Show("Already update password");
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }

        private void NewPass_Load(object sender, EventArgs e)
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
