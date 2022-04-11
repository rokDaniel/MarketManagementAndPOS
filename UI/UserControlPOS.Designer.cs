
namespace UI
{
    partial class UserControlPOS
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewCart = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonSearchProduct = new System.Windows.Forms.Button();
            this.ButtonAddDiscount = new System.Windows.Forms.Button();
            this.ButtonMakePayment = new System.Windows.Forms.Button();
            this.ButtonClearCart = new System.Windows.Forms.Button();
            this.ButtonNewTransaction = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelTransactionNo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelBeforeVat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelVat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelDiscount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelTotalSmall = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelTotalBig = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TextBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCart)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewCart
            // 
            this.DataGridViewCart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridViewCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGridViewCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewCart.ColumnHeadersHeight = 28;
            this.DataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ProductName,
            this.Code,
            this.Description,
            this.Quantity,
            this.UnitPrice,
            this.Discount,
            this.Subtotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCart.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewCart.EnableHeadersVisualStyles = false;
            this.DataGridViewCart.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridViewCart.Location = new System.Drawing.Point(0, 144);
            this.DataGridViewCart.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewCart.MultiSelect = false;
            this.DataGridViewCart.Name = "DataGridViewCart";
            this.DataGridViewCart.ReadOnly = true;
            this.DataGridViewCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewCart.RowHeadersVisible = false;
            this.DataGridViewCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCart.Size = new System.Drawing.Size(895, 511);
            this.DataGridViewCart.TabIndex = 15;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "#";
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 40;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "code";
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 110;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 110;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 120;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 170;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "Price";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(901, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 592);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.ButtonSearchProduct);
            this.panel3.Controls.Add(this.ButtonAddDiscount);
            this.panel3.Controls.Add(this.ButtonMakePayment);
            this.panel3.Controls.Add(this.ButtonClearCart);
            this.panel3.Controls.Add(this.ButtonNewTransaction);
            this.panel3.Location = new System.Drawing.Point(901, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 383);
            this.panel3.TabIndex = 21;
            // 
            // ButtonSearchProduct
            // 
            this.ButtonSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonSearchProduct.Enabled = false;
            this.ButtonSearchProduct.FlatAppearance.BorderSize = 0;
            this.ButtonSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.ButtonSearchProduct.Image = global::UI.Properties.Resources.IconShoppingCart2;
            this.ButtonSearchProduct.Location = new System.Drawing.Point(0, 64);
            this.ButtonSearchProduct.Name = "ButtonSearchProduct";
            this.ButtonSearchProduct.Size = new System.Drawing.Size(224, 49);
            this.ButtonSearchProduct.TabIndex = 22;
            this.ButtonSearchProduct.Text = "Search Product";
            this.ButtonSearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearchProduct.UseVisualStyleBackColor = false;
            this.ButtonSearchProduct.Click += new System.EventHandler(this.ButtonSearchProduct_Click);
            // 
            // ButtonAddDiscount
            // 
            this.ButtonAddDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonAddDiscount.Enabled = false;
            this.ButtonAddDiscount.FlatAppearance.BorderSize = 0;
            this.ButtonAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddDiscount.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddDiscount.Image = global::UI.Properties.Resources.IconDiscount2;
            this.ButtonAddDiscount.Location = new System.Drawing.Point(0, 125);
            this.ButtonAddDiscount.Name = "ButtonAddDiscount";
            this.ButtonAddDiscount.Size = new System.Drawing.Size(224, 49);
            this.ButtonAddDiscount.TabIndex = 21;
            this.ButtonAddDiscount.Text = "Add Discount";
            this.ButtonAddDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAddDiscount.UseVisualStyleBackColor = false;
            this.ButtonAddDiscount.Click += new System.EventHandler(this.ButtonAddDiscount_Click);
            // 
            // ButtonMakePayment
            // 
            this.ButtonMakePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonMakePayment.Enabled = false;
            this.ButtonMakePayment.FlatAppearance.BorderSize = 0;
            this.ButtonMakePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMakePayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMakePayment.ForeColor = System.Drawing.Color.Black;
            this.ButtonMakePayment.Image = global::UI.Properties.Resources.IconCreditCard2;
            this.ButtonMakePayment.Location = new System.Drawing.Point(0, 186);
            this.ButtonMakePayment.Name = "ButtonMakePayment";
            this.ButtonMakePayment.Size = new System.Drawing.Size(224, 49);
            this.ButtonMakePayment.TabIndex = 20;
            this.ButtonMakePayment.Text = "Payment";
            this.ButtonMakePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonMakePayment.UseVisualStyleBackColor = false;
            // 
            // ButtonClearCart
            // 
            this.ButtonClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonClearCart.Enabled = false;
            this.ButtonClearCart.FlatAppearance.BorderSize = 0;
            this.ButtonClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearCart.ForeColor = System.Drawing.Color.Black;
            this.ButtonClearCart.Image = global::UI.Properties.Resources.IconClearCart2;
            this.ButtonClearCart.Location = new System.Drawing.Point(0, 247);
            this.ButtonClearCart.Name = "ButtonClearCart";
            this.ButtonClearCart.Size = new System.Drawing.Size(224, 49);
            this.ButtonClearCart.TabIndex = 19;
            this.ButtonClearCart.Text = "Clear Cart";
            this.ButtonClearCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonClearCart.UseVisualStyleBackColor = false;
            // 
            // ButtonNewTransaction
            // 
            this.ButtonNewTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonNewTransaction.FlatAppearance.BorderSize = 0;
            this.ButtonNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNewTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNewTransaction.ForeColor = System.Drawing.Color.White;
            this.ButtonNewTransaction.Image = global::UI.Properties.Resources.IconDollarSign2;
            this.ButtonNewTransaction.Location = new System.Drawing.Point(0, 3);
            this.ButtonNewTransaction.Name = "ButtonNewTransaction";
            this.ButtonNewTransaction.Size = new System.Drawing.Size(224, 49);
            this.ButtonNewTransaction.TabIndex = 18;
            this.ButtonNewTransaction.Text = "New Transaction";
            this.ButtonNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNewTransaction.UseVisualStyleBackColor = false;
            this.ButtonNewTransaction.Click += new System.EventHandler(this.ButtonNewTransaction_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.LabelTransactionNo);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(901, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 90);
            this.panel2.TabIndex = 20;
            // 
            // LabelTransactionNo
            // 
            this.LabelTransactionNo.AutoSize = true;
            this.LabelTransactionNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTransactionNo.ForeColor = System.Drawing.Color.White;
            this.LabelTransactionNo.Location = new System.Drawing.Point(51, 43);
            this.LabelTransactionNo.Name = "LabelTransactionNo";
            this.LabelTransactionNo.Size = new System.Drawing.Size(144, 25);
            this.LabelTransactionNo.TabIndex = 9;
            this.LabelTransactionNo.Text = "000000000000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 21);
            this.label14.TabIndex = 8;
            this.label14.Text = "Transaction No:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.LabelBeforeVat);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.LabelVat);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.LabelDiscount);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.LabelTotalSmall);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(901, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 100);
            this.panel4.TabIndex = 19;
            // 
            // LabelBeforeVat
            // 
            this.LabelBeforeVat.AutoSize = true;
            this.LabelBeforeVat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBeforeVat.ForeColor = System.Drawing.Color.White;
            this.LabelBeforeVat.Location = new System.Drawing.Point(176, 74);
            this.LabelBeforeVat.Name = "LabelBeforeVat";
            this.LabelBeforeVat.Size = new System.Drawing.Size(32, 17);
            this.LabelBeforeVat.TabIndex = 7;
            this.LabelBeforeVat.Text = "0.00";
            this.LabelBeforeVat.TextChanged += new System.EventHandler(this.LabelBeforeVat_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "EXCL VAT";
            // 
            // LabelVat
            // 
            this.LabelVat.AutoSize = true;
            this.LabelVat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVat.ForeColor = System.Drawing.Color.White;
            this.LabelVat.Location = new System.Drawing.Point(176, 54);
            this.LabelVat.Name = "LabelVat";
            this.LabelVat.Size = new System.Drawing.Size(32, 17);
            this.LabelVat.TabIndex = 5;
            this.LabelVat.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "VAT";
            // 
            // LabelDiscount
            // 
            this.LabelDiscount.AutoSize = true;
            this.LabelDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDiscount.ForeColor = System.Drawing.Color.White;
            this.LabelDiscount.Location = new System.Drawing.Point(176, 34);
            this.LabelDiscount.Name = "LabelDiscount";
            this.LabelDiscount.Size = new System.Drawing.Size(32, 17);
            this.LabelDiscount.TabIndex = 3;
            this.LabelDiscount.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "DISCOUNT";
            // 
            // LabelTotalSmall
            // 
            this.LabelTotalSmall.AutoSize = true;
            this.LabelTotalSmall.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalSmall.ForeColor = System.Drawing.Color.White;
            this.LabelTotalSmall.Location = new System.Drawing.Point(162, 9);
            this.LabelTotalSmall.Name = "LabelTotalSmall";
            this.LabelTotalSmall.Size = new System.Drawing.Size(50, 25);
            this.LabelTotalSmall.TabIndex = 1;
            this.LabelTotalSmall.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "TOTAL";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
            this.panel6.Controls.Add(this.LabelTotalBig);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1132, 69);
            this.panel6.TabIndex = 23;
            // 
            // LabelTotalBig
            // 
            this.LabelTotalBig.AutoSize = true;
            this.LabelTotalBig.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalBig.ForeColor = System.Drawing.Color.LawnGreen;
            this.LabelTotalBig.Location = new System.Drawing.Point(1011, 13);
            this.LabelTotalBig.Name = "LabelTotalBig";
            this.LabelTotalBig.Size = new System.Drawing.Size(89, 47);
            this.LabelTotalBig.TabIndex = 8;
            this.LabelTotalBig.Text = "0.00";
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(903, 89);
            this.panel7.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.TextBoxUnitPrice);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.TextBoxTotal);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.TextBoxQuantity);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.TextBoxName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.TextBoxCode);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(0, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(895, 76);
            this.panel8.TabIndex = 24;
            // 
            // TextBoxUnitPrice
            // 
            this.TextBoxUnitPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxUnitPrice.Enabled = false;
            this.TextBoxUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.TextBoxUnitPrice.Location = new System.Drawing.Point(707, 14);
            this.TextBoxUnitPrice.Name = "TextBoxUnitPrice";
            this.TextBoxUnitPrice.Size = new System.Drawing.Size(128, 20);
            this.TextBoxUnitPrice.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(635, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Unit Price:";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTotal.Enabled = false;
            this.TextBoxTotal.ForeColor = System.Drawing.Color.Black;
            this.TextBoxTotal.Location = new System.Drawing.Point(707, 47);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.Size = new System.Drawing.Size(128, 20);
            this.TextBoxTotal.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(635, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Subtotal:";
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxQuantity.Enabled = false;
            this.TextBoxQuantity.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxQuantity.Location = new System.Drawing.Point(431, 14);
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(141, 20);
            this.TextBoxQuantity.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(366, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Quantity:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Enabled = false;
            this.TextBoxName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxName.Location = new System.Drawing.Point(179, 47);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(393, 20);
            this.TextBoxName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Product Name:";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCode.Enabled = false;
            this.TextBoxCode.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCode.Location = new System.Drawing.Point(179, 14);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(141, 20);
            this.TextBoxCode.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Product Code:";
            // 
            // UserControlPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridViewCart);
            this.Name = "UserControlPOS";
            this.Size = new System.Drawing.Size(1132, 655);
            this.Load += new System.EventHandler(this.UserControlPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonSearchProduct;
        private System.Windows.Forms.Button ButtonAddDiscount;
        private System.Windows.Forms.Button ButtonMakePayment;
        private System.Windows.Forms.Button ButtonClearCart;
        private System.Windows.Forms.Button ButtonNewTransaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelTransactionNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LabelBeforeVat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelVat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelTotalSmall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LabelTotalBig;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TextBoxUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}
