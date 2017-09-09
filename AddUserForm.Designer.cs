namespace TRF
{
    partial class AddUserForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tigerWiki = new System.Windows.Forms.LinkLabel();
            this.btnAddEditUser = new System.Windows.Forms.Button();
            this.addTigerName = new System.Windows.Forms.TextBox();
            this.addAddress = new System.Windows.Forms.TextBox();
            this.addLastName = new System.Windows.Forms.TextBox();
            this.addName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tigerWiki);
            this.groupBox1.Controls.Add(this.btnAddEditUser);
            this.groupBox1.Controls.Add(this.addTigerName);
            this.groupBox1.Controls.Add(this.addAddress);
            this.groupBox1.Controls.Add(this.addLastName);
            this.groupBox1.Controls.Add(this.addName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ny medlem";
            // 
            // tigerWiki
            // 
            this.tigerWiki.AutoSize = true;
            this.tigerWiki.Location = new System.Drawing.Point(67, 144);
            this.tigerWiki.Name = "tigerWiki";
            this.tigerWiki.Size = new System.Drawing.Size(55, 13);
            this.tigerWiki.TabIndex = 9;
            this.tigerWiki.TabStop = true;
            this.tigerWiki.Text = "Tiger Wiki";
            this.tigerWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tigerWiki_LinkClicked);
            // 
            // btnAddEditUser
            // 
            this.btnAddEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditUser.Location = new System.Drawing.Point(70, 174);
            this.btnAddEditUser.Name = "btnAddEditUser";
            this.btnAddEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditUser.TabIndex = 8;
            this.btnAddEditUser.Text = "Spara";
            this.btnAddEditUser.UseVisualStyleBackColor = true;
            this.btnAddEditUser.Click += new System.EventHandler(this.btnAddEditUser_Click);
            // 
            // addTigerName
            // 
            this.addTigerName.Location = new System.Drawing.Point(70, 118);
            this.addTigerName.Name = "addTigerName";
            this.addTigerName.Size = new System.Drawing.Size(218, 20);
            this.addTigerName.TabIndex = 7;
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(70, 88);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(218, 20);
            this.addAddress.TabIndex = 6;
            // 
            // addLastName
            // 
            this.addLastName.Location = new System.Drawing.Point(70, 58);
            this.addLastName.Name = "addLastName";
            this.addLastName.Size = new System.Drawing.Size(218, 20);
            this.addLastName.TabIndex = 5;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(70, 28);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(218, 20);
            this.addName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiger namn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn:";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 232);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lägg till medlem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addTigerName;
        private System.Windows.Forms.TextBox addAddress;
        private System.Windows.Forms.TextBox addLastName;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.Button btnAddEditUser;
        private System.Windows.Forms.LinkLabel tigerWiki;
    }
}