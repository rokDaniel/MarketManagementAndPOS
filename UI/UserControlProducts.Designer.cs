
namespace UI
{
    partial class UserControlProducts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ButtonDeleteProduct = new System.Windows.Forms.Button();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.ButtonClearFields = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DatagreedviewProducts = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupboxSearch = new System.Windows.Forms.GroupBox();
            this.ButtonClearSearch = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagreedviewProducts)).BeginInit();
            this.GroupboxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Controls.Add(this.ButtonDeleteProduct);
            this.groupBox1.Controls.Add(this.ComboBoxCategory);
            this.groupBox1.Controls.Add(this.ButtonClearFields);
            this.groupBox1.Controls.Add(this.ButtonUpdate);
            this.groupBox1.Controls.Add(this.ButtonAddProduct);
            this.groupBox1.Controls.Add(this.TextBoxPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBoxDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(678, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 394);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Location = new System.Drawing.Point(129, 67);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(278, 25);
            this.TextBoxName.TabIndex = 14;
            // 
            // ButtonDeleteProduct
            // 
            this.ButtonDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteProduct.Location = new System.Drawing.Point(222, 323);
            this.ButtonDeleteProduct.Name = "ButtonDeleteProduct";
            this.ButtonDeleteProduct.Size = new System.Drawing.Size(172, 38);
            this.ButtonDeleteProduct.TabIndex = 13;
            this.ButtonDeleteProduct.Text = "Delete Product";
            this.ButtonDeleteProduct.UseVisualStyleBackColor = false;
            this.ButtonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProduct_Click);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Items.AddRange(new object[] {
            "Fruits and Vegetables",
            "Diary",
            "Meat",
            "Baked and Bread",
            "Alcohol and Beverage",
            "Cooking and Baking"});
            this.ComboBoxCategory.Location = new System.Drawing.Point(129, 176);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(277, 25);
            this.ComboBoxCategory.TabIndex = 4;
            // 
            // ButtonClearFields
            // 
            this.ButtonClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearFields.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearFields.ForeColor = System.Drawing.Color.White;
            this.ButtonClearFields.Location = new System.Drawing.Point(43, 323);
            this.ButtonClearFields.Name = "ButtonClearFields";
            this.ButtonClearFields.Size = new System.Drawing.Size(172, 38);
            this.ButtonClearFields.TabIndex = 11;
            this.ButtonClearFields.Text = "Clear Fields";
            this.ButtonClearFields.UseVisualStyleBackColor = false;
            this.ButtonClearFields.Click += new System.EventHandler(this.ButtonClearFields_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(222, 279);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(172, 38);
            this.ButtonUpdate.TabIndex = 10;
            this.ButtonUpdate.Text = "Update Product";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonAddProduct.Location = new System.Drawing.Point(43, 279);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(172, 38);
            this.ButtonAddProduct.TabIndex = 9;
            this.ButtonAddProduct.Text = "Add Product";
            this.ButtonAddProduct.UseVisualStyleBackColor = false;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPrice.Location = new System.Drawing.Point(129, 211);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(278, 25);
            this.TextBoxPrice.TabIndex = 8;
            this.TextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unit Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDescription.Location = new System.Drawing.Point(129, 102);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(278, 64);
            this.TextBoxDescription.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description:";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCode.Enabled = false;
            this.TextBoxCode.Location = new System.Drawing.Point(130, 32);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(278, 25);
            this.TextBoxCode.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Code:";
            // 
            // DatagreedviewProducts
            // 
            this.DatagreedviewProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DatagreedviewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DatagreedviewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagreedviewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatagreedviewProducts.ColumnHeadersHeight = 28;
            this.DatagreedviewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DatagreedviewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ProductName,
            this.Code,
            this.Description,
            this.Category,
            this.Price});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagreedviewProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.DatagreedviewProducts.EnableHeadersVisualStyles = false;
            this.DatagreedviewProducts.GridColor = System.Drawing.SystemColors.Control;
            this.DatagreedviewProducts.Location = new System.Drawing.Point(28, 118);
            this.DatagreedviewProducts.Margin = new System.Windows.Forms.Padding(0);
            this.DatagreedviewProducts.MultiSelect = false;
            this.DatagreedviewProducts.Name = "DatagreedviewProducts";
            this.DatagreedviewProducts.ReadOnly = true;
            this.DatagreedviewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DatagreedviewProducts.RowHeadersVisible = false;
            this.DatagreedviewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagreedviewProducts.Size = new System.Drawing.Size(632, 510);
            this.DatagreedviewProducts.TabIndex = 4;
            this.DatagreedviewProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DatagreedviewProducts_DataBindingComplete);
            this.DatagreedviewProducts.SelectionChanged += new System.EventHandler(this.DatagreedviewProducts_SelectionChanged);
            // 
            // Number
            // 
            this.Number.DataPropertyName = "#";
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 20;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "product_name";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 120;
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
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 120;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 150;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // GroupboxSearch
            // 
            this.GroupboxSearch.Controls.Add(this.ButtonClearSearch);
            this.GroupboxSearch.Controls.Add(this.ButtonSearch);
            this.GroupboxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupboxSearch.Controls.Add(this.label1);
            this.GroupboxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupboxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupboxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.GroupboxSearch.Location = new System.Drawing.Point(28, 27);
            this.GroupboxSearch.Name = "GroupboxSearch";
            this.GroupboxSearch.Size = new System.Drawing.Size(1077, 67);
            this.GroupboxSearch.TabIndex = 3;
            this.GroupboxSearch.TabStop = false;
            this.GroupboxSearch.Text = "SEARCH PRODUCT";
            // 
            // ButtonClearSearch
            // 
            this.ButtonClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonClearSearch.Location = new System.Drawing.Point(635, 31);
            this.ButtonClearSearch.Name = "ButtonClearSearch";
            this.ButtonClearSearch.Size = new System.Drawing.Size(92, 27);
            this.ButtonClearSearch.TabIndex = 4;
            this.ButtonClearSearch.Text = "Clear search";
            this.ButtonClearSearch.UseVisualStyleBackColor = false;
            this.ButtonClearSearch.Click += new System.EventHandler(this.ButtonClearSearch_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Location = new System.Drawing.Point(551, 31);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(78, 27);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSearch.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxSearch.Location = new System.Drawing.Point(174, 31);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(371, 25);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.Text = "Type name or code here";
            this.TextBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            this.TextBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by name or Code";
            // 
            // UserControlProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DatagreedviewProducts);
            this.Controls.Add(this.GroupboxSearch);
            this.Name = "UserControlProducts";
            this.Size = new System.Drawing.Size(1132, 655);
            this.Load += new System.EventHandler(this.UserControlProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagreedviewProducts)).EndInit();
            this.GroupboxSearch.ResumeLayout(false);
            this.GroupboxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonDeleteProduct;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.Button ButtonClearFields;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DatagreedviewProducts;
        private System.Windows.Forms.GroupBox GroupboxSearch;
        private System.Windows.Forms.Button ButtonClearSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
    }
}
