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
            this.label2 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.adPass = new System.Windows.Forms.TextBox();
            this.adUserFullName = new System.Windows.Forms.TextBox();
            this.adUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            // 
            // saveConfig
            // 
            this.saveConfig.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveConfig.Location = new System.Drawing.Point(118, 94);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(75, 23);
            this.saveConfig.TabIndex = 6;
            this.saveConfig.Text = "Spara";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // adPass
            // 
            this.adPass.Location = new System.Drawing.Point(118, 64);
            this.adPass.Name = "adPass";
            this.adPass.PasswordChar = '*';
            this.adPass.Size = new System.Drawing.Size(225, 20);
            this.adPass.TabIndex = 19;
            // 
            // adUserFullName
            // 
            this.adUserFullName.Location = new System.Drawing.Point(118, 38);
            this.adUserFullName.Name = "adUserFullName";
            this.adUserFullName.Size = new System.Drawing.Size(225, 20);
            this.adUserFullName.TabIndex = 18;
            // 
            // adUserName
            // 
            this.adUserName.Location = new System.Drawing.Point(118, 12);
            this.adUserName.Name = "adUserName";
            this.adUserName.Size = new System.Drawing.Size(225, 20);
            this.adUserName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lösenord:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fullständiga namn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Användarnamn:";
            // 
            // Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 124);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adUserName);
            this.Controls.Add(this.adUserFullName);
            this.Controls.Add(this.adPass);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.label2);
            this.Name = "Install";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administratör";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adUserName;
        private System.Windows.Forms.TextBox adUserFullName;
        private System.Windows.Forms.TextBox adPass;
    }
}