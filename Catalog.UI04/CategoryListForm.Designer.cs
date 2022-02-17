
namespace Catalog.UI04
{
    partial class CategoryListForm
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
            this.grdCategories = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCategories
            // 
            this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colDescription});
            this.grdCategories.Location = new System.Drawing.Point(12, 12);
            this.grdCategories.Name = "grdCategories";
            this.grdCategories.RowTemplate.Height = 25;
            this.grdCategories.Size = new System.Drawing.Size(736, 426);
            this.grdCategories.TabIndex = 0;
            this.grdCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Kategori Adı";
            this.colName.Name = "colName";
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Açıklama";
            this.colDescription.Name = "colDescription";
            // 
            // CategoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCategories);
            this.Name = "CategoryListForm";
            this.Text = "CategoryListForm";
            this.Load += new System.EventHandler(this.CategoryListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}