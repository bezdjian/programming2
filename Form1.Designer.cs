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
            this.chkGin = new System.Windows.Forms.CheckBox();
            this.chkVodka = new System.Windows.Forms.CheckBox();
            this.grbGlass = new System.Windows.Forms.GroupBox();
            this.btnServ = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.optShotGlass = new System.Windows.Forms.RadioButton();
            this.optCocktailGlass = new System.Windows.Forms.RadioButton();
            this.optVinGlass = new System.Windows.Forms.RadioButton();
            this.grbDrink.SuspendLayout();
            this.grbGlass.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDrink
            // 
            this.grbDrink.Controls.Add(this.chkGin);
            this.grbDrink.Controls.Add(this.chkVodka);
            this.grbDrink.Location = new System.Drawing.Point(20, 25);
            this.grbDrink.Name = "grbDrink";
            this.grbDrink.Size = new System.Drawing.Size(150, 100);
            this.grbDrink.TabIndex = 0;
            this.grbDrink.TabStop = false;
            this.grbDrink.Text = "Dryck";
            // 
            // chkGin
            // 
            this.chkGin.AutoSize = true;
            this.chkGin.Location = new System.Drawing.Point(15, 60);
            this.chkGin.Name = "chkGin";
            this.chkGin.Size = new System.Drawing.Size(42, 17);
            this.chkGin.TabIndex = 2;
            this.chkGin.Text = "Gin";
            this.chkGin.UseVisualStyleBackColor = true;
            // 
            // chkVodka
            // 
            this.chkVodka.AutoSize = true;
            this.chkVodka.Location = new System.Drawing.Point(15, 30);
            this.chkVodka.Name = "chkVodka";
            this.chkVodka.Size = new System.Drawing.Size(57, 17);
            this.chkVodka.TabIndex = 1;
            this.chkVodka.Text = "Vodka";
            this.chkVodka.UseVisualStyleBackColor = true;
            this.chkVodka.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grbGlass
            // 
            this.grbGlass.Controls.Add(this.optVinGlass);
            this.grbGlass.Controls.Add(this.optCocktailGlass);
            this.grbGlass.Controls.Add(this.optShotGlass);
            this.grbGlass.Location = new System.Drawing.Point(200, 25);
            this.grbGlass.Name = "grbGlass";
            this.grbGlass.Size = new System.Drawing.Size(200, 140);
            this.grbGlass.TabIndex = 1;
            this.grbGlass.TabStop = false;
            this.grbGlass.Text = "Välj glas";
            // 
            // btnServ
            // 
            this.btnServ.Location = new System.Drawing.Point(440, 30);
            this.btnServ.MinimumSize = new System.Drawing.Size(120, 70);
            this.btnServ.Name = "btnServ";
            this.btnServ.Size = new System.Drawing.Size(120, 70);
            this.btnServ.TabIndex = 2;
            this.btnServ.Text = "Servera";
            this.btnServ.UseVisualStyleBackColor = true;
            this.btnServ.Click += new System.EventHandler(this.btnServ_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(460, 135);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 45);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Avsluta";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // optShotGlass
            // 
            this.optShotGlass.AutoSize = true;
            this.optShotGlass.Location = new System.Drawing.Point(15, 30);
            this.optShotGlass.Name = "optShotGlass";
            this.optShotGlass.Size = new System.Drawing.Size(74, 17);
            this.optShotGlass.TabIndex = 0;
            this.optShotGlass.TabStop = true;
            this.optShotGlass.Text = "Snapsglas";
            this.optShotGlass.UseVisualStyleBackColor = true;
            // 
            // optCocktailGlass
            // 
            this.optCocktailGlass.AutoSize = true;
            this.optCocktailGlass.Location = new System.Drawing.Point(15, 60);
            this.optCocktailGlass.Name = "optCocktailGlass";
            this.optCocktailGlass.Size = new System.Drawing.Size(82, 17);
            this.optCocktailGlass.TabIndex = 1;
            this.optCocktailGlass.TabStop = true;
            this.optCocktailGlass.Text = "Cocktailglas";
            this.optCocktailGlass.UseVisualStyleBackColor = true;
            // 
            // optVinGlass
            // 
            this.optVinGlass.AutoSize = true;
            this.optVinGlass.Location = new System.Drawing.Point(15, 90);
            this.optVinGlass.Name = "optVinGlass";
            this.optVinGlass.Size = new System.Drawing.Size(59, 17);
            this.optVinGlass.TabIndex = 2;
            this.optVinGlass.TabStop = true;
            this.optVinGlass.Text = "Vinglas";
            this.optVinGlass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 261);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnServ);
            this.Controls.Add(this.grbGlass);
            this.Controls.Add(this.grbDrink);
            this.Name = "Form1";
            this.Text = "Var så god och välj";
            this.grbDrink.ResumeLayout(false);
            this.grbDrink.PerformLayout();
            this.grbGlass.ResumeLayout(false);
            this.grbGlass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDrink;
        private System.Windows.Forms.CheckBox chkVodka;
        private System.Windows.Forms.CheckBox chkGin;
        private System.Windows.Forms.GroupBox grbGlass;
        private System.Windows.Forms.Button btnServ;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.RadioButton optVinGlass;
        private System.Windows.Forms.RadioButton optCocktailGlass;
        private System.Windows.Forms.RadioButton optShotGlass;
    }
}

