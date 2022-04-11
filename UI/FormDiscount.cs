using Logic.HelperMethods;
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
    public partial class FormDiscount : Form
    {
        UserControlPOS userControlPOS;
        private readonly FormMessageBox messageBoxForm;
        private bool isApplied = false;

        public FormDiscount(UserControlPOS POS)
        {
            InitializeComponent();
            messageBoxForm = new FormMessageBox();
            userControlPOS = POS;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDiscount_Load(object sender, EventArgs e)
        {
            TextBoxTotalPrice.Text = userControlPOS.LabelTotalPrice;
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            UtilitiesMethods.EnableWindowDrag(e, Handle);
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (isApplied)
            {
                userControlPOS.LabelTotalDiscount = TextBoxDiscountAmount.Text;
                isApplied = false;
                userControlPOS.UpdatePriceAfterVat(userControlPOS.LabelBeforeVatText);
                this.Close();
            }
            else
            {
                messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Fail, FormMessageBox.eMessageBoxTypes.ApplyFirst);
            }
        }

        private void TextBoxDiscountPrecentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilitiesMethods.OnlyDigitsAllowed(sender as TextBox, e, UtilitiesMethods.eNumberType.WholeNumber);
        }

        private void TextBoxDiscountPrecentage_Enter(object sender, EventArgs e)
        {
            TextBoxDiscountPrecentage.Text = "";
            TextBoxDiscountPrecentage.ForeColor = Color.Black;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (TextBoxDiscountPrecentage.Text != "")
            {
                TextBoxDiscountAmount.Text = (float.Parse(userControlPOS.LabelTotalPrice) * (float.Parse(TextBoxDiscountPrecentage.Text) / 100)).ToString("F2");
            }

            isApplied = true;
        }
    }
}
