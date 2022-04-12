using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Data_Layer;
using Logic.Business_Layer;

namespace UI
{
    public partial class UserControlHome : UserControl
    {
        private TimeSpan morningStart = new TimeSpan(6, 0, 0);
        private TimeSpan morning = new TimeSpan(12, 0, 0);
        private TimeSpan noon = new TimeSpan(18, 0, 0);
        private TimeSpan night = new TimeSpan(20, 0, 0);
        private DataTable stockStatus;
        private DbStatistics dbStatistics;
        private Statistics statistics;
        private string greetingString;
        private string employeeName;

        public UserControlHome()
        {
            InitializeComponent();
            dbStatistics = new DbStatistics();
            statistics = dbStatistics.LoadStatisticsById("6255436f8340e80b4cf8cb81");
        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {
            initializeHeadline();
        }

        private void initializeHeadline()
        {
            employeeName = DbEmployees.GetEmployeeName(FormLogin.Username);
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now < morning && now > morningStart)
            {
                greetingString = string.Format("Good morning, {0}.", employeeName);
            }
            else if (now < noon)
            {
                greetingString = string.Format("Good afternoon, {0}.", employeeName);
            }
            else if (now < night)
            {
                greetingString = string.Format("Good evening, {0}.", employeeName);
            }
            else
            {
                greetingString = string.Format("Good night, {0}.", employeeName);
            }

            LabelGreeting.Text = greetingString;
        }

        private void UserControlHome_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                stockStatus = DbStock.GetMissingSupplies();
                manageAlerts();
                handeStatisticsDb();
                handleStatisticsLabels();
            }
        }

        private void handleStatisticsLabels()
        {
            LabelTotalIncome.Text = statistics.TotalIncome;
            LabelTotalItems.Text = statistics.TotalItems;
            LabelTotalSold.Text = statistics.TotalItemsSold;
            LabelTotalTransactions.Text = statistics.TotalTransactions;
        }

        private void handeStatisticsDb()
        {
            statistics.TotalIncome = (float.Parse(statistics.TotalIncome) + UserControlPOS.Income).ToString();
            statistics.TotalItems = DbStock.GetStock().Rows.Count.ToString();
            statistics.TotalItemsSold = (int.Parse(statistics.TotalItemsSold) + UserControlPOS.TotalSold).ToString();
            statistics.TotalTransactions = (int.Parse(statistics.TotalTransactions) + UserControlPOS.TotalTransactions).ToString();

            UserControlPOS.Income = 0;
            UserControlPOS.TotalSold = 0;
            UserControlPOS.TotalTransactions = 0;
            dbStatistics.UpdateStatistics(statistics);
        }

        private void manageAlerts()
        {
            int x = 17;
            int y = 17;

            removeAlerts();

            foreach (DataRow row in stockStatus.Rows)
            {
                Panel alertPanel = new Panel();
                string alertText = string.Format("There is only {0} {1} left in stock! Please refill under Manage stock tab.", row[1], row[0]);

                alertPanel.Parent = PanelAlerts;
                alertPanel.BackColor = Color.FromArgb(36, 51, 65);
                alertPanel.Width = 420;
                alertPanel.Height = 64;
                alertPanel.Location = new Point(x, y);
                y += 84;

                Label alert = new Label();

                alert.Parent = alertPanel;
                alert.Width = 420;
                alert.Height = 64;
                alert.Text = alertText;
                alert.ForeColor = Color.White;
                alert.Font = new Font("sans serif", 11, FontStyle.Regular);
            }
        }

        private void removeAlerts()
        {
            IEnumerable<Panel> panels = PanelAlerts.Controls.OfType<Panel>();
            foreach (Panel panel in panels)
            {
                panel.Dispose();
            }
        }
    }
}
