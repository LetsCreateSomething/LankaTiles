namespace LankaTiles
{
    partial class ManageGIN
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
            this.dataGridGIN = new System.Windows.Forms.DataGridView();
            this.dataGridCusName = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCusName)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGIN
            // 
            this.dataGridGIN.AllowUserToAddRows = false;
            this.dataGridGIN.AllowUserToDeleteRows = false;
            this.dataGridGIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGIN.Location = new System.Drawing.Point(12, 74);
            this.dataGridGIN.Name = "dataGridGIN";
            this.dataGridGIN.ReadOnly = true;
            this.dataGridGIN.Size = new System.Drawing.Size(665, 150);
            this.dataGridGIN.TabIndex = 0;
            this.dataGridGIN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGIN_CellClick);
            // 
            // dataGridCusName
            // 
            this.dataGridCusName.AllowUserToAddRows = false;
            this.dataGridCusName.AllowUserToDeleteRows = false;
            this.dataGridCusName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCusName.Location = new System.Drawing.Point(12, 230);
            this.dataGridCusName.Name = "dataGridCusName";
            this.dataGridCusName.ReadOnly = true;
            this.dataGridCusName.Size = new System.Drawing.Size(665, 150);
            this.dataGridCusName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name to Search";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(360, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ManageGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 395);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridCusName);
            this.Controls.Add(this.dataGridGIN);
            this.Name = "ManageGIN";
            this.Text = "ManageGIN";
            this.Load += new System.EventHandler(this.ManageGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCusName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGIN;
        private System.Windows.Forms.DataGridView dataGridCusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
    }
}