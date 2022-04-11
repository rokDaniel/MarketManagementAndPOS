
namespace UI
{
    partial class FormDiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.TextBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.TextBoxDiscountPrecentage = new System.Windows.Forms.TextBox();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discount";
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.PanelTop.Controls.Add(this.ButtonExit);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(468, 36);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // ButtonExit
            // 
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(435, 3);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(30, 30);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount amount";
            // 
            // TextBoxDiscountAmount
            // 
            this.TextBoxDiscountAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDiscountAmount.Enabled = false;
            this.TextBoxDiscountAmount.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxDiscountAmount.Location = new System.Drawing.Point(173, 136);
            this.TextBoxDiscountAmount.Name = "TextBoxDiscountAmount";
            this.TextBoxDiscountAmount.Size = new System.Drawing.Size(283, 20);
            this.TextBoxDiscountAmount.TabIndex = 11;
            // 
            // TextBoxTotalPrice
            // 
            this.TextBoxTotalPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTotalPrice.Enabled = false;
            this.TextBoxTotalPrice.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxTotalPrice.Location = new System.Drawing.Point(173, 62);
            this.TextBoxTotalPrice.Name = "TextBoxTotalPrice";
            this.TextBoxTotalPrice.Size = new System.Drawing.Size(283, 20);
            this.TextBoxTotalPrice.TabIndex = 12;
            // 
            // TextBoxDiscountPrecentage
            // 
            this.TextBoxDiscountPrecentage.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxDiscountPrecentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDiscountPrecentage.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxDiscountPrecentage.Location = new System.Drawing.Point(173, 98);
            this.TextBoxDiscountPrecentage.Name = "TextBoxDiscountPrecentage";
            this.TextBoxDiscountPrecentage.Size = new System.Drawing.Size(209, 20);
            this.TextBoxDiscountPrecentage.TabIndex = 13;
            this.TextBoxDiscountPrecentage.Text = "Type discount amount in precentages here";
            this.TextBoxDiscountPrecentage.Enter += new System.EventHandler(this.TextBoxDiscountPrecentage_Enter);
            this.TextBoxDiscountPrecentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDiscountPrecentage_KeyPress);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(200)))), ((int)(((byte)(15)))));
            this.ButtonConfirm.FlatAppearance.BorderSize = 0;
            this.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonConfirm.Location = new System.Drawing.Point(173, 172);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(283, 28);
            this.ButtonConfirm.TabIndex = 14;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonApply
            // 
            this.ButtonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApply.ForeColor = System.Drawing.Color.White;
            this.ButtonApply.Location = new System.Drawing.Point(388, 92);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(68, 27);
            this.ButtonApply.TabIndex = 15;
            this.ButtonApply.Text = "Apply";
            this.ButtonApply.UseVisualStyleBackColor = false;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // FormDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(468, 222);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.TextBoxDiscountPrecentage);
            this.Controls.Add(this.TextBoxTotalPrice);
            this.Controls.Add(this.TextBoxDiscountAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDiscount";
            this.Load += new System.EventHandler(this.FormDiscount_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxDiscountAmount;
        private System.Windows.Forms.TextBox TextBoxTotalPrice;
        private System.Windows.Forms.TextBox TextBoxDiscountPrecentage;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Button ButtonApply;
    }
}