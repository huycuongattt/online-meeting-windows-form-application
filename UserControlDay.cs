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
    public partial class UserControlDay : UserControl
    {
        public static string static_day;

        public UserControlDay()
        {
            InitializeComponent();
            
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://nt206-n21-antt-meeting-app-default-rtdb.firebaseio.com/",
            AuthSecret = "t7ukuZgEIMeXMd6xkkDuSm7J4MJ89ET7kEvq3Ot5"

        };
        IFirebaseClient client;
        private void UserControlDay_Load(object sender, EventArgs e)
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
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }
        string date_Event;
        private void UserControlDay_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            date_Event = Calendar_Form5.static_month + "/" + static_day + "/" + Calendar_Form5.static_year;
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
        private async void displayEvent()
        {
            var form1 = (Form1)Application.OpenForms["Form1"];
           
            FirebaseResponse response = await client.GetAsync("Event/");
            Dictionary<string, Event> map = response.ResultAs<Dictionary<string, Event>>();

            if (map != null)
            {
                foreach (var get in map)
                {
                    string username = get.Value.username;
                    string nameevent = get.Value.nameevent;
                    string date = get.Value.date;
                    if (username == form1.UserName && date == date_Event)
                    {
                        lbevent.Text = nameevent;
                    }
                }
            }
        }

        private void lbevent_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
            
        }
    }
}
