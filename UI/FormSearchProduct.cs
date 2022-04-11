using Logic.Business_Layer;
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
using static Logic.Business_Layer.Product;

namespace UI
{
    public partial class FormSearchProduct : Form
    {
        private  readonly FormOrderQuantity newOrder;
        private static Product currentProduct;
        DataGridViewButtonColumn actionButton = new DataGridViewButtonColumn();
        private bool buttonAdded = false;

        public static Product CurrentProduct => currentProduct;

        public FormSearchProduct(UserControlPOS userControlPOS)
        {
            InitializeComponent();
            currentProduct = new Product();
            newOrder = new FormOrderQuantity(this, userControlPOS);
            DataGridViewStock.DataSource = DbPOS.GetAllProducts();
        }

        private void FormSearchProduct_Load(object sender, EventArgs e)
        {
            newOrder.FormClosed += new FormClosedEventHandler(Form_Closed);
            initializeButtonColumn();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            DataGridViewStock.DataSource = DbPOS.GetAllProducts();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSearchProduct_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void initializeButtonColumn()
        {
            if (!buttonAdded)
            {
                actionButton.HeaderText = "Action";
                actionButton.Name = "AddToCart";
                actionButton.Text = "Add To Cart";
                actionButton.FlatStyle = FlatStyle.Flat;
                actionButton.DefaultCellStyle.BackColor = Color.FromArgb(0, 117, 214);
                actionButton.UseColumnTextForButtonValue = true;
                buttonAdded = true;
                DataGridViewStock.Columns.Insert(2, actionButton);
            }

        }

        internal void RefreshGrid()
        {
            DataGridViewStock.DataSource = DbPOS.GetAllProducts();
        }

        private void DataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewStock.Columns[e.ColumnIndex].Name == "AddToCart")
            {
                currentProduct.Name = DataGridViewStock.SelectedRows[0].Cells["ProductName"].Value.ToString();
                currentProduct.Code = DataGridViewStock.SelectedRows[0].Cells["Code"].Value.ToString();
                currentProduct.Description = DataGridViewStock.SelectedRows[0].Cells["Description"].Value.ToString();
                currentProduct.Category = (eCategory)Enum.Parse(typeof(eCategory), DataGridViewStock.SelectedRows[0]
                    .Cells["Category"].Value.ToString().Replace(" ", ""));
                currentProduct.Price = float.Parse(DataGridViewStock.SelectedRows[0].Cells["UnitPrice"].Value.ToString());
                newOrder.ShowDialog();
            }
        }

        public float GetProductPrice()
        {
            return float.Parse(DataGridViewStock.SelectedRows[0].Cells[5].Value.ToString());
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            UtilitiesMethods.EnableWindowDrag(e, Handle);
        }
    }
}
