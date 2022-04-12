
namespace UI
{
    partial class FormPayment
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
            this.TextBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ButttonClose = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.TextBoxPayment = new System.Windows.Forms.TextBox();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxTotalPrice
            // 
            this.TextBoxTotalPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTotalPrice.Enabled = false;
            this.TextBoxTotalPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTotalPrice.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxTotalPrice.Location = new System.Drawing.Point(40, 51);
            this.TextBoxTotalPrice.Multiline = true;
            this.TextBoxTotalPrice.Name = "TextBoxTotalPrice";
            this.TextBoxTotalPrice.Size = new System.Drawing.Size(283, 43);
            this.TextBoxTotalPrice.TabIndex = 14;
            this.TextBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.PanelTop.Controls.Add(this.ButttonClose);
            this.PanelTop.Controls.Add(this.ButtonExit);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(368, 36);
            this.PanelTop.TabIndex = 15;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // ButttonClose
            // 
            this.ButttonClose.FlatAppearance.BorderSize = 0;
            this.ButttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButttonClose.ForeColor = System.Drawing.Color.White;
            this.ButttonClose.Location = new System.Drawing.Point(326, 3);
            this.ButttonClose.Name = "ButttonClose";
            this.ButttonClose.Size = new System.Drawing.Size(30, 30);
            this.ButttonClose.TabIndex = 3;
            this.ButttonClose.Text = "X";
            this.ButttonClose.UseVisualStyleBackColor = true;
            this.ButttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment";
            // 
            // textBoxChange
            // 
            this.textBoxChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChange.Enabled = false;
            this.textBoxChange.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChange.ForeColor = System.Drawing.Color.Silver;
            this.textBoxChange.Location = new System.Drawing.Point(40, 161);
            this.textBoxChange.Multiline = true;
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(283, 43);
            this.textBoxChange.TabIndex = 16;
            this.textBoxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxPayment
            // 
            this.TextBoxPayment.BackColor = System.Drawing.Color.White;
            this.TextBoxPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPayment.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPayment.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPayment.Location = new System.Drawing.Point(40, 106);
            this.TextBoxPayment.Multiline = true;
            this.TextBoxPayment.Name = "TextBoxPayment";
            this.TextBoxPayment.Size = new System.Drawing.Size(283, 43);
            this.TextBoxPayment.TabIndex = 17;
            this.TextBoxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPayment.TextChanged += new System.EventHandler(this.TextBoxPayment_TextChanged);
            this.TextBoxPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPayment_KeyPress);
            // 
            // ButtonApply
            // 
            this.ButtonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ButtonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApply.ForeColor = System.Drawing.Color.White;
            this.ButtonApply.Location = new System.Drawing.Point(40, 220);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(283, 41);
            this.ButtonApply.TabIndex = 18;
            this.ButtonApply.Text = "Apply";
            this.ButtonApply.UseVisualStyleBackColor = false;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(368, 277);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.TextBoxPayment);
            this.Controls.Add(this.textBoxChange);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.TextBoxTotalPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.VisibleChanged += new System.EventHandler(this.FormPayment_VisibleChanged);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxTotalPrice;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButttonClose;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.TextBox TextBoxPayment;
        private System.Windows.Forms.Button ButtonApply;
    }
}