namespace LankaTiles
{
    partial class RemoveGIN
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
            this.GINview = new System.Windows.Forms.DataGridView();
            this.btnRemoveGIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GINview)).BeginInit();
            this.SuspendLayout();
            // 
            // GINview
            // 
            this.GINview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GINview.Location = new System.Drawing.Point(12, 38);
            this.GINview.Name = "GINview";
            this.GINview.Size = new System.Drawing.Size(542, 150);
            this.GINview.TabIndex = 0;
            // 
            // btnRemoveGIN
            // 
            this.btnRemoveGIN.Location = new System.Drawing.Point(479, 194);
            this.btnRemoveGIN.Name = "btnRemoveGIN";
            this.btnRemoveGIN.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveGIN.TabIndex = 1;
            this.btnRemoveGIN.Text = "Delete";
            this.btnRemoveGIN.UseVisualStyleBackColor = true;
            this.btnRemoveGIN.Click += new System.EventHandler(this.btnRemoveGIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name to Search";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(389, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // RemoveGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 229);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveGIN);
            this.Controls.Add(this.GINview);
            this.Name = "RemoveGIN";
            this.Text = "RemoveGIN";
            this.Load += new System.EventHandler(this.RemoveGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GINview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GINview;
        private System.Windows.Forms.Button btnRemoveGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
    }
}