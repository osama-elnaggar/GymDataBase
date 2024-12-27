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
            this.SuspendLayout();
            // 
            // AddMember
            // 
            this.AddMember.Location = new System.Drawing.Point(285, 85);
            this.AddMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(342, 51);
            this.AddMember.TabIndex = 2;
            this.AddMember.Text = "Add Gym Member";
            this.AddMember.UseVisualStyleBackColor = true;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // ModifyUsers
            // 
            this.ModifyUsers.Location = new System.Drawing.Point(285, 394);
            this.ModifyUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModifyUsers.Name = "ModifyUsers";
            this.ModifyUsers.Size = new System.Drawing.Size(342, 55);
            this.ModifyUsers.TabIndex = 3;
            this.ModifyUsers.Text = "Add/Delete Users(Trainers, Admins, Workers)";
            this.ModifyUsers.UseVisualStyleBackColor = true;
            // 
            // DeleteMember
            // 
            this.DeleteMember.Location = new System.Drawing.Point(285, 230);
            this.DeleteMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteMember.Name = "DeleteMember";
            this.DeleteMember.Size = new System.Drawing.Size(342, 44);
            this.DeleteMember.TabIndex = 5;
            this.DeleteMember.Text = "Delete Gym Member";
            this.DeleteMember.UseVisualStyleBackColor = true;
            this.DeleteMember.Click += new System.EventHandler(this.DeleteMember_Click);
            // 
            // ManageClassesandplans
            // 
            this.ManageClassesandplans.Location = new System.Drawing.Point(285, 300);
            this.ManageClassesandplans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageClassesandplans.Name = "ManageClassesandplans";
            this.ManageClassesandplans.Size = new System.Drawing.Size(342, 51);
            this.ManageClassesandplans.TabIndex = 7;
            this.ManageClassesandplans.Text = "Manage Classes and Plans";
            this.ManageClassesandplans.UseVisualStyleBackColor = true;
            this.ManageClassesandplans.Click += new System.EventHandler(this.ManageClassesandplans_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Payments";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SeeFeedBack
            // 
            this.SeeFeedBack.Location = new System.Drawing.Point(665, 502);
            this.SeeFeedBack.Name = "SeeFeedBack";
            this.SeeFeedBack.Size = new System.Drawing.Size(223, 42);
            this.SeeFeedBack.TabIndex = 9;
            this.SeeFeedBack.Text = "See Feedback";
            this.SeeFeedBack.UseVisualStyleBackColor = true;
            this.SeeFeedBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(788, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 553);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SeeFeedBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ManageClassesandplans);
            this.Controls.Add(this.DeleteMember);
            this.Controls.Add(this.ModifyUsers);
            this.Controls.Add(this.AddMember);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}