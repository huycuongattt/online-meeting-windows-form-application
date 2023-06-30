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
                txtBoxPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxPassword.PasswordChar = '●';
            }
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

        
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            UserName = txtBoxUsername.Text;
           
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //Kiểm tra các txtBox username và password có được nhập đẩy đủ chưa. Xuất thông báo khi có 1 trong 2 thiếu 
            if (string.IsNullOrEmpty(txtBoxUsername.Text) || string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                MessageBox.Show("All fields must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Tạo một flag để check trạng thái đăng nhập 
            bool login = false;
            FirebaseResponse response = await client.GetAsync("Account/"); //truy cập vào tables Account trên database 
            Dictionary<string, Register> map = response.ResultAs<Dictionary<string, Register>>();
            if (map != null)
            {
                foreach (var get in map)  // check từng Account trong table để tìm ra username, password khớp với thông tin được nhập 
                {
                    string username = get.Value.username;
                    string password = get.Value.passwd;
                    string hashedPassword = HashPassword(txtBoxPassword.Text.Trim());  // dùng hash đối với password 
                    if (username == txtBoxUsername.Text.Trim() && hashedPassword == password)
                    {
                        // Đăng nhập thành công 
                        MessageBox.Show("Welcome " + txtBoxUsername.Text.Trim() + " !", "Notification", MessageBoxButtons.OK);
                        login = true;  // set status cho flag thành true 
                        UserName = username;
                        this.Hide();
                        Form5 f5 = new Form5(username);  // chuyển sang Form5 - Home page 
                        f5.ShowDialog();

                    }

                }
                if (!login)
                {
                    // Đăng nhập sai thông tin 
                    MessageBox.Show("Invalid username or password!");
                    return;

                }

            }
            else
            {
                // Đăng nhập với acc chưa tạo trong cơ sở dữ liệu 
                MessageBox.Show("No account in database. Please sign up first!");
                return;
            }
        }

        private async void linkForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Check username có được nhập vào hay chưa.
            if (txtBoxUsername.Text == "")
            {
                MessageBox.Show("Please enter username before reset password!");
                return;
            }
            //Check username có tồn tại trong database chưa.
            bool exist = false;

            //make sure việc clear password 
            txtBoxPassword.Text = "";
            FirebaseResponse response = await client.GetAsync("Account/");  // truy cập vào tables Account 
            Dictionary<string, Register> map = response.ResultAs<Dictionary<string, Register>>();
            if (map != null)
            {
                //Tìm xem username trùng với thông tin nhập vào 
                foreach (var get in map)
                {
                    string username = get.Value.username;

                    if (txtBoxUsername.Text.Trim() == username)
                    {
                        to = get.Value.Gmail; exist = true; break;

                    }
                }

            }
            if (!exist)
            {
                //Không có username như thế trong database.
                MessageBox.Show("Cannot querry username in the database");
                return;

            }
            try
            {
                //Nếu có thực hiện việc gửi email chứa mã code 
                    string from, apppass, msg;
                Random rnd = new Random();
                randomcode = (rnd.Next(1000000)).ToString();  // Dùng hàm Random() tạo mã code 
                MailMessage mail = new MailMessage();
                //connect với acc của app. 
                from = "Onlinemeeting.Proj@gmail.com";
                apppass = "brqjwxdyswknkrof";
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
            
                    //Xuất thông báo gửi code thành công
                    smtp.Send(mail);
                    MessageBox.Show("Code Sent Succesfully! Check your email to receive the code.");
                    this.Hide();
                    Form6 f6 = new Form6(txtBoxUsername.Text.Trim(), randomcode);
                    f6.ShowDialog();
            }
            catch (Exception ex)
            {
                //Lỗi 
                MessageBox.Show(ex.Message);
            }
        }

        private void link_toSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }
    }
    
}
