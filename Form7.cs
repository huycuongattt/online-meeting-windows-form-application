using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;
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
    public partial class Form7 : Form
    {
        public bool Camera = true;
        public bool Microphone = true;
        public Form7()
        {
            InitializeComponent();
            TextBoxPassword.PasswordChar = '*';
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://nt206-n21-antt-meeting-app-default-rtdb.firebaseio.com/",
            AuthSecret = "t7ukuZgEIMeXMd6xkkDuSm7J4MJ89ET7kEvq3Ot5"

        };
        IFirebaseClient client;
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextID_TextChanged(object sender, EventArgs e)
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
        private async void BtnJoin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextID.Text))
            {
                MessageBox.Show("ID Room must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (TypeRoom.Text == "Public room")
                {
                    bool enter1 = false;
                    FirebaseResponse response = await client.GetAsync("Room/");
                    Dictionary<string, Enter_Room> map = response.ResultAs<Dictionary<string, Enter_Room>>();
                    if (map != null)
                    {
                        foreach (var get in map)
                        {
                            string ID_Room = get.Value.ID_Room;
                            //string Pass_room = get.Value.Pass_Room;
                            if (TextID.Text.Trim() == ID_Room)
                            {
                                enter1 = true;
                                var form1 = (Form1)Application.OpenForms["Form1"];
                                string UserName = form1.UserName;
                                Random random = new Random();
                                DateTime Now = DateTime.Now;
                                string IDAttend = (random.Next(1, 99999)).ToString();
                                //IDAttend = await CheckID(IDAttend);
                                var Attend = new Attend_Room
                                {
                                    ID_Attend = IDAttend,
                                    ID_Room = ID_Room,
                                    Attend_Name = UserName,
                                    DateTime = Now.ToString()
                                };
                                SetResponse response2 = await client.SetAsync("Attend/" + IDAttend, Attend);
                                Enter_Room attend = response2.ResultAs<Enter_Room>();
                                MessageBox.Show("Join room successfully!", "Notification", MessageBoxButtons.OK);
                                this.Hide();
                                Form4 f4 = new Form4(UserName, ID_Room, "N/A");
                                f4.ShowDialog();

                            }
                        }
                        if (!enter1)
                        {

                            MessageBox.Show("Invalid ID Meeting!");
                            return;

                        }

                    }
                    else
                    {
                        MessageBox.Show("No ID Meeting in database. Please create room first!");
                        return;
                    }
                }
                else if (TypeRoom.Text == "Private room")
                {
                    if (string.IsNullOrEmpty(TextBoxPassword.Text))
                    {
                        MessageBox.Show("Password must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bool enter2 = false;
                        FirebaseResponse response = await client.GetAsync("Room/");
                        Dictionary<string, Enter_Room> map = response.ResultAs<Dictionary<string, Enter_Room>>();
                        if (map != null)
                        {
                            foreach (var get in map)
                            {
                                string ID_Room = get.Value.ID_Room;
                                string Pass_room = get.Value.Pass_Room;
                                if (TextID.Text.Trim() == ID_Room && HashPassword(TextBoxPassword.Text.Trim()) == Pass_room)
                                {
                                    enter2 = true;
                                    var form1 = (Form1)Application.OpenForms["Form1"];
                                    string UserName = form1.UserName;
                                    Random random = new Random();
                                    DateTime Now = DateTime.Now;
                                    string IDAttend = (random.Next(1, 99999)).ToString();
                                    //IDAttend = await CheckID(IDAttend);
                                    var Attend = new Attend_Room
                                    {
                                        ID_Attend = IDAttend,
                                        ID_Room = ID_Room,
                                        Attend_Name = UserName,
                                        DateTime = Now.ToString()
                                    };
                                    SetResponse response2 = await client.SetAsync("Attend/" + IDAttend, Attend);
                                    Enter_Room attend = response2.ResultAs<Enter_Room>();
                                    MessageBox.Show("Join room successfully!", "Notification", MessageBoxButtons.OK);
                                    this.Hide();
                                    Form4 f4 = new Form4(UserName, ID_Room, TextBoxPassword.Text.Trim());
                                    f4.ShowDialog();
                                }

                            }
                            if (!enter2)
                            {

                                MessageBox.Show("Invalid ID Meeting and Password!");
                                return;

                            }

                        }
                        else
                        {
                            MessageBox.Show("No ID Meeting in database. Please create room first!");
                            return;
                        }
                    }
                }
            }
        }

        private void Form7_Load(object sender, EventArgs e)
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

        private void TypeRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeRoom.Text == "Public room") TextBoxPassword.Enabled = false;
            else TextBoxPassword.Enabled = true;
        }

        private void checkBoxCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCamera.Checked == true)
                Camera = false;
            else Camera = true;
        }

        private void checkBoxMicro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMicro.Checked == true)
                Microphone = false;
            else Microphone = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async Task<string>  CheckID(string IDAttend)
        {
            FirebaseResponse response = await client.GetAsync("Attend/");
            Dictionary<string, Attend_Room> Check = response.ResultAs<Dictionary<string, Attend_Room>>();
            foreach (var get in Check)
            {
                if (get.Value.ID_Attend == IDAttend.ToString())
                {
                    Random random = new Random();
                    DateTime Now = DateTime.Now;
                    IDAttend = (random.Next(1, 99999)).ToString();
                    return await CheckID(IDAttend);
                }
            }
            return IDAttend;
        }
    }
}
