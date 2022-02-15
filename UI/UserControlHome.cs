using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class UserControlHome : UserControl
    {
        TimeSpan morningStart = new TimeSpan(6, 0, 0);
        TimeSpan morning = new TimeSpan(12, 0, 0);
        TimeSpan noon = new TimeSpan(18, 0, 0);
        TimeSpan night = new TimeSpan(20, 0, 0);
        string greetingString;

        public UserControlHome()
        {
            InitializeComponent();
        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {
            initializeHeadline();
        }

        private void initializeHeadline()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now < morning && now > morningStart)
            {
                greetingString = string.Format("Good morning, {0}.", DbConnection.userPrivateName);
            }
            else if (now < noon)
            {
                greetingString = string.Format("Good afternoon, {0}.", DbConnection.userPrivateName);
            }
            else if (now < night)
            {
                greetingString = string.Format("Good evening, {0}.", DbConnection.userPrivateName);
            }
            else
            {
                greetingString = string.Format("Good night, {0}.", DbConnection.userPrivateName);
            }

            LabelGreeting.Text = greetingString;
        }
    }
}
