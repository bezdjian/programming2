namespace WindowsFormsApp1
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
            this.grbDrink = new System.Windows.Forms.GroupBox();
            this.chkVodka = new System.Windows.Forms.CheckBox();
            this.grbDrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDrink
            // 
            this.grbDrink.Controls.Add(this.chkVodka);
            this.grbDrink.Location = new System.Drawing.Point(20, 25);
            this.grbDrink.Name = "grbDrink";
            this.grbDrink.Size = new System.Drawing.Size(200, 100);
            this.grbDrink.TabIndex = 0;
            this.grbDrink.TabStop = false;
            this.grbDrink.Text = "Dryck";
            // 
            // chkVodka
            // 
            this.chkVodka.AutoSize = true;
            this.chkVodka.Location = new System.Drawing.Point(6, 19);
            this.chkVodka.Name = "chkVodka";
            this.chkVodka.Size = new System.Drawing.Size(57, 17);
            this.chkVodka.TabIndex = 1;
            this.chkVodka.Text = "Vodka";
            this.chkVodka.UseVisualStyleBackColor = true;
            this.chkVodka.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 261);
            this.Controls.Add(this.grbDrink);
            this.Name = "Form1";
            this.Text = "Var så god och välj";
            this.grbDrink.ResumeLayout(false);
            this.grbDrink.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDrink;
        private System.Windows.Forms.CheckBox chkVodka;
    }
}

