using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class FormMain : Form
    {

        private enum ePage
        {
            Home,
            Staff,
            Products,
            Stock,
            Reports,
            POS
        }

        public FormMain()
        {
            InitializeComponent();     
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ButtonHomePage.Select();
            handleUserControl(ePage.Home);
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            this.LabelDate.Text = DateTime.Now.ToString();
        }

        private void handleNavIndicator(object sender)
        {
            Button currentButton = sender as Button;

            NavIndicator.Height = currentButton.Height;
            NavIndicator.Top = currentButton.Top;
            NavIndicator.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(36, 51, 65);
        }

        private void ButtonHomePage_Click(object sender, EventArgs e)
        {
            handleNavIndicator(sender);
            handleUserControl(ePage.Home);
        }

        private void ButtonManageStaff_Click(object sender, EventArgs e)
        {
            handleNavIndicator(sender);
            handleUserControl(ePage.Staff);
        }

        private void ButtonManageProducts_Click(object sender, EventArgs e)
        {
            handleNavIndicator(sender);
            handleUserControl(ePage.Products);
        }

        private void ButtonManageStock_Click(object sender, EventArgs e)
        {
            handleNavIndicator(sender);
            handleUserControl(ePage.Stock);
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            handleNavIndicator(sender);
            handleUserControl(ePage.Reports);
        }

        private void ButtonPos_Click(object sender, EventArgs e)
        {
            handleNavIndicator(sender);
            handleUserControl(ePage.POS);
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void handleNavClickedStatus(object sender)
        {
            Button currentButton = sender as Button;

            currentButton.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void ButtonHomePage_Leave(object sender, EventArgs e)
        {
            handleNavClickedStatus(sender);
        }

        private void ButtonManageStaff_Leave(object sender, EventArgs e)
        {
            handleNavClickedStatus(sender);
        }

        private void ButtonManageProducts_Leave(object sender, EventArgs e)
        {
            handleNavClickedStatus(sender);
        }

        private void ButtonManageStock_Leave(object sender, EventArgs e)
        {
            handleNavClickedStatus(sender);
        }

        private void ButtonReports_Leave(object sender, EventArgs e)
        {
            handleNavClickedStatus(sender);
        }

        private void ButtonPos_Leave(object sender, EventArgs e)
        {
            handleNavClickedStatus(sender);
        }

        private void handleUserControl(ePage currentPage)
        {
            switch(currentPage)
            {
                case ePage.Home:
                    homePageToFront();
                    break;
                case ePage.Staff:
                    staffPageToFront();
                    break;
                case ePage.Products:
                    productsPageToFront();
                    break;
                case ePage.Stock:
                    stockPageToFront();
                    break;
                case ePage.Reports:
                    reportPageToFront();
                    break;
                case ePage.POS:
                    posPageToFront();
                    break;
            }
        }

        private void posPageToFront()
        {
            userControlPOS1.Show();
            userControlStaff1.Hide();
            userControlProducts1.Hide();
            userControlStock1.Hide();
            userControlReports1.Hide();
            userControlHome1.Hide();
            userControlPOS1.BringToFront();
        }

        private void reportPageToFront()
        {
            userControlHome1.Hide();
            userControlStaff1.Hide();
            userControlProducts1.Hide();
            userControlStock1.Hide();
            userControlPOS1.Hide();
            userControlReports1.Show();
            userControlReports1.BringToFront();
        }

        private void stockPageToFront()
        {
            userControlHome1.Hide();
            userControlStaff1.Hide();
            userControlProducts1.Hide();
            userControlReports1.Hide();
            userControlPOS1.Hide();
            userControlStock1.Show();
            userControlStock1.BringToFront();
        }

        private void productsPageToFront()
        {
            userControlHome1.Hide();
            userControlStaff1.Hide();
            userControlStock1.Hide();
            userControlReports1.Hide();
            userControlPOS1.Hide();
            userControlProducts1.Show();
            userControlProducts1.BringToFront();
        }

        private void staffPageToFront()
        {
            userControlHome1.Hide();
            userControlProducts1.Hide();
            userControlStock1.Hide();
            userControlReports1.Hide();
            userControlPOS1.Hide();
            userControlStaff1.Show();
            userControlStaff1.BringToFront();
        }

        private void homePageToFront()
        {
            userControlStaff1.Hide();
            userControlProducts1.Hide();
            userControlStock1.Hide();
            userControlReports1.Hide();
            userControlPOS1.Hide();
            userControlHome1.Show();
            userControlHome1.BringToFront();
        }
    }
}
