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

namespace UI
{
    public partial class UserControlStock : UserControl
    {
        private DataTable ProductsToOrder;
        private readonly FormMessageBox messageBoxForm;
        private readonly List<Control> productInfo;

        public UserControlStock()
        {
            InitializeComponent();
            ProductsToOrder = new DataTable();
            messageBoxForm = new FormMessageBox();
            productInfo = new List<Control> { TextBoxCode, TextBoxName };
        }

        private void UserControlStock_Load(object sender, EventArgs e)
        {
            DatagreedviewStock.DataSource = DbStock.GetStock();
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DatagreedviewStock.DataSource = DbStock.SearchProduct(TextBoxSearch.Text);
        }
    }
}
