namespace DBapplication
{
    partial class User
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
            this.AddMember = new System.Windows.Forms.Button();
            this.ModifyUsers = new System.Windows.Forms.Button();
            this.DeleteMember = new System.Windows.Forms.Button();
            this.ManageClassesandplans = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SeeFeedBack = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddMember
            // 
            this.AddMember.Location = new System.Drawing.Point(253, 68);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(304, 41);
            this.AddMember.TabIndex = 2;
            this.AddMember.Text = "Add Gym Member";
            this.AddMember.UseVisualStyleBackColor = true;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // ModifyUsers
            // 
            this.ModifyUsers.Location = new System.Drawing.Point(253, 296);
            this.ModifyUsers.Name = "ModifyUsers";
            this.ModifyUsers.Size = new System.Drawing.Size(304, 44);
            this.ModifyUsers.TabIndex = 3;
            this.ModifyUsers.Text = "Add/Delete Users(Trainers, Admins, Workers)";
            this.ModifyUsers.UseVisualStyleBackColor = true;
            this.ModifyUsers.Click += new System.EventHandler(this.ModifyUsers_Click);
            // 
            // DeleteMember
            // 
            this.DeleteMember.Location = new System.Drawing.Point(253, 184);
            this.DeleteMember.Name = "DeleteMember";
            this.DeleteMember.Size = new System.Drawing.Size(304, 35);
            this.DeleteMember.TabIndex = 5;
            this.DeleteMember.Text = "Delete Gym Member";
            this.DeleteMember.UseVisualStyleBackColor = true;
            this.DeleteMember.Click += new System.EventHandler(this.DeleteMember_Click);
            // 
            // ManageClassesandplans
            // 
            this.ManageClassesandplans.Location = new System.Drawing.Point(253, 240);
            this.ManageClassesandplans.Name = "ManageClassesandplans";
            this.ManageClassesandplans.Size = new System.Drawing.Size(304, 41);
            this.ManageClassesandplans.TabIndex = 7;
            this.ManageClassesandplans.Text = "Manage Classes and Plans";
            this.ManageClassesandplans.UseVisualStyleBackColor = true;
            this.ManageClassesandplans.Click += new System.EventHandler(this.ManageClassesandplans_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Payments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeeFeedBack
            // 
            this.SeeFeedBack.Location = new System.Drawing.Point(591, 402);
            this.SeeFeedBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeFeedBack.Name = "SeeFeedBack";
            this.SeeFeedBack.Size = new System.Drawing.Size(198, 34);
            this.SeeFeedBack.TabIndex = 9;
            this.SeeFeedBack.Text = "See Feedback";
            this.SeeFeedBack.UseVisualStyleBackColor = true;
            this.SeeFeedBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(700, 390);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(7, 6);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Statistics";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SeeFeedBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ManageClassesandplans);
            this.Controls.Add(this.DeleteMember);
            this.Controls.Add(this.ModifyUsers);
            this.Controls.Add(this.AddMember);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.Button ModifyUsers;
        private System.Windows.Forms.Button DeleteMember;
        private System.Windows.Forms.Button ManageClassesandplans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SeeFeedBack;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}