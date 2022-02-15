
namespace UI
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonPos = new System.Windows.Forms.Button();
            this.ButtonReports = new System.Windows.Forms.Button();
            this.ButtonManageStock = new System.Windows.Forms.Button();
            this.ButtonManageProducts = new System.Windows.Forms.Button();
            this.ButtonHomePage = new System.Windows.Forms.Button();
            this.ButtonManageStaff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NavIndicator = new System.Windows.Forms.Panel();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.userControlHome1 = new UI.UserControlHome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.ButtonLogout);
            this.panel1.Controls.Add(this.ButtonPos);
            this.panel1.Controls.Add(this.ButtonReports);
            this.panel1.Controls.Add(this.ButtonManageStock);
            this.panel1.Controls.Add(this.ButtonManageProducts);
            this.panel1.Controls.Add(this.ButtonHomePage);
            this.panel1.Controls.Add(this.ButtonManageStaff);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 702);
            this.panel1.TabIndex = 1;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.FlatAppearance.BorderSize = 0;
            this.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogout.ForeColor = System.Drawing.Color.White;
            this.ButtonLogout.Image = global::UI.Properties.Resources.IconLogOut2;
            this.ButtonLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonLogout.Location = new System.Drawing.Point(10, 656);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(205, 42);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonPos
            // 
            this.ButtonPos.FlatAppearance.BorderSize = 0;
            this.ButtonPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPos.ForeColor = System.Drawing.Color.White;
            this.ButtonPos.Image = global::UI.Properties.Resources.IconPOS2;
            this.ButtonPos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonPos.Location = new System.Drawing.Point(10, 334);
            this.ButtonPos.Name = "ButtonPos";
            this.ButtonPos.Size = new System.Drawing.Size(205, 42);
            this.ButtonPos.TabIndex = 5;
            this.ButtonPos.Text = "POS";
            this.ButtonPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonPos.UseVisualStyleBackColor = true;
            this.ButtonPos.Click += new System.EventHandler(this.ButtonPos_Click);
            this.ButtonPos.Leave += new System.EventHandler(this.ButtonPos_Leave);
            // 
            // ButtonReports
            // 
            this.ButtonReports.FlatAppearance.BorderSize = 0;
            this.ButtonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReports.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReports.ForeColor = System.Drawing.Color.White;
            this.ButtonReports.Image = global::UI.Properties.Resources.IconReports2;
            this.ButtonReports.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonReports.Location = new System.Drawing.Point(10, 286);
            this.ButtonReports.Name = "ButtonReports";
            this.ButtonReports.Size = new System.Drawing.Size(205, 42);
            this.ButtonReports.TabIndex = 4;
            this.ButtonReports.Text = "Reports";
            this.ButtonReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonReports.UseVisualStyleBackColor = true;
            this.ButtonReports.Click += new System.EventHandler(this.ButtonReports_Click);
            this.ButtonReports.Leave += new System.EventHandler(this.ButtonReports_Leave);
            // 
            // ButtonManageStock
            // 
            this.ButtonManageStock.FlatAppearance.BorderSize = 0;
            this.ButtonManageStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonManageStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManageStock.ForeColor = System.Drawing.Color.White;
            this.ButtonManageStock.Image = global::UI.Properties.Resources.IconManageStock2;
            this.ButtonManageStock.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonManageStock.Location = new System.Drawing.Point(10, 238);
            this.ButtonManageStock.Name = "ButtonManageStock";
            this.ButtonManageStock.Size = new System.Drawing.Size(205, 42);
            this.ButtonManageStock.TabIndex = 3;
            this.ButtonManageStock.Text = "Manage stock";
            this.ButtonManageStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonManageStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonManageStock.UseVisualStyleBackColor = true;
            this.ButtonManageStock.Click += new System.EventHandler(this.ButtonManageStock_Click);
            this.ButtonManageStock.Leave += new System.EventHandler(this.ButtonManageStock_Leave);
            // 
            // ButtonManageProducts
            // 
            this.ButtonManageProducts.FlatAppearance.BorderSize = 0;
            this.ButtonManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonManageProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManageProducts.ForeColor = System.Drawing.Color.White;
            this.ButtonManageProducts.Image = global::UI.Properties.Resources.IconManageProducts2;
            this.ButtonManageProducts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonManageProducts.Location = new System.Drawing.Point(10, 190);
            this.ButtonManageProducts.Name = "ButtonManageProducts";
            this.ButtonManageProducts.Size = new System.Drawing.Size(205, 42);
            this.ButtonManageProducts.TabIndex = 2;
            this.ButtonManageProducts.Text = "Manage products";
            this.ButtonManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonManageProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonManageProducts.UseVisualStyleBackColor = true;
            this.ButtonManageProducts.Click += new System.EventHandler(this.ButtonManageProducts_Click);
            this.ButtonManageProducts.Leave += new System.EventHandler(this.ButtonManageProducts_Leave);
            // 
            // ButtonHomePage
            // 
            this.ButtonHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ButtonHomePage.FlatAppearance.BorderSize = 0;
            this.ButtonHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHomePage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHomePage.ForeColor = System.Drawing.Color.White;
            this.ButtonHomePage.Image = global::UI.Properties.Resources.IconHome2;
            this.ButtonHomePage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonHomePage.Location = new System.Drawing.Point(10, 94);
            this.ButtonHomePage.Name = "ButtonHomePage";
            this.ButtonHomePage.Size = new System.Drawing.Size(205, 42);
            this.ButtonHomePage.TabIndex = 0;
            this.ButtonHomePage.Text = "Home";
            this.ButtonHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonHomePage.UseVisualStyleBackColor = false;
            this.ButtonHomePage.Click += new System.EventHandler(this.ButtonHomePage_Click);
            this.ButtonHomePage.Leave += new System.EventHandler(this.ButtonHomePage_Leave);
            // 
            // ButtonManageStaff
            // 
            this.ButtonManageStaff.FlatAppearance.BorderSize = 0;
            this.ButtonManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonManageStaff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManageStaff.ForeColor = System.Drawing.Color.White;
            this.ButtonManageStaff.Image = global::UI.Properties.Resources.IconManageStaff3;
            this.ButtonManageStaff.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonManageStaff.Location = new System.Drawing.Point(10, 142);
            this.ButtonManageStaff.Name = "ButtonManageStaff";
            this.ButtonManageStaff.Size = new System.Drawing.Size(205, 42);
            this.ButtonManageStaff.TabIndex = 1;
            this.ButtonManageStaff.Text = "Manage staff";
            this.ButtonManageStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonManageStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonManageStaff.UseVisualStyleBackColor = true;
            this.ButtonManageStaff.Click += new System.EventHandler(this.ButtonManageStaff_Click);
            this.ButtonManageStaff.Leave += new System.EventHandler(this.ButtonManageStaff_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.LabelDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 47);
            this.panel2.TabIndex = 3;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.White;
            this.LabelDate.Location = new System.Drawing.Point(1119, 16);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(0, 21);
            this.LabelDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // NavIndicator
            // 
            this.NavIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.NavIndicator.Location = new System.Drawing.Point(10, 94);
            this.NavIndicator.Name = "NavIndicator";
            this.NavIndicator.Size = new System.Drawing.Size(3, 42);
            this.NavIndicator.TabIndex = 2;
            // 
            // TimerClock
            // 
            this.TimerClock.Enabled = true;
            this.TimerClock.Interval = 1000;
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // userControlHome1
            // 
            this.userControlHome1.Location = new System.Drawing.Point(214, 47);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(1132, 655);
            this.userControlHome1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 702);
            this.Controls.Add(this.userControlHome1);
            this.Controls.Add(this.NavIndicator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonManageStaff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonManageStock;
        private System.Windows.Forms.Button ButtonManageProducts;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonPos;
        private System.Windows.Forms.Button ButtonReports;
        private System.Windows.Forms.Button ButtonHomePage;
        private System.Windows.Forms.Panel NavIndicator;
        private UserControlHome userControlHome1;
        private System.Windows.Forms.Timer TimerClock;
    }
}