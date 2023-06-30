using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Profile_Form5 : Form
    {
        private string UserName;
        public Profile_Form5(string username)
        {
            InitializeComponent();
            UserName = username;
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://nt206-n21-antt-meeting-app-default-rtdb.firebaseio.com/",
            AuthSecret = "t7ukuZgEIMeXMd6xkkDuSm7J4MJ89ET7kEvq3Ot5"

        };
        IFirebaseClient client;
        private void TextUserName_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private async void Profile_Form5_Load(object sender, EventArgs e)
        {

            try
            {
                client = new FireSharp.FirebaseClient(config);
                TextUserName.Text = UserName;
                TextUserName.ReadOnly = true;
                FirebaseResponse response = await client.GetAsync("Account/");
                Dictionary<string, Register> map = response.ResultAs<Dictionary<string, Register>>();
                if(map != null)
                {
                    foreach (var get in map)
                    {
                        string username = get.Value.username;
                        string gmail = get.Value.Gmail;
                        string location = get.Value.Location;
                        string company = get.Value.CompanyName;
                        string phone = get.Value.Phone;
                        if(TextUserName.Text == username)
                        {
                            TextBoxGmail.Text = gmail;
                            TextBoxLocation.Text = location;
                            TextBoxCompany.Text = company;
                            TextBoxPhone.Text = phone;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check your connection!");
            }
        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {

            var reg = new Register();
            FirebaseResponse response = await client.GetAsync("Account/");
            Dictionary<string, Register> map = response.ResultAs<Dictionary<string, Register>>();

            if (map != null)
            {
                foreach (var get in map)
                {
                    string username = get.Value.username;

                    if (UserName == username)
                    {
                        reg.username = get.Value.username;
                        reg.passwd = get.Value.passwd;
                        reg.Location = TextBoxLocation.Text;
                        reg.Gmail = TextBoxGmail.Text;
                        reg.Phone = TextBoxPhone.Text;
                        reg.CompanyName = TextBoxCompany.Text;
                        break;

                    }
                }

            }

            SetResponse response1 = await client.SetAsync("Account/" + UserName, reg);
            Register result = response1.ResultAs<Register>();
            MessageBox.Show("Already update profile");


            TextBoxPassword.ReadOnly = true;
            TextBoxGmail.ReadOnly = true;
            TextBoxLocation.ReadOnly = true;
            TextBoxCompany.ReadOnly = true;
            TextBoxPhone.ReadOnly = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TextBoxPassword.ReadOnly = false;
            TextBoxGmail.ReadOnly = false;
            TextBoxLocation.ReadOnly = false;
            TextBoxCompany.ReadOnly = false;
            TextBoxPhone.ReadOnly = false;
        }
    }
}
