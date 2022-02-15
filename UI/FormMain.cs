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
        public FormMain()
        {
            InitializeComponent();     
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ButtonHomePage.Select();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            this.LabelDate.Text = DateTime.Now.ToString();
        }

        private void ButtonHomePage_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            NavIndicator.Height = currentButton.Height;
            NavIndicator.Top = currentButton.Top;
            NavIndicator.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(36, 51, 65);

        }

        private void ButtonManageStaff_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            NavIndicator.Height = currentButton.Height;
            NavIndicator.Top = currentButton.Top;
            NavIndicator.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(36, 51, 65);
        }

        private void ButtonManageProducts_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            NavIndicator.Height = currentButton.Height;
            NavIndicator.Top = currentButton.Top;
            NavIndicator.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(36, 51, 65);
        }

        private void ButtonManageStock_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            NavIndicator.Height = currentButton.Height;
            NavIndicator.Top = currentButton.Top;
            NavIndicator.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(36, 51, 65);
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            NavIndicator.Height = currentButton.Height;
            NavIndicator.Top = currentButton.Top;
            NavIndicator.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(36, 51, 65);
        }

        private void ButtonPos_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            NavIndicator.Height = currentButton.Height;
            NavIndicator.Top = currentButton.Top;
            NavIndicator.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(36, 51, 65);
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonHomePage_Leave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            currentButton.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void ButtonManageStaff_Leave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            currentButton.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void ButtonManageProducts_Leave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            currentButton.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void ButtonManageStock_Leave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            currentButton.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void ButtonReports_Leave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            currentButton.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void ButtonPos_Leave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            currentButton.BackColor = Color.FromArgb(52, 73, 94);
        }
    }
}
