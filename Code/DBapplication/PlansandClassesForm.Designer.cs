﻿namespace DBapplication
{
    partial class PlansandClassesForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddClass = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddPlan = new System.Windows.Forms.Button();
            this.ShowClasses = new System.Windows.Forms.Button();
            this.ShowPlans = new System.Windows.Forms.Button();
            this.DeleteClass = new System.Windows.Forms.Button();
            this.DeletePlan = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SearchPlan = new System.Windows.Forms.Button();
            this.SearchClass = new System.Windows.Forms.Button();
            this.DurationComboBox = new System.Windows.Forms.ComboBox();
            this.SearchClassBox = new System.Windows.Forms.TextBox();
            this.SearchPlanBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(11, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 22);
            this.textBox5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Schedule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // AddClass
            // 
            this.AddClass.Location = new System.Drawing.Point(290, 56);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(77, 89);
            this.AddClass.TabIndex = 12;
            this.AddClass.Text = "Add Class";
            this.AddClass.UseVisualStyleBackColor = true;
            this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(762, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(898, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(762, 149);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(909, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Goals";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(758, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Duration";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(758, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Price";
            // 
            // AddPlan
            // 
            this.AddPlan.Location = new System.Drawing.Point(885, 118);
            this.AddPlan.Name = "AddPlan";
            this.AddPlan.Size = new System.Drawing.Size(127, 53);
            this.AddPlan.TabIndex = 24;
            this.AddPlan.Text = "Add Plan";
            this.AddPlan.UseVisualStyleBackColor = true;
            this.AddPlan.Click += new System.EventHandler(this.AddPlan_Click);
            // 
            // ShowClasses
            // 
            this.ShowClasses.Location = new System.Drawing.Point(0, 338);
            this.ShowClasses.Name = "ShowClasses";
            this.ShowClasses.Size = new System.Drawing.Size(140, 23);
            this.ShowClasses.TabIndex = 25;
            this.ShowClasses.Text = "Show All Classes";
            this.ShowClasses.UseVisualStyleBackColor = true;
            this.ShowClasses.Click += new System.EventHandler(this.ShowClasses_Click);
            // 
            // ShowPlans
            // 
            this.ShowPlans.Location = new System.Drawing.Point(916, 334);
            this.ShowPlans.Name = "ShowPlans";
            this.ShowPlans.Size = new System.Drawing.Size(122, 23);
            this.ShowPlans.TabIndex = 26;
            this.ShowPlans.Text = "Show All Plans";
            this.ShowPlans.UseVisualStyleBackColor = true;
            this.ShowPlans.Click += new System.EventHandler(this.ShowPlans_Click);
            // 
            // DeleteClass
            // 
            this.DeleteClass.Location = new System.Drawing.Point(116, 264);
            this.DeleteClass.Name = "DeleteClass";
            this.DeleteClass.Size = new System.Drawing.Size(105, 23);
            this.DeleteClass.TabIndex = 27;
            this.DeleteClass.Text = "Delete Class";
            this.DeleteClass.UseVisualStyleBackColor = true;
            this.DeleteClass.Click += new System.EventHandler(this.DeleteClass_Click);
            // 
            // DeletePlan
            // 
            this.DeletePlan.Location = new System.Drawing.Point(368, 262);
            this.DeletePlan.Name = "DeletePlan";
            this.DeletePlan.Size = new System.Drawing.Size(105, 23);
            this.DeletePlan.TabIndex = 28;
            this.DeletePlan.Text = "Delete Plan";
            this.DeletePlan.UseVisualStyleBackColor = true;
            this.DeletePlan.Click += new System.EventHandler(this.DeletePlan_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(11, 265);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 29;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(263, 264);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Write ID to delete Class";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Write ID to Delete Plan";
            // 
            // SearchPlan
            // 
            this.SearchPlan.Location = new System.Drawing.Point(528, 332);
            this.SearchPlan.Name = "SearchPlan";
            this.SearchPlan.Size = new System.Drawing.Size(188, 32);
            this.SearchPlan.TabIndex = 34;
            this.SearchPlan.Text = "Search For Plan By Goals";
            this.SearchPlan.UseVisualStyleBackColor = true;
            this.SearchPlan.Click += new System.EventHandler(this.SearchPlan_Click);
            // 
            // SearchClass
            // 
            this.SearchClass.Location = new System.Drawing.Point(146, 337);
            this.SearchClass.Name = "SearchClass";
            this.SearchClass.Size = new System.Drawing.Size(217, 23);
            this.SearchClass.TabIndex = 33;
            this.SearchClass.Text = "Search For Class By Name";
            this.SearchClass.UseVisualStyleBackColor = true;
            this.SearchClass.Click += new System.EventHandler(this.SearchClass_Click);
            // 
            // DurationComboBox
            // 
            this.DurationComboBox.FormattingEnabled = true;
            this.DurationComboBox.Location = new System.Drawing.Point(15, 90);
            this.DurationComboBox.Name = "DurationComboBox";
            this.DurationComboBox.Size = new System.Drawing.Size(97, 24);
            this.DurationComboBox.TabIndex = 37;
            // 
            // SearchClassBox
            // 
            this.SearchClassBox.Location = new System.Drawing.Point(373, 338);
            this.SearchClassBox.Name = "SearchClassBox";
            this.SearchClassBox.Size = new System.Drawing.Size(100, 22);
            this.SearchClassBox.TabIndex = 38;
            // 
            // SearchPlanBox
            // 
            this.SearchPlanBox.Location = new System.Drawing.Point(723, 338);
            this.SearchPlanBox.Name = "SearchPlanBox";
            this.SearchPlanBox.Size = new System.Drawing.Size(100, 22);
            this.SearchPlanBox.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 44);
            this.button1.TabIndex = 40;
            this.button1.Text = "Show Classes I made";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(885, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 53);
            this.button2.TabIndex = 41;
            this.button2.Text = "Show Plans I made";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Search for There IDs to Get exact values to avoid deleting wrong Classes or Plans" +
    "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(761, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 24);
            this.comboBox1.TabIndex = 43;
            // 
            // PlansandClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 517);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchPlanBox);
            this.Controls.Add(this.SearchClassBox);
            this.Controls.Add(this.DurationComboBox);
            this.Controls.Add(this.SearchPlan);
            this.Controls.Add(this.SearchClass);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.DeletePlan);
            this.Controls.Add(this.DeleteClass);
            this.Controls.Add(this.ShowPlans);
            this.Controls.Add(this.ShowClasses);
            this.Controls.Add(this.AddPlan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "PlansandClassesForm";
            this.Text = "PlansandClassesForm";
            this.Load += new System.EventHandler(this.PlansandClassesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddPlan;
        private System.Windows.Forms.Button ShowClasses;
        private System.Windows.Forms.Button ShowPlans;
        private System.Windows.Forms.Button DeleteClass;
        private System.Windows.Forms.Button DeletePlan;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SearchPlan;
        private System.Windows.Forms.Button SearchClass;
        private System.Windows.Forms.ComboBox DurationComboBox;
        private System.Windows.Forms.TextBox SearchClassBox;
        private System.Windows.Forms.TextBox SearchPlanBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}