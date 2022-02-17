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

        }
    }
}
