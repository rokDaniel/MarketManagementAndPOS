using Logic.Business_Layer;
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
    public partial class UserControlPOS : UserControl
    {
        private const string defaultTransactionNo = "000000000000";
        private FormSearchProduct searchProductForm;
        private FormDiscount discountForm;
        private FormPayment paymentForm;
        private Random random = new Random();
        private static DataTable shoppingCart;
        private static float income = 0;
        private static int totalSold = 0;
        private static int totalTransactions;

        public static int TotalTransactions
        {
            get
            {
                return totalTransactions;
            }
            set
            {
                totalTransactions = value;
            }
        }

        public DataTable ShoppingCart
        {
            get
            {
                return shoppingCart;
            }
        }

        public static int TotalSold
        {
            get
            {
                return totalSold;
            }
            set
            {
                totalSold = value;
            }
        }

        public static float Income
        {
            get
            {
                return income;
            }
            set
            {
                income = value;
            }
        }

        public String LabelBeforeVatText
        {
            get
            {
                return LabelBeforeVat.Text;
            }
            set
            {
                this.LabelBeforeVat.Text = value;
            }
        }

        public String LabelTotalPrice
        {
            get
            {
                return this.LabelTotalSmall.Text;
            }
        }

        public String LabelTotalDiscount
        {
            set
            {
                this.LabelDiscount.Text = value;
            }
        }

        public UserControlPOS()
        {
            InitializeComponent();
            InitializeOrderShoppingCart();
            searchProductForm = new FormSearchProduct(this);
            discountForm = new FormDiscount(this);
            paymentForm = new FormPayment(this);
        }

        private void InitializeOrderShoppingCart()
        {
            shoppingCart = new DataTable();
            DataColumn orderCol = shoppingCart.Columns.Add("#", typeof(int));

            orderCol.AllowDBNull = false;
            orderCol.Unique = true;
            orderCol.AutoIncrement = true;

            shoppingCart.Columns.Add("ProductName", typeof(string));
            shoppingCart.Columns.Add("Code", typeof(string));
            shoppingCart.Columns.Add("Description", typeof(string));
            shoppingCart.Columns.Add("Category", typeof(string));
            shoppingCart.Columns.Add("Quantity", typeof(int));
            shoppingCart.Columns.Add("Price", typeof(float));
            shoppingCart.Columns.Add("Subtotal", typeof(float));
        }

        private void UserControlPOS_Load(object sender, EventArgs e)
        {
            DataGridViewCart.DataSource = shoppingCart;
        }

        private void ButtonNewTransaction_Click(object sender, EventArgs e)
        {
            LabelTransactionNo.Text = getTransactionNo();
            changeButtonsStates();
        }

        private void changeButtonsStates()
        {
            ButtonNewTransaction.Enabled = !ButtonNewTransaction.Enabled;
            ButtonSearchProduct.Enabled = !ButtonSearchProduct.Enabled;
            ButtonAddDiscount.Enabled = !ButtonAddDiscount.Enabled;
            ButtonMakePayment.Enabled = !ButtonMakePayment.Enabled;
            ButtonClearCart.Enabled = !ButtonClearCart.Enabled;
        }

        public static void UpdateCart(Product product)
        {
            DataRow productToAdd = shoppingCart.NewRow();

            productToAdd["Code"] = product.Code;
            productToAdd["ProductName"] = product.Name;
            productToAdd["Description"] = product.Description;
            productToAdd["Category"] = product.Category;
            productToAdd["Quantity"] = product.Quantity;
            productToAdd["Price"] = product.Price;
            productToAdd["Subtotal"] = product.Price * product.Quantity;
            shoppingCart.Rows.Add(productToAdd);
            
        }

        private string getTransactionNo()
        {
            string transactionNo = random.Next(999999).ToString();

            transactionNo = transactionNo + random.Next(999999).ToString();

            return transactionNo;
        }

        private void ButtonSearchProduct_Click(object sender, EventArgs e)
        {
            searchProductForm.ShowDialog();
        }

        private void ButtonAddDiscount_Click(object sender, EventArgs e)
        {
            discountForm.ShowDialog();
        }

        private void LabelBeforeVat_TextChanged(object sender, EventArgs e)
        {
            Label priceLabel = sender as Label;
            updateVatTotal(priceLabel);
            UpdatePriceAfterVat(priceLabel.Text);
        }

        public void UpdatePriceAfterVat(string priceLabel)
        {
            float orderPrice = float.Parse(priceLabel);
            float discount = float.Parse(LabelDiscount.Text) / 100;
            string total = ((orderPrice - (orderPrice * discount)) * 1.17).ToString("F2");

            this.LabelTotalSmall.Text = total;
            this.LabelTotalBig.Text = total;
        }

        private void updateVatTotal(Label priceLabel)
        {
            float orderPrice = float.Parse(priceLabel.Text);

            this.LabelVat.Text = (orderPrice * 0.17).ToString("F2");
        }

        private void ButtonMakePayment_Click(object sender, EventArgs e)
        {
            paymentForm.ShowDialog();
        }

        public void ClearCart()
        {
            shoppingCart.Rows.Clear();
            shoppingCart.Columns["#"].AutoIncrementStep = -1;
            shoppingCart.Columns["#"].AutoIncrementSeed = -1;
            shoppingCart.Columns["#"].AutoIncrementStep = 1;
            shoppingCart.Columns["#"].AutoIncrementSeed = -1;
            DataGridViewCart.Update();
            DataGridViewCart.Refresh();

            LabelTotalBig.Text = "0.00";
            LabelTotalSmall.Text = "0.00";
            LabelDiscount.Text = "0.00";
            LabelVat.Text = "0.00";
            LabelBeforeVat.Text = "0.00";

            LabelTransactionNo.Text = defaultTransactionNo;
            changeButtonsStates();
        }

        private void ButtonClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
        }
    }
}
