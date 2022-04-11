using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class FormMessageBox : Form
    {
        private Color messageTopPanelColor;
        private string messageTitle;
        private Color messageTitleColor;
        private Image messageIcon;
        private string messageText;
        
        public enum eMessageBoxGroups
        {
            Success,
            Warning,
            Fail
        }

        public enum eMessageBoxTypes
        {
            WrongCardentials,
            EmployeeAddedSuccessfully,
            EmployeeCouldNotBeAdded,
            EmployeeUpdatedSuccessfully,
            MissingDetails,
            PasswordDoesntMatch,
            ProductAddedSuccessfully,
            ProductCouldNotBeAdded,
            ItemWasNotSelected,
            WorkerWasNotSelected,
            ProductUpdatedSuccessfully,
            StockHasBeenAdded,
            EnterValidNumber,
            NotEnoughInStock,
            ApplyFirst
        }

        public FormMessageBox()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMessageBox_Load(object sender, EventArgs e)
        {
        }

        public void ShowMessageBox(eMessageBoxGroups requiredType, eMessageBoxTypes requiredMessageBox)
        {
            if (requiredType == eMessageBoxGroups.Success)
            {
                handleSuccessMessages(requiredMessageBox);
            }
            else if (requiredType == eMessageBoxGroups.Warning)
            {
                handleWarningMesages(requiredMessageBox);
            }
            else
            {
                handleFailMessages(requiredMessageBox);
            }

            changeFormVisualization(messageTopPanelColor, messageTitle, messageTitleColor, messageIcon, messageText);
            this.ShowDialog();
        }

        private void handleWarningMesages(eMessageBoxTypes requiredMessageBox)
        {
            messageTopPanelColor = Color.FromArgb(255, 255, 128);
            messageTitleColor = Color.FromArgb(64, 64, 64);
            messageIcon = Resources.IconWarning;

            switch (requiredMessageBox)
            {
                case eMessageBoxTypes.MissingDetails:
                    messageTitle = "Missing Details!";
                    messageText = "Please fill all Details correctly.";
                    break;
                case eMessageBoxTypes.PasswordDoesntMatch:
                    messageTitle = "Passwords doesn't match!";
                    messageText = "Passwords doesn't match. Please try to fill it again.";
                    break;
                case eMessageBoxTypes.ItemWasNotSelected:
                    messageTitle = "Item was not selected!";
                    messageText = "Please select an item.";
                    break;
                case eMessageBoxTypes.WorkerWasNotSelected:
                    messageTitle = "Worker was not selected!";
                    messageText = "Please select a worker.";
                    break;
                case eMessageBoxTypes.EnterValidNumber:
                    messageTitle = "Enter Valid Number!";
                    messageText = "Please enter a number greater than 0.";
                    break;
            }
        }

        private void handleFailMessages(eMessageBoxTypes requiredMessageBox)
        {
            messageTopPanelColor = Color.FromArgb(255, 128, 128);
            messageTitleColor = Color.White;
            messageIcon = Resources.IconErrorBig;

            switch (requiredMessageBox)
            {
                case eMessageBoxTypes.WrongCardentials:
                    messageTitle = "Wrong Credetials!";
                    messageText = "Wrong user name or password. Please try again.";
                    break;
                case eMessageBoxTypes.EmployeeCouldNotBeAdded:
                    messageTitle = "Employee could not be added!";
                    messageText = "Employee could not be added!";
                    break;
                case eMessageBoxTypes.ProductCouldNotBeAdded:
                    messageTitle = "Product could not be added!";
                    messageText = "Product could not be added!";
                    break;
                case eMessageBoxTypes.NotEnoughInStock:
                    messageTitle = "Not enough units in stock!";
                    messageText = "There are not enough units of the desired product.";
                    break;
                case eMessageBoxTypes.ApplyFirst:
                    messageTitle = "Apply discount!";
                    messageText = "Please apply your discount before confirming it.";
                    break;
            }
        }

        private void handleSuccessMessages(eMessageBoxTypes requiredMessageBox)
        {
            messageTopPanelColor = Color.FromArgb(192, 255, 192);
            messageTitleColor = Color.FromArgb(64, 64, 64);
            messageIcon = Resources.IconSuccess;

            switch (requiredMessageBox)
            {
                case eMessageBoxTypes.EmployeeAddedSuccessfully:
                    messageTitle = "Employee added successfully!";
                    messageText = "Employee added successfully!";
                    break;
                case eMessageBoxTypes.EmployeeUpdatedSuccessfully:
                    messageTitle = "Employee details updated successfully!";
                    messageText = "Employee details updated successfully!";
                    break;
                case eMessageBoxTypes.ProductAddedSuccessfully:
                    messageTitle = "Product added successfully!";
                    messageText = "product added successfully!";
                    break;
                case eMessageBoxTypes.ProductUpdatedSuccessfully:
                    messageTitle = "Product details updated successfully!";
                    messageText = "Product details updated successfully!";
                    break;
                case eMessageBoxTypes.StockHasBeenAdded:
                    messageTitle = "Stock has been added!";
                    messageText = "Stock has been added!";
                    break;
            }
        }

        private void changeFormVisualization(Color topPanelColor, string title, Color titleColor, Image icon, string message)
        {
            PanelTop.BackColor = topPanelColor;
            LabelTitle.Text = title;
            LabelTitle.ForeColor = titleColor;
            PictureBoxIcon.Image = icon;
            LabelMessage.Text = message;
        }
    }
}
