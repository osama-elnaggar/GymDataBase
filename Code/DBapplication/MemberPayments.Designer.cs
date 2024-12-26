namespace DBapplication
{
    partial class MemberPayments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentNoCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.CardNuBox = new System.Windows.Forms.TextBox();
            this.CVVBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(33, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is All bills you have...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chose A Bill to Pay :";
            // 
            // PaymentNoCombobox
            // 
            this.PaymentNoCombobox.FormattingEnabled = true;
            this.PaymentNoCombobox.Location = new System.Drawing.Point(181, 42);
            this.PaymentNoCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PaymentNoCombobox.Name = "PaymentNoCombobox";
            this.PaymentNoCombobox.Size = new System.Drawing.Size(136, 28);
            this.PaymentNoCombobox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(493, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOTE: Recommended to pay at gym not online";
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(279, 98);
            this.PayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(227, 46);
            this.PayButton.TabIndex = 5;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // CardNuBox
            // 
            this.CardNuBox.Location = new System.Drawing.Point(369, 45);
            this.CardNuBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CardNuBox.MaxLength = 16;
            this.CardNuBox.Name = "CardNuBox";
            this.CardNuBox.Size = new System.Drawing.Size(152, 26);
            this.CardNuBox.TabIndex = 6;
            // 
            // CVVBox
            // 
            this.CVVBox.Location = new System.Drawing.Point(558, 45);
            this.CVVBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CVVBox.MaxLength = 3;
            this.CVVBox.Name = "CVVBox";
            this.CVVBox.PasswordChar = '$';
            this.CVVBox.Size = new System.Drawing.Size(112, 26);
            this.CVVBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Card Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "CVV";
            // 
            // MemberPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CVVBox);
            this.Controls.Add(this.CardNuBox);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaymentNoCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MemberPayments";
            this.Text = "MemberPayment";
            this.Load += new System.EventHandler(this.MemberPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PaymentNoCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox CardNuBox;
        private System.Windows.Forms.TextBox CVVBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}