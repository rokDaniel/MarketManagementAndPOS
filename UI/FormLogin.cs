using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.Data_Layer;
namespace UI
{
    public partial class FormLogin : Form
    {
        private readonly FormMain MainForm;
        private readonly FormMessageBox MessageBoxForm;
        private static string username;

        public static string Username => username;

        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = TextBoxUsername;
            TextBoxUsername.Focus();
            MainForm = new FormMain();
            MessageBoxForm = new FormMessageBox();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if (DbUsers.IsCredetialsValid(TextBoxUsername.Text, TextBoxPassword.Text))
            {
                username = TextBoxUsername.Text;
                this.Hide();
                MainForm.ShowDialog();
                this.Close();
            }
            else
            {
                TextBoxUsername.Clear();
                TextBoxPassword.Clear();
                MessageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Fail, FormMessageBox.eMessageBoxTypes.WrongCardentials);
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
