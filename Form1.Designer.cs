namespace interaction
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.lblShowPasswd = new System.Windows.Forms.TextBox();
            this.btnShowMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(47, 13);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.PasswordChar = '*';
            this.tbPasswd.Size = new System.Drawing.Size(294, 20);
            this.tbPasswd.TabIndex = 1;
            // 
            // lblShowPasswd
            // 
            this.lblShowPasswd.Enabled = false;
            this.lblShowPasswd.Location = new System.Drawing.Point(47, 54);
            this.lblShowPasswd.Name = "lblShowPasswd";
            this.lblShowPasswd.Size = new System.Drawing.Size(294, 20);
            this.lblShowPasswd.TabIndex = 2;
            // 
            // btnShowMe
            // 
            this.btnShowMe.Location = new System.Drawing.Point(165, 114);
            this.btnShowMe.Name = "btnShowMe";
            this.btnShowMe.Size = new System.Drawing.Size(75, 23);
            this.btnShowMe.TabIndex = 3;
            this.btnShowMe.Text = "Show me!";
            this.btnShowMe.UseVisualStyleBackColor = true;
            this.btnShowMe.Click += new System.EventHandler(this.btnShowMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.btnShowMe);
            this.Controls.Add(this.lblShowPasswd);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.TextBox lblShowPasswd;
        private System.Windows.Forms.Button btnShowMe;
    }
}

