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
using Logic.HelperMethods;

namespace UI
{
    public partial class UserControlProducts : UserControl
    {
        private readonly FormMessageBox messageBoxForm;
        private readonly List<Control> productInfo;
        private string itemToSearch;

        public UserControlProducts()
        {
            InitializeComponent();
            messageBoxForm = new FormMessageBox();
            productInfo = new List<Control>
            { TextBoxName, TextBoxDescription, ComboBoxCategory, TextBoxPrice };
        }

        private void UserControlProducts_Load(object sender, EventArgs e)
        {
            DatagridviewProducts.DataSource = DbProducts.GetAllProducts();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DatagridviewProducts.DataSource = DbProducts.SearchProduct(itemToSearch);
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            DatagridviewProducts.DataSource = DbProducts.GetAllProducts();
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            TextBoxSearch.Text = "";
            TextBoxSearch.ForeColor = Color.Black;
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            handleSearchLeave();
        }

        private void handleSearchLeave()
        {
            itemToSearch = TextBoxSearch.Text;
            TextBoxSearch.ForeColor = Color.Silver;
            TextBoxSearch.Text = "Type name or code here";
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handleSearchLeave();
                ButtonSearch.PerformClick();
                ButtonSearch.Focus();
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
            TextBoxQuantity.Enabled = true;
            TextBoxQuantity.BackColor = SystemColors.Control;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (isInfoValid() && isNewProduct(TextBoxCode.Text))
            {
                Product newProduct = new Product(TextBoxName.Text, TextBoxDescription.Text,
                    int.Parse(TextBoxQuantity.Text), ComboBoxCategory.SelectedIndex, float.Parse(TextBoxPrice.Text));

                if (DbProducts.AddProduct(newProduct))
                {
                    DatagridviewProducts.DataSource = DbProducts.GetAllProducts();
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

        private bool isNewProduct(string code)
        {
            return code.Equals("");
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
            UtilitiesMethods.OnlyDigitsAllowed(sender as TextBox, e, UtilitiesMethods.eNumberType.RationalNumber);
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxCode.Text))
            {
                DbProducts.DeleteProduct(TextBoxCode.Text);
                clearFields();
                DatagridviewProducts.DataSource = DbProducts.GetAllProducts();
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
                    DatagridviewProducts.DataSource = DbProducts.GetAllProducts();
                }
            }
            else
            {
                messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Warning, FormMessageBox.eMessageBoxTypes.ItemWasNotSelected);
            }
        }

        private void DatagreedviewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (DatagridviewProducts.SelectedRows.Count > 0)
            {
                TextBoxCode.Text = DatagridviewProducts.SelectedRows[0].Cells[1].Value.ToString();
                TextBoxName.Text = DatagridviewProducts.SelectedRows[0].Cells[2].Value.ToString();
                TextBoxDescription.Text = DatagridviewProducts.SelectedRows[0].Cells[3].Value.ToString();
                ComboBoxCategory.SelectedIndex = ComboBoxCategory.
                    FindStringExact(DatagridviewProducts.SelectedRows[0].Cells[4].Value.ToString());
                TextBoxPrice.Text = DatagridviewProducts.SelectedRows[0].Cells[5].Value.ToString();
                TextBoxQuantity.Enabled = false;
                TextBoxQuantity.BackColor = SystemColors.ControlLight;
            }
        }

        private void DatagreedviewProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DatagridviewProducts.ClearSelection();
            clearFields();
        }

        private void TextBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilitiesMethods.OnlyDigitsAllowed(sender as TextBox, e, UtilitiesMethods.eNumberType.WholeNumber);
        }
    }
}
