using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System.Net.Mail;
using System.Net;
using System.Net.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
namespace UI
{
    
    public partial class Form1 : Form
    {
        public string UserName = "";
        string randomcode;
        public static string to;

        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
           BasePath = "https://nt206-n21-antt-meeting-app-default-rtdb.firebaseio.com/",
           AuthSecret = "t7ukuZgEIMeXMd6xkkDuSm7J4MJ89ET7kEvq3Ot5"

        };
        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check your connection!");
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form2 f2 = new Form2();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2TextBox2.PasswordChar = '\0';
            }
            else
            {
                guna2TextBox2.PasswordChar = '●';
            }
        }

        private void txtBox2_Leave(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                MessageBox.Show("All fields must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            bool login = false;
            FirebaseResponse response = await client.GetAsync("Account/");
            Dictionary<string, Register> map = response.ResultAs<Dictionary<string, Register>>();
            if (map != null)
            {
                foreach (var get in map)
                {
                    string username = get.Value.username;
                    string password = get.Value.passwd;
                    string hashedPassword = HashPassword(guna2TextBox2.Text.Trim()); 
                    if (username == guna2TextBox1.Text.Trim() && hashedPassword == password)
                    {
                        MessageBox.Show("Welcome " + guna2TextBox1.Text.Trim() + " !", "Notification", MessageBoxButtons.OK);
                        login = true;
                        UserName = username;
                        this.Hide();
                        Form5 f5 = new Form5();
                        f5.ShowDialog();

                    }
                   
                }
                if (!login)
                {
                    
                        MessageBox.Show("Invalid username or password!");
                        return;
                    
                }

            }
            else
            {
                MessageBox.Show("No account in database. Please sign up first!");
                return;
            }
        }

        private async void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(guna2TextBox1.Text == "") {
                MessageBox.Show("Please enter username before reset password!");
                return;
            }
            bool exist = false;

            // querry truoc
            //make sure viec clear password 
            guna2TextBox2.Text = "";
            FirebaseResponse response = await client.GetAsync("Account/");
            Dictionary<string, Register> map = response.ResultAs<Dictionary<string, Register>>();
            if (map != null)
            {
                foreach (var get in map)
                {
                    string username = get.Value.username;
                    
                    if (guna2TextBox1.Text.Trim() == username)
                    {
                        to = get.Value.Gmail; exist = true; break;

                    }
                }

            }
            if (!exist)
            {

                MessageBox.Show("Cannot querry username in the database");
                return;

            }



            string from, apppass, msg;
            Random rnd = new Random();
            randomcode = (rnd.Next(1000000)).ToString();
            MailMessage mail = new MailMessage();
           
            from = "Onlinemeeting.Proj@gmail.com";
            apppass = "goqqvvjmxbezucoz";
            msg = $"Dear friend!\nYour reset password code is: {randomcode}";
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Body = msg;
            mail.Subject = "PASSWORD RESET CODE";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, apppass);
            try
            {
                smtp.Send(mail);
                MessageBox.Show("Code Sent Succesfully! Check your email to receive the code.");
                this.Hide();
                Form6 f6 = new Form6(guna2TextBox1.Text.Trim(),randomcode);
                f6.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            UserName = guna2TextBox1.Text;
        }
    }
    
}
