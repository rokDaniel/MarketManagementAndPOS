using Logic.Data_Layer;
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
    public partial class FormOrderQuantity : Form
    {
        private readonly FormMessageBox MessageBoxForm = new FormMessageBox();
        private readonly UserControlPOS userControlPOS;
        private readonly FormSearchProduct formSearchProduct;
        private int productQuantityToOrder;
        private float totalPrice = 0;
        private string unitPrice;

        public FormOrderQuantity(FormSearchProduct SearchForm, UserControlPOS POS)
        {
            InitializeComponent();
            formSearchProduct = SearchForm;
            userControlPOS = POS;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBoxQuantityToOrder.Text, out productQuantityToOrder) || productQuantityToOrder == 0)
            {
                MessageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Warning, FormMessageBox.eMessageBoxTypes.EnterValidNumber);
            }
            else
            {
                if (productQuantityToOrder <= DbStock.GetProductQuantity(FormSearchProduct.CurrentProduct.Code))
                {
                    userControlPOS.LabelBeforeVatText = updateCartPrice();
                    FormSearchProduct.CurrentProduct.Quantity = productQuantityToOrder;
                    UserControlPOS.UpdateCart(FormSearchProduct.CurrentProduct);
                    DbStock.ReduceProductQuantity(FormSearchProduct.CurrentProduct.Code, productQuantityToOrder);
                    formSearchProduct.RefreshGrid();
                    MessageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Success, FormMessageBox.eMessageBoxTypes.ProductAddedSuccessfully);
                    this.Close();
                }
                else
                {
                    MessageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Fail, FormMessageBox.eMessageBoxTypes.NotEnoughInStock);
                }
            }
        }

        private string updateCartPrice()
        {
            int quantity = productQuantityToOrder;
            float unitPrice = formSearchProduct.GetProductPrice();

            totalPrice += quantity * unitPrice;

            return totalPrice.ToString();
        }

        private void TextBoxQuantityToOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilitiesMethods.OnlyDigitsAllowed(sender as TextBox, e, UtilitiesMethods.eNumberType.WholeNumber);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            productQuantityToOrder = 0;
            this.Close();
        }

        private void FormOrderQuantity_Load(object sender, EventArgs e)
        {
            TextBoxQuantityToOrder.Text = "";
        }
    }
}
