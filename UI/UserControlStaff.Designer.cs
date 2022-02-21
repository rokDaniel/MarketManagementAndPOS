
namespace UI
{
    partial class UserControlStaff
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
            this.GroupboxSearch = new System.Windows.Forms.GroupBox();
            this.ButtonClearSearch = new System.Windows.Forms.Button();
            this.ComboBoxRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatagreedviewEmployees = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDeleteEmployee = new System.Windows.Forms.Button();
            this.comboBoxEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.ComboBoxEmployeeRole = new System.Windows.Forms.ComboBox();
            this.ButtonClearFields = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonAddEmployee = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxRetypePass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupboxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagreedviewEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupboxSearch
            // 
            this.GroupboxSearch.Controls.Add(this.ButtonClearSearch);
            this.GroupboxSearch.Controls.Add(this.ComboBoxRole);
            this.GroupboxSearch.Controls.Add(this.label2);
            this.GroupboxSearch.Controls.Add(this.ButtonSearch);
            this.GroupboxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupboxSearch.Controls.Add(this.label1);
            this.GroupboxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupboxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupboxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.GroupboxSearch.Location = new System.Drawing.Point(32, 26);
            this.GroupboxSearch.Name = "GroupboxSearch";
            this.GroupboxSearch.Size = new System.Drawing.Size(1077, 67);
            this.GroupboxSearch.TabIndex = 0;
            this.GroupboxSearch.TabStop = false;
            this.GroupboxSearch.Text = "SEARCH EMPLOYEE";
            // 
            // ButtonClearSearch
            // 
            this.ButtonClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonClearSearch.Location = new System.Drawing.Point(583, 30);
            this.ButtonClearSearch.Name = "ButtonClearSearch";
            this.ButtonClearSearch.Size = new System.Drawing.Size(92, 27);
            this.ButtonClearSearch.TabIndex = 4;
            this.ButtonClearSearch.Text = "Clear search";
            this.ButtonClearSearch.UseVisualStyleBackColor = false;
            this.ButtonClearSearch.Click += new System.EventHandler(this.ButtonClearSearch_Click);
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.Items.AddRange(new object[] {
            "All",
            "Administrator",
            "Cashier",
            "Warehouse clerk"});
            this.ComboBoxRole.Location = new System.Drawing.Point(823, 30);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Size = new System.Drawing.Size(212, 25);
            this.ComboBoxRole.TabIndex = 3;
            this.ComboBoxRole.Text = "All";
            this.ComboBoxRole.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(723, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by role";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Location = new System.Drawing.Point(499, 30);
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
            this.TextBoxSearch.Location = new System.Drawing.Point(122, 30);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(371, 25);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.Text = "Type name here";
            this.TextBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            this.TextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            this.TextBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by name";
            // 
            // DatagreedviewEmployees
            // 
            this.DatagreedviewEmployees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DatagreedviewEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DatagreedviewEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagreedviewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatagreedviewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagreedviewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.FullName,
            this.Adress,
            this.ContactNumber,
            this.Role,
            this.Username,
            this.Status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagreedviewEmployees.DefaultCellStyle = dataGridViewCellStyle4;
            this.DatagreedviewEmployees.EnableHeadersVisualStyles = false;
            this.DatagreedviewEmployees.GridColor = System.Drawing.SystemColors.Control;
            this.DatagreedviewEmployees.Location = new System.Drawing.Point(32, 117);
            this.DatagreedviewEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.DatagreedviewEmployees.MultiSelect = false;
            this.DatagreedviewEmployees.Name = "DatagreedviewEmployees";
            this.DatagreedviewEmployees.ReadOnly = true;
            this.DatagreedviewEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DatagreedviewEmployees.RowHeadersVisible = false;
            this.DatagreedviewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagreedviewEmployees.Size = new System.Drawing.Size(642, 510);
            this.DatagreedviewEmployees.TabIndex = 1;
            this.DatagreedviewEmployees.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DatagreedviewEmployees_DataBindingComplete);
            this.DatagreedviewEmployees.SelectionChanged += new System.EventHandler(this.DatagreedviewEmployees_SelectionChanged);
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "id";
            this.StaffID.HeaderText = "Staff ID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.Width = 50;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "full_name";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 110;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 110;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "address";
            this.Adress.HeaderText = "Address";
            this.Adress.MinimumWidth = 120;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 120;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "contact_number";
            this.ContactNumber.HeaderText = "Contact No.";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonDeleteEmployee);
            this.groupBox1.Controls.Add(this.comboBoxEmployeeStatus);
            this.groupBox1.Controls.Add(this.ComboBoxEmployeeRole);
            this.groupBox1.Controls.Add(this.ButtonClearFields);
            this.groupBox1.Controls.Add(this.ButtonUpdate);
            this.groupBox1.Controls.Add(this.ButtonAddEmployee);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TextBoxRetypePass);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TextBoxPassword);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TextBoxUsername);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TextBoxNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TextBoxAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBoxFullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(682, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 510);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMPLOYEE INFORMATION";
            // 
            // ButtonDeleteEmployee
            // 
            this.ButtonDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteEmployee.Location = new System.Drawing.Point(249, 460);
            this.ButtonDeleteEmployee.Name = "ButtonDeleteEmployee";
            this.ButtonDeleteEmployee.Size = new System.Drawing.Size(172, 38);
            this.ButtonDeleteEmployee.TabIndex = 13;
            this.ButtonDeleteEmployee.Text = "Delete Employee";
            this.ButtonDeleteEmployee.UseVisualStyleBackColor = false;
            this.ButtonDeleteEmployee.Click += new System.EventHandler(this.ButtonDeleteEmployee_Click);
            // 
            // comboBoxEmployeeStatus
            // 
            this.comboBoxEmployeeStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxEmployeeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmployeeStatus.FormattingEnabled = true;
            this.comboBoxEmployeeStatus.Items.AddRange(new object[] {
            "Active",
            "Vacation",
            "Sick"});
            this.comboBoxEmployeeStatus.Location = new System.Drawing.Point(131, 287);
            this.comboBoxEmployeeStatus.Name = "comboBoxEmployeeStatus";
            this.comboBoxEmployeeStatus.Size = new System.Drawing.Size(277, 25);
            this.comboBoxEmployeeStatus.TabIndex = 12;
            // 
            // ComboBoxEmployeeRole
            // 
            this.ComboBoxEmployeeRole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBoxEmployeeRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxEmployeeRole.FormattingEnabled = true;
            this.ComboBoxEmployeeRole.Items.AddRange(new object[] {
            "Administrator",
            "Cashier",
            "Warehouse clerk"});
            this.ComboBoxEmployeeRole.Location = new System.Drawing.Point(131, 256);
            this.ComboBoxEmployeeRole.Name = "ComboBoxEmployeeRole";
            this.ComboBoxEmployeeRole.Size = new System.Drawing.Size(277, 25);
            this.ComboBoxEmployeeRole.TabIndex = 4;
            // 
            // ButtonClearFields
            // 
            this.ButtonClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearFields.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearFields.ForeColor = System.Drawing.Color.White;
            this.ButtonClearFields.Location = new System.Drawing.Point(70, 460);
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
            this.ButtonUpdate.Location = new System.Drawing.Point(249, 416);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(172, 38);
            this.ButtonUpdate.TabIndex = 10;
            this.ButtonUpdate.Text = "Update Employee";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonAddEmployee
            // 
            this.ButtonAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddEmployee.ForeColor = System.Drawing.Color.White;
            this.ButtonAddEmployee.Location = new System.Drawing.Point(70, 416);
            this.ButtonAddEmployee.Name = "ButtonAddEmployee";
            this.ButtonAddEmployee.Size = new System.Drawing.Size(172, 38);
            this.ButtonAddEmployee.TabIndex = 9;
            this.ButtonAddEmployee.Text = "Add Employee";
            this.ButtonAddEmployee.UseVisualStyleBackColor = false;
            this.ButtonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Role:";
            // 
            // TextBoxRetypePass
            // 
            this.TextBoxRetypePass.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxRetypePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRetypePass.Location = new System.Drawing.Point(130, 222);
            this.TextBoxRetypePass.Name = "TextBoxRetypePass";
            this.TextBoxRetypePass.PasswordChar = '*';
            this.TextBoxRetypePass.Size = new System.Drawing.Size(278, 25);
            this.TextBoxRetypePass.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Re-Type Password:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPassword.Location = new System.Drawing.Point(130, 192);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(278, 25);
            this.TextBoxPassword.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password:";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxUsername.Location = new System.Drawing.Point(130, 160);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(278, 25);
            this.TextBoxUsername.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username:";
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxNumber.Location = new System.Drawing.Point(130, 129);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(278, 25);
            this.TextBoxNumber.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contact Number:";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAddress.Location = new System.Drawing.Point(130, 98);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(278, 25);
            this.TextBoxAddress.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adress:";
            // 
            // TextBoxFullName
            // 
            this.TextBoxFullName.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFullName.Location = new System.Drawing.Point(130, 67);
            this.TextBoxFullName.Name = "TextBoxFullName";
            this.TextBoxFullName.Size = new System.Drawing.Size(278, 25);
            this.TextBoxFullName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Full Name:";
            // 
            // TextBoxID
            // 
            this.TextBoxID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxID.Enabled = false;
            this.TextBoxID.Location = new System.Drawing.Point(130, 32);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(278, 25);
            this.TextBoxID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Staff ID:";
            // 
            // UserControlStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DatagreedviewEmployees);
            this.Controls.Add(this.GroupboxSearch);
            this.Name = "UserControlStaff";
            this.Size = new System.Drawing.Size(1132, 655);
            this.Load += new System.EventHandler(this.UserControlStaff_Load);
            this.GroupboxSearch.ResumeLayout(false);
            this.GroupboxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagreedviewEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupboxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxRole;
        private System.Windows.Forms.DataGridView DatagreedviewEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxRetypePass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.ComboBox comboBoxEmployeeStatus;
        private System.Windows.Forms.ComboBox ComboBoxEmployeeRole;
        private System.Windows.Forms.Button ButtonClearFields;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonAddEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ButtonClearSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button ButtonDeleteEmployee;
    }
}
