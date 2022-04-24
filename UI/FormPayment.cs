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
    public partial class FormPayment : Form
    {
        UserControlPOS userControlPOS;
        float totalPrice;
        float paid;

        public FormPayment(UserControlPOS POS)
        {
            InitializeComponent();
            userControlPOS = POS;
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            TextBoxTotalPrice.Text = userControlPOS.LabelTotalPrice;
            totalPrice = float.Parse(TextBoxTotalPrice.Text);
        }

        private void TextBoxPayment_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPayment.Text != "")
            {
                paid = float.Parse(TextBoxPayment.Text);
                textBoxChange.Text = (-(totalPrice - paid)).ToString("F2");
            }
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            UtilitiesMethods.EnableWindowDrag(e, Handle);
        }

        private void TextBoxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilitiesMethods.OnlyDigitsAllowed(sender as TextBox, e, UtilitiesMethods.eNumberType.RationalNumber);
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            UserControlPOS.Income += float.Parse(TextBoxTotalPrice.Text);
            //UserControlPOS.TotalSold += userControlPOS.ShoppingCart.Rows.Count;
            UserControlPOS.TotalTransactions++;
            foreach (DataRow row in userControlPOS.ShoppingCart.Rows)
            {
                UserControlPOS.TotalSold += int.Parse(row["quantity"].ToString());
            }
            userControlPOS.ClearCart();
            this.Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPayment_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                TextBoxPayment.Text = "";
            }
        }
    }
}
