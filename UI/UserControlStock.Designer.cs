
namespace UI
{
    partial class UserControlStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatagreedviewStock = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupboxSearch = new System.Windows.Forms.GroupBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextBoxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonClearSearch = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGreedViewOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatagreedviewStock)).BeginInit();
            this.GroupboxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGreedViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagreedviewStock
            // 
            this.DatagreedviewStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DatagreedviewStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DatagreedviewStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagreedviewStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagreedviewStock.ColumnHeadersHeight = 28;
            this.DatagreedviewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DatagreedviewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ProductName,
            this.Code,
            this.Description,
            this.Quantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagreedviewStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatagreedviewStock.EnableHeadersVisualStyles = false;
            this.DatagreedviewStock.GridColor = System.Drawing.SystemColors.Control;
            this.DatagreedviewStock.Location = new System.Drawing.Point(28, 149);
            this.DatagreedviewStock.Margin = new System.Windows.Forms.Padding(0);
            this.DatagreedviewStock.MultiSelect = false;
            this.DatagreedviewStock.Name = "DatagreedviewStock";
            this.DatagreedviewStock.ReadOnly = true;
            this.DatagreedviewStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DatagreedviewStock.RowHeadersVisible = false;
            this.DatagreedviewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagreedviewStock.Size = new System.Drawing.Size(502, 479);
            this.DatagreedviewStock.TabIndex = 7;
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
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // GroupboxSearch
            // 
            this.GroupboxSearch.Controls.Add(this.TextBoxName);
            this.GroupboxSearch.Controls.Add(this.label3);
            this.GroupboxSearch.Controls.Add(this.TextBoxCode);
            this.GroupboxSearch.Controls.Add(this.label4);
            this.GroupboxSearch.Controls.Add(this.ButtonCancel);
            this.GroupboxSearch.Controls.Add(this.ButtonAdd);
            this.GroupboxSearch.Controls.Add(this.TextBoxQuantity);
            this.GroupboxSearch.Controls.Add(this.label2);
            this.GroupboxSearch.Controls.Add(this.ButtonClearSearch);
            this.GroupboxSearch.Controls.Add(this.ButtonSearch);
            this.GroupboxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupboxSearch.Controls.Add(this.label1);
            this.GroupboxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupboxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupboxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.GroupboxSearch.Location = new System.Drawing.Point(28, 27);
            this.GroupboxSearch.Name = "GroupboxSearch";
            this.GroupboxSearch.Size = new System.Drawing.Size(1077, 109);
            this.GroupboxSearch.TabIndex = 6;
            this.GroupboxSearch.TabStop = false;
            this.GroupboxSearch.Text = "SEARCH PRODUCT";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Enabled = false;
            this.TextBoxName.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxName.Location = new System.Drawing.Point(798, 66);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(248, 25);
            this.TextBoxName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(697, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product Name:";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCode.Enabled = false;
            this.TextBoxCode.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxCode.Location = new System.Drawing.Point(798, 33);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(56, 25);
            this.TextBoxCode.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(697, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Code: ";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(523, 63);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(92, 27);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(439, 63);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(78, 27);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxQuantity.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxQuantity.Location = new System.Drawing.Point(174, 64);
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(248, 25);
            this.TextBoxQuantity.TabIndex = 6;
            this.TextBoxQuantity.Text = "Type the quantity you want to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Quantity:";
            // 
            // ButtonClearSearch
            // 
            this.ButtonClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonClearSearch.Location = new System.Drawing.Point(523, 30);
            this.ButtonClearSearch.Name = "ButtonClearSearch";
            this.ButtonClearSearch.Size = new System.Drawing.Size(92, 27);
            this.ButtonClearSearch.TabIndex = 4;
            this.ButtonClearSearch.Text = "Clear search";
            this.ButtonClearSearch.UseVisualStyleBackColor = false;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Location = new System.Drawing.Point(439, 30);
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
            this.TextBoxSearch.Size = new System.Drawing.Size(248, 25);
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
            // DataGreedViewOrder
            // 
            this.DataGreedViewOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGreedViewOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGreedViewOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGreedViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGreedViewOrder.ColumnHeadersHeight = 28;
            this.DataGreedViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGreedViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGreedViewOrder.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGreedViewOrder.EnableHeadersVisualStyles = false;
            this.DataGreedViewOrder.GridColor = System.Drawing.SystemColors.Control;
            this.DataGreedViewOrder.Location = new System.Drawing.Point(603, 149);
            this.DataGreedViewOrder.Margin = new System.Windows.Forms.Padding(0);
            this.DataGreedViewOrder.MultiSelect = false;
            this.DataGreedViewOrder.Name = "DataGreedViewOrder";
            this.DataGreedViewOrder.ReadOnly = true;
            this.DataGreedViewOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGreedViewOrder.RowHeadersVisible = false;
            this.DataGreedViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGreedViewOrder.Size = new System.Drawing.Size(502, 449);
            this.DataGreedViewOrder.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "#";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn3.HeaderText = "Code";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 110;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(930, 601);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(175, 37);
            this.ButtonSave.TabIndex = 13;
            this.ButtonSave.Text = "Commit Stock Order";
            this.ButtonSave.UseVisualStyleBackColor = false;
            // 
            // UserControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.DataGreedViewOrder);
            this.Controls.Add(this.DatagreedviewStock);
            this.Controls.Add(this.GroupboxSearch);
            this.Name = "UserControlStock";
            this.Size = new System.Drawing.Size(1132, 655);
            this.Load += new System.EventHandler(this.UserControlStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagreedviewStock)).EndInit();
            this.GroupboxSearch.ResumeLayout(false);
            this.GroupboxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGreedViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DatagreedviewStock;
        private System.Windows.Forms.GroupBox GroupboxSearch;
        private System.Windows.Forms.Button ButtonClearSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextBoxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGreedViewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button ButtonSave;
    }
}
