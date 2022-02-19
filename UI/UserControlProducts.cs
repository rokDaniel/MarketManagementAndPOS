using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Business_Layer;
using Logic.Data_Layer;

namespace UI
{
    public partial class UserControlProducts : UserControl
    {
        private readonly FormMessageBox messageBoxForm;
        private readonly List<Control> productInfo;

        public UserControlProducts()
        {
            InitializeComponent();
            messageBoxForm = new FormMessageBox();
            productInfo = new List<Control>
            { TextBoxDescription, ComboBoxCategory, TextBoxPrice };
        }

        private void UserControlProducts_Load(object sender, EventArgs e)
        {
            DatagreedviewProducts.DataSource = DbProducts.GetAllProducts();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DatagreedviewProducts.DataSource = DbProducts.SearchProduct(TextBoxSearch.Text);
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            DatagreedviewProducts.DataSource = DbProducts.GetAllProducts();
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            TextBoxSearch.Text = "";
            TextBoxSearch.ForeColor = Color.Black;
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "")
            {
                TextBoxSearch.ForeColor = Color.Silver;
                TextBoxSearch.Text = "Type name or code here";
            }
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch.PerformClick();
            }
        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            TextBoxCode.Text = string.Empty;
            TextBoxName.Text = string.Empty;
            TextBoxDescription.Text = string.Empty;
            ComboBoxCategory.Text = string.Empty;
            TextBoxPrice.Text = string.Empty;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (isInfoValid())
            {
                Product newProduct = new Product(TextBoxName.Text, TextBoxDescription.Text,
                    ComboBoxCategory.SelectedIndex, float.Parse(TextBoxPrice.Text));

                if (DbProducts.AddProduct(newProduct))
                {
                    DatagreedviewProducts.DataSource = DbProducts.GetAllProducts();
                    messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Success, FormMessageBox.eMessageBoxTypes.ProductAddedSuccessfully);
                    clearFields();
                }
                else
                {
                    messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Fail, FormMessageBox.eMessageBoxTypes.ProductCouldNotBeAdded);
                }
            }
            else
            {
                messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Warning, FormMessageBox.eMessageBoxTypes.MissingDetails);
            }
        }

        public bool isInfoValid()
        {
            foreach (Control control in productInfo)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxCode.Text))
            {
                DbProducts.DeleteProduct(TextBoxCode.Text);
                clearFields();
                DatagreedviewProducts.DataSource = DbProducts.GetAllProducts();
            }
            else
            {
                messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Warning, FormMessageBox.eMessageBoxTypes.ItemWasNotSelected);
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (isInfoValid())
            {
                Product productToUpdate = new Product(TextBoxCode.Text, TextBoxName.Text, TextBoxDescription.Text,
                    ComboBoxCategory.SelectedIndex, float.Parse(TextBoxPrice.Text));

                if (DbProducts.UpdateProduct(productToUpdate))
                {
                    messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Success, FormMessageBox.eMessageBoxTypes.ProductUpdatedSuccessfully);
                    DatagreedviewProducts.DataSource = DbProducts.GetAllProducts();
                }
            }
            else
            {
                messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Warning, FormMessageBox.eMessageBoxTypes.ItemWasNotSelected);
            }
        }

        private void DatagreedviewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (DatagreedviewProducts.SelectedRows.Count > 0)
            {
                TextBoxCode.Text = DatagreedviewProducts.SelectedRows[0].Cells[1].Value.ToString();
                TextBoxName.Text = DatagreedviewProducts.SelectedRows[0].Cells[2].Value.ToString();
                TextBoxDescription.Text = DatagreedviewProducts.SelectedRows[0].Cells[3].Value.ToString();
                ComboBoxCategory.SelectedIndex = ComboBoxCategory.
                    FindStringExact(DatagreedviewProducts.SelectedRows[0].Cells[4].Value.ToString());
                TextBoxPrice.Text = DatagreedviewProducts.SelectedRows[0].Cells[5].Value.ToString();

            }
        }

        private void DatagreedviewProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DatagreedviewProducts.ClearSelection();
            clearFields();
        }
    }
}
