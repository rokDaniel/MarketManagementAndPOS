using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Data_Layer;
using Logic.HelperMethods;

namespace UI
{
    public partial class UserControlStock : UserControl
    {
        private DataTable ProductsToOrder;
        private string itemToSearch;
        private string quantityToAdd;
        private readonly FormMessageBox messageBoxForm;
        private readonly List<Control> productInfo;
        private int currentPruductNumber;
        private string currentProductCode;
        private string currentProductName;
        private string currentProductDescription;
        private string selectedProductCode;

        public UserControlStock()
        {
            InitializeComponent();
            InitializeOrderDataTable();
            messageBoxForm = new FormMessageBox();
            productInfo = new List<Control> { TextBoxCode, TextBoxName };
        }

        private void InitializeOrderDataTable()
        {
            ProductsToOrder = new DataTable();
            DataColumn orderCol = ProductsToOrder.Columns.Add("#", typeof(int));
            
            orderCol.AllowDBNull = false;
            orderCol.Unique = true;

            ProductsToOrder.Columns.Add("ProductName", typeof(string));
            ProductsToOrder.Columns.Add("Code", typeof(string));
            ProductsToOrder.Columns.Add("Description", typeof(string));
            ProductsToOrder.Columns.Add("Quantity", typeof(int));
        }

        private void UserControlStock_Load(object sender, EventArgs e)
        {
            DatagridviewStock.DataSource = DbStock.GetStock();
            DataGridViewOrder.DataSource = ProductsToOrder;
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            TextBoxSearch.Text = "";
            TextBoxSearch.ForeColor = Color.Black;
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            itemToSearch = TextBoxSearch.Text;
            TextBoxSearch.ForeColor = Color.Silver;
            TextBoxSearch.Text = "Type name or code here";
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DatagridviewStock.DataSource = DbStock.SearchProduct(itemToSearch);
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            DatagridviewStock.DataSource = DbStock.GetStock();
        }

        private void TextBoxQuantity_Enter(object sender, EventArgs e)
        {
            TextBoxQuantity.Text = "";
            TextBoxQuantity.ForeColor = Color.Black;
        }

        private void TextBoxQuantity_Leave(object sender, EventArgs e)
        {
            handleQuantityLeave();
        }

        private void handleSearchLeave()
        {
            itemToSearch = TextBoxSearch.Text;
            TextBoxSearch.ForeColor = Color.Silver;
            TextBoxSearch.Text = "Type name or code here";
        }

        private void handleQuantityLeave()
        {
            quantityToAdd = TextBoxQuantity.Text;
            TextBoxQuantity.ForeColor = Color.Silver;
            TextBoxQuantity.Text = "Enter how many units you want to order.";
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

        private void TextBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handleQuantityLeave();
                ButtonAdd.PerformClick();
                ButtonAdd.Focus();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (DatagridviewStock.SelectedRows.Count > 0) {
                DataRow newProductOrder = ProductsToOrder.NewRow();

                newProductOrder["#"] = currentPruductNumber;
                newProductOrder["Code"] = currentProductCode;
                newProductOrder["ProductName"] = currentProductName;
                newProductOrder["Description"] = currentProductDescription;
                newProductOrder["Quantity"] = quantityToAdd;
                ProductsToOrder.Rows.Add(newProductOrder);
            }
        }

        private void DatagreedviewStock_SelectionChanged(object sender, EventArgs e)
        {
            if (DatagridviewStock.SelectedRows.Count > 0)
            {
                currentPruductNumber = int.Parse(DatagridviewStock.SelectedRows[0].Cells[0].Value.ToString());
                currentProductCode = DatagridviewStock.SelectedRows[0].Cells[1].Value.ToString();
                currentProductName = DatagridviewStock.SelectedRows[0].Cells[2].Value.ToString();
                currentProductDescription = DatagridviewStock.SelectedRows[0].Cells[3].Value.ToString();

                TextBoxCode.Text = currentProductCode;
                TextBoxName.Text = currentProductName;
            }

        }

        private void TextBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilitiesMethods.OnlyDigitsAllowed(sender as TextBox, e, UtilitiesMethods.eNumberType.WholeNumber);
        }

        private void ButtonCommitOrder_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ProductsToOrder.Rows)
            {
                DbStock.updateQuantity(row["Code"].ToString(), int.Parse(row["Quantity"].ToString()));
            }

            DatagridviewStock.DataSource = DbStock.GetStock();
            ProductsToOrder.Rows.Clear();

            messageBoxForm.ShowMessageBox(FormMessageBox.eMessageBoxGroups.Success, FormMessageBox.eMessageBoxTypes.StockHasBeenAdded);
        }

        private void UserControlStock_VisibleChanged(object sender, EventArgs e)
        {
            DatagridviewStock.DataSource = DbStock.GetStock();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            selectedProductCode = DataGridViewOrder.SelectedRows[0].Cells[2].Value.ToString();
            foreach (DataRow row in ProductsToOrder.Rows)
            {
                if ((string)row["Code"] == selectedProductCode)
                {
                    row.Delete();
                    break;
                }
            }

            ProductsToOrder.AcceptChanges();
            DataGridViewOrder.DataSource = ProductsToOrder;
        }
    }
}
