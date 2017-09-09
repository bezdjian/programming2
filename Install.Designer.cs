namespace TRF
{
    partial class Install
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adPass = new System.Windows.Forms.TextBox();
            this.adUserFullName = new System.Windows.Forms.TextBox();
            this.adUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dbHost = new System.Windows.Forms.TextBox();
            this.dbName = new System.Windows.Forms.TextBox();
            this.dbPass = new System.Windows.Forms.TextBox();
            this.dbUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Användarnamn:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lösenord:";
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(168, 283);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(75, 23);
            this.saveConfig.TabIndex = 6;
            this.saveConfig.Text = "Spara";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Databas namn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adPass);
            this.groupBox1.Controls.Add(this.adUserFullName);
            this.groupBox1.Controls.Add(this.adUserName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 112);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // adPass
            // 
            this.adPass.Location = new System.Drawing.Point(110, 76);
            this.adPass.Name = "adPass";
            this.adPass.PasswordChar = '*';
            this.adPass.Size = new System.Drawing.Size(225, 20);
            this.adPass.TabIndex = 19;
            // 
            // adUserFullName
            // 
            this.adUserFullName.Location = new System.Drawing.Point(110, 50);
            this.adUserFullName.Name = "adUserFullName";
            this.adUserFullName.Size = new System.Drawing.Size(225, 20);
            this.adUserFullName.TabIndex = 18;
            this.adUserFullName.Text = "Admin User";
            // 
            // adUserName
            // 
            this.adUserName.Location = new System.Drawing.Point(110, 24);
            this.adUserName.Name = "adUserName";
            this.adUserName.Size = new System.Drawing.Size(225, 20);
            this.adUserName.TabIndex = 17;
            this.adUserName.Text = "admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lösenord:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fullständiga namn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Användarnamn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dbHost);
            this.groupBox2.Controls.Add(this.dbName);
            this.groupBox2.Controls.Add(this.dbPass);
            this.groupBox2.Controls.Add(this.dbUser);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Databas information";
            // 
            // dbHost
            // 
            this.dbHost.Location = new System.Drawing.Point(110, 113);
            this.dbHost.Name = "dbHost";
            this.dbHost.Size = new System.Drawing.Size(225, 20);
            this.dbHost.TabIndex = 16;
            this.dbHost.Text = "127.0.0.1";
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(110, 87);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(225, 20);
            this.dbName.TabIndex = 15;
            this.dbName.Text = "trf";
            // 
            // dbPass
            // 
            this.dbPass.Location = new System.Drawing.Point(110, 61);
            this.dbPass.Name = "dbPass";
            this.dbPass.PasswordChar = '*';
            this.dbPass.Size = new System.Drawing.Size(225, 20);
            this.dbPass.TabIndex = 14;
            this.dbPass.Text = "root";
            // 
            // dbUser
            // 
            this.dbUser.Location = new System.Drawing.Point(110, 35);
            this.dbUser.Name = "dbUser";
            this.dbUser.Size = new System.Drawing.Size(225, 20);
            this.dbUser.TabIndex = 13;
            this.dbUser.Text = "root";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Host:";
            // 
            // Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 318);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.label2);
            this.Name = "Install";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Databaskonfiguration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dbUser;
        private System.Windows.Forms.TextBox dbPass;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.TextBox dbHost;
        private System.Windows.Forms.TextBox adUserName;
        private System.Windows.Forms.TextBox adUserFullName;
        private System.Windows.Forms.TextBox adPass;
    }
}