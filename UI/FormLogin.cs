using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;
namespace UI
{
    public partial class FormLogin : Form
    {
        private readonly FormMain MainForm;
        private readonly FormWrongCredentials WrongCredentialsForm;

        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = TextUsername;
            TextUsername.Focus();
            MainForm = new FormMain();
            WrongCredentialsForm = new FormWrongCredentials();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if (DbConnection.IsCredetialsValid(TextUsername.Text, TextPassword.Text))
            {
                this.Hide();
                MainForm.ShowDialog();
                this.Close();
            }
            else
            {
                TextUsername.Clear();
                TextPassword.Clear();
                WrongCredentialsForm.ShowDialog();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonLogIn.PerformClick();
            }
        }
    }
}
