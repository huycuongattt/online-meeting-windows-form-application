using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class Form8 : Form
    {
        public string IDRoom = "";
        public Form8()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://nt206-n21-antt-meeting-app-default-rtdb.firebaseio.com/",
            AuthSecret = "t7ukuZgEIMeXMd6xkkDuSm7J4MJ89ET7kEvq3Ot5"

        };
        IFirebaseClient client;

        private void Form8_Load(object sender, EventArgs e)
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
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private async void BtnJoin_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text == "Public room")
            {
                var form1 = (Form1)Application.OpenForms["Form1"];
                string UserName = form1.UserName;
                DateTime Now = DateTime.Now;
                Random random = new Random();
                IDRoom = (random.Next(1024, 65535)).ToString();
                IDRoom = await CheckID(IDRoom);
                var Enter = new Enter_Room
                {
                    ID_Room = IDRoom,
                    Pass_Room = "",
                    Type_Room = "Public room",
                    DateTime = Now.ToString(),
                    Capacity = 50,
                    Count_Member = 1,
                    Host_name = UserName,
                };
                SetResponse response = await client.SetAsync("Room/" + guna2TextBox7.Text, Enter);
                Enter_Room go = response.ResultAs<Enter_Room>();
                MessageBox.Show("Register successfully! ID Room is " + IDRoom, "Notification", MessageBoxButtons.OK);
                this.Hide();
                Form4 f4 = new Form4(UserName, IDRoom, "N/A", UserName);
                f4.ShowDialog();
            }
            else
            {
                var form1 = (Form1)Application.OpenForms["Form1"];
                string UserName = form1.UserName;
                Random random = new Random();
                DateTime Now = DateTime.Now;
                IDRoom = (random.Next(1024, 65535)).ToString();
                IDRoom = await CheckID(IDRoom);

                string non_hashPass_Room = CreatePassword();
                var Enter = new Enter_Room
                {
                    ID_Room = IDRoom,
                    Pass_Room = HashPassword(non_hashPass_Room),
                    Type_Room = "Private room",
                    DateTime = Now.ToString(),
                    Capacity = 50,
                    Count_Member = 1,
                    Host_name = UserName
                };
                SetResponse response = await client.SetAsync("Room/" + guna2TextBox7.Text, Enter);
                Enter_Room go = response.ResultAs<Enter_Room>();
                MessageBox.Show("Register successfully! \n ID Room is " + IDRoom + "\n Pass Room is " + non_hashPass_Room, "Notification", MessageBoxButtons.OK);
                this.Hide();
                Form4 f4 = new Form4(UserName, IDRoom, non_hashPass_Room, UserName);
                f4.ShowDialog();
            }

        }
        private string CreatePassword()
        {
            Random random = new Random();
            string password = "";
            for (int i = 0; i < 10; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue > 0.5)
                {
                    int randomNumber = random.Next(0, 9);
                    password += randomNumber.ToString();
                }
                else
                {
                    char randomLetter = (char)random.Next('A', 'Z' + 1);
                    password += randomLetter;
                }
            }
            return password;
        }

        public async Task<string> CheckID(string IDRoom)
        {
            FirebaseResponse response = await client.GetAsync("Room/");
            Dictionary<string, Enter_Room> Check = response.ResultAs<Dictionary<string, Enter_Room>>();
            foreach (var get in Check)
            {
                if (get.Value.ID_Room == IDRoom.ToString())
                {
                    Random random = new Random();
                    IDRoom= (random.Next(1, 99999)).ToString();
                    return await CheckID(IDRoom);
                }
            }
            return IDRoom;
        }
    }
}

