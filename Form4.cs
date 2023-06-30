using RDPCOMAPILib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace UI
{
    public partial class Form4 : Form
    {
        IPEndPoint IP;
        Socket Client;
        private string UserName;
        private string ID;
        private string Pass;
        RDPSession x = new RDPSession();


        bool isShareScreen = false;
        public Form4(string username, string id, string pass)
        {
            InitializeComponent();
            UserName = username;
            ID = id;
            Pass = pass;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Connect();
            ID_Room.Text = ID;
            Pass_Room.Text = Pass;
        }

        private void UpdateChat(string message)
        {
            Chat.Invoke((MethodInvoker)delegate
            {
                Chat.Items.Add(message);
            });
        }

        void Connect()
        {
            //IP: server address
            int Port = Int32.Parse("9090");
            IP = new IPEndPoint(IPAddress.Parse("34.126.84.167"), Port);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                Client.Connect(IP);
                MessageBox.Show("Connected!");
            }
            catch
            {
                MessageBox.Show("Can't connect", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }
            Send(UserName + " have joined room");
            Thread listener = new Thread(Receive);
            listener.IsBackground = true;
            listener.Start();

        }

        void Send(string str)
        {
            Client.Send(Serialize(ID+str));
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);

                    string y = (string)Deserialize(data);
                    if (y.Contains(ID))
                    {
                        y = y.Replace(ID, "");
                        if (y.Contains("<E>")) ViewScreenSharing(y);
                        else UpdateChat(y);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        static byte[] Serialize(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return Encoding.UTF8.GetBytes(json);
        }

        static object Deserialize(byte[] data)
        {
            string json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject(json);
        }

        /*byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatterr = new BinaryFormatter();
            formatterr.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatterr = new BinaryFormatter();

            return formatterr.Deserialize(stream);
        }*/

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void axRDPViewer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Separator2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
           
        }



        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        bool isFullScreen = false;
        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                this.WindowState = FormWindowState.Normal;
                isFullScreen = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isFullScreen = true;
            }
            
        }

        private void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;//???
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_VIEW;
        }
        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            if (isShareScreen)
            {
                isShareScreen = false;
                guna2HtmlLabel6.Text = "On";
                x.Close();
                x = null;
            }
            else
            {
                isShareScreen = true;isShareScreen = true;

                if (x == null)
                {
                    x = new RDPSession();
                    x.OnAttendeeConnected += Incoming;
                    x.Open();
                }
                else
                {
                    x.OnAttendeeConnected += Incoming;
                    x.Open();
                }

                IRDPSRAPIInvitation Invitation = x.Invitations.CreateInvitation("Trial", "MyGroup", "", 10);

                string connectStr = Invitation.ConnectionString;
                Send(connectStr);

                guna2HtmlLabel6.Text = "Off";
            }
        }

        private void ViewScreenSharing(string str)
        {
            try
            {
                axRDPViewer1.Connect(str, "User1", "");
            }
            catch
            {
                // MessageBox.Show(e.Message);
            }
        }

        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {
            if (isShareScreen)
            {
                isShareScreen = false;
                guna2HtmlLabel6.Text = "On";
                x.Close();
                x = null;
            }

            Send(UserName + " left room");
            Client.Close();
            //Client.Disconnect(true);
            this.Close();
            
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
                string message = $"{UserName}: {Message.Text}";
                UpdateChat(message);
                message = $"{ID}{UserName}: {Message.Text}";
                Client.Send(Serialize(message));
                Message.Clear();
        }
    }
}
