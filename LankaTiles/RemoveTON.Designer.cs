namespace LankaTiles
{
    partial class RemoveTON
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveTON = new System.Windows.Forms.Button();
            this.TONview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TONview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 20);
            this.txtName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Name to Search";
            // 
            // btnRemoveTON
            // 
            this.btnRemoveTON.Location = new System.Drawing.Point(377, 194);
            this.btnRemoveTON.Name = "btnRemoveTON";
            this.btnRemoveTON.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTON.TabIndex = 6;
            this.btnRemoveTON.Text = "Delete";
            this.btnRemoveTON.UseVisualStyleBackColor = true;
            this.btnRemoveTON.Click += new System.EventHandler(this.btnRemoveTON_Click);
            // 
            // TONview
            // 
            this.TONview.AllowUserToAddRows = false;
            this.TONview.AllowUserToDeleteRows = false;
            this.TONview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TONview.Location = new System.Drawing.Point(6, 38);
            this.TONview.Name = "TONview";
            this.TONview.ReadOnly = true;
            this.TONview.Size = new System.Drawing.Size(446, 150);
            this.TONview.TabIndex = 5;
            // 
            // RemoveTON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 225);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveTON);
            this.Controls.Add(this.TONview);
            this.Name = "RemoveTON";
            this.Text = "Remove TON";
            this.Load += new System.EventHandler(this.RemoveTON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TONview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveTON;
        private System.Windows.Forms.DataGridView TONview;
    }
}