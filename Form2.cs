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
        
        

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            //kiểm tra các trường thông tin input có được điền đầy đủ không?
            if (string.IsNullOrEmpty(txtBoxUsername.Text) || string.IsNullOrEmpty(txtBoxPassword.Text) || string.IsNullOrEmpty(txtBoxConfirmPass.Text))
            {
                MessageBox.Show("All fields must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Tự viết hàm checkUsername để kiểm tra input đầu vào. function .Trim() để xóa các dấu spaces trong input nhập vào ở 2 đầu. 
                if (!checkUsername(txtBoxUsername.Text.Trim()))
                {
                    MessageBox.Show("Username has fulfill below requirements:\n1.Minimun 8 chars\n2.Contain a-z, A-Z\n3.Contain numbers: 0-9 or '_'(optional)\n", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Check sự tương thích giữa 2 lần nhập password
                if (txtBoxPassword.Text != txtBoxConfirmPass.Text)
                {
                    MessageBox.Show("Password doesn't match, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Tạo một class Register để lưu các thuộc tính yêu cầu của một user khi đăng ký.
                var register = new Register
                {
                    username = txtBoxUsername.Text.Trim(),
                    passwd = HashPassword(txtBoxPassword.Text.Trim()),                    
                    Gmail = "",
                    Location = "",
                    CompanyName = "",
                    Phone = ""
                };
                //Truy xuất table Account 
                FirebaseResponse response = await client.GetAsync("Account/");
                Dictionary<string, Register> map = response.ResultAs<Dictionary<string, Register>>();
                if (map != null)
                {
                    foreach (var get in map)
                    {
                        string username = get.Value.username;
                        string passwd = get.Value.passwd;
                        //Kiểm tra trong table Account đã có username nào trùng với input người dùng nhập không?
                        if (txtBoxUsername.Text.Trim() == username)
                        {
                            MessageBox.Show("Username has existed. Change another to register", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return;

                        }
                    }
                    //Đăng ký thành công 
                    response = await client.SetAsync("Account/" + txtBoxUsername.Text.Trim(), register);
                    Register res = response.ResultAs<Register>();
                    MessageBox.Show("Register successfully!", "Notification", MessageBoxButtons.OK);


                }
                //Trường hợp xừ lý đăng ký account với table rỗng .
                else
                {
                    response = await client.SetAsync("Account/" + txtBoxUsername.Text.Trim(), register);
                    Register res = response.ResultAs<Register>();
                    MessageBox.Show("Register successfully!", "Notification", MessageBoxButtons.OK);
                }

            }
        }

        private void link_toLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Visible = false;
            f1.ShowDialog();
            this.Visible = true;
        }
    }
}
