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

namespace UI
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://nt206-n21-antt-meeting-app-default-rtdb.firebaseio.com/",
            AuthSecret = "t7ukuZgEIMeXMd6xkkDuSm7J4MJ89ET7kEvq3Ot5"

        };
        IFirebaseClient client;
        private void EventForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check your connection!");
            }
            guna2TextBox2.Text = Calendar_Form5.static_month + "/" + UserControlDay.static_day + "/" + Calendar_Form5.static_year;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Application.OpenForms["Form1"];
            Random random = new Random();
            string IDEvent = (random.Next(10000, 99999)).ToString();
            IDEvent = await CheckID(IDEvent);
            var newEvent = new Event
            {
                ID_event = IDEvent,
                username = form1.UserName,
                nameevent = guna2TextBox1.Text,
                date = guna2TextBox2.Text,
                details = guna2TextBox3.Text
            };
            FirebaseResponse response;
            response = await client.SetAsync("Event/" + IDEvent, newEvent);
     
            this.Close();
        }
        public async Task<string> CheckID(string IDEvent)
        {
            FirebaseResponse response = await client.GetAsync("Event/");
            Dictionary<string, Event> Check = response.ResultAs<Dictionary<string, Event>>();
            if (Check != null)
            {
                foreach (var get in Check)
                {
                    if (get.Value.ID_event == IDEvent.ToString())
                    {
                        Random random = new Random();
                        IDEvent = (random.Next(1, 99999)).ToString();
                        return await CheckID(IDEvent);
                    }
                }
            }
            return IDEvent;
             
        }
    }
}
