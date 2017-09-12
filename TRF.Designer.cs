namespace TRF
{
    partial class TRF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTRFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggTillToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fileToolStripMenuItem.Text = "Medlem";
            // 
            // läggTillToolStripMenuItem
            // 
            this.läggTillToolStripMenuItem.Name = "läggTillToolStripMenuItem";
            this.läggTillToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.läggTillToolStripMenuItem.Text = "Lägg till";
            this.läggTillToolStripMenuItem.Click += new System.EventHandler(this.laggTillToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTRFToolStripMenuItem,
            this.stängToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.aboutToolStripMenuItem.Text = "Om";
            // 
            // aboutTRFToolStripMenuItem
            // 
            this.aboutTRFToolStripMenuItem.Name = "aboutTRFToolStripMenuItem";
            this.aboutTRFToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutTRFToolStripMenuItem.Text = "Om TRF";
            this.aboutTRFToolStripMenuItem.Click += new System.EventHandler(this.aboutTRFToolStripMenuItem_Click);
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.stangToolStripMenuItem_Click);
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToAddRows = false;
            this.usersDataGrid.AllowUserToDeleteRows = false;
            this.usersDataGrid.AllowUserToOrderColumns = true;
            this.usersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(15, 99);
            this.usersDataGrid.MultiSelect = false;
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.RowHeadersWidth = 40;
            this.usersDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usersDataGrid.Size = new System.Drawing.Size(685, 415);
            this.usersDataGrid.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(15, 523);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(96, 523);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Updatera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(177, 523);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Radera";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Rensa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(268, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(57, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medlem:";
            // 
            // TRF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(714, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.usersDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TRF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tigerälskarnas Riksförbund";
            this.Load += new System.EventHandler(this.TRF_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTRFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}

