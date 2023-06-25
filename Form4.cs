using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDPCOMAPILib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UI
{
    public partial class Form4 : Form
    {
        IPEndPoint IP;
        Socket Client;

        bool isMicroOn = false;
        bool isShareScreen = false;

        RDPSession x = new RDPSession();

        public Form4()
        {
            InitializeComponent();
            DarrenLee.LiveStream.Audio.Receiver audioReceiver = new DarrenLee.LiveStream.Audio.Receiver();

            audioReceiver.Receive(IPAddress.Any.ToString(), 13000);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Connect();
        }

        void Connect()
        {
            //IP: server address
            int Port = Int32.Parse("9900");
            IP = new IPEndPoint(IPAddress.Parse("192.168.137.127"), Port);
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

            Thread listener = new Thread(Receive);
            listener.IsBackground = true;
            listener.Start();
        }

        void Send(string str)
        {
            Client.Send(Serialize(str));
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
                    ViewScreenSharing(y);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        byte[] Serialize(object obj)
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
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

            DarrenLee.LiveStream.Audio.Sender audioSender = new DarrenLee.LiveStream.Audio.Sender();
            if (isMicroOn)
            {
                // Thực hiện tắt Micro
                isMicroOn = false;
                // Code để tắt Micro ở đây
                audioSender.Disconnect();
            }
            else
            {
                // Thực hiện mở Micro
                isMicroOn = true;
                // Codeđể mở Micro ở đây
                //Send("microOn");

                audioSender.Send("192.168.137.15", 13000);
            }
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

                x.Close();
                x = null;
            }
            else
            {
                isShareScreen = true;

                x.OnAttendeeConnected += Incoming;
                x.Open();
                IRDPSRAPIInvitation Invitation = x.Invitations.CreateInvitation("Trial", "MyGroup", "", 10);

                string connectStr = Invitation.ConnectionString;
                Send(connectStr);
            }
            
        }

        private void ViewScreenSharing(string str)
        {
            try
            {
                axRDPViewer1.Connect(str, "User1", "");
            }
            catch {
               // MessageBox.Show(e.Message);
            }
                
            
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
