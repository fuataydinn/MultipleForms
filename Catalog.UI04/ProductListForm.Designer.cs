
namespace Catalog.UI04
{
    partial class ProductListForm
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
            this.grdProductsList = new System.Windows.Forms.DataGridView();
            this.collID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductsList
            // 
            this.grdProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collID,
            this.collName,
            this.collCategory,
            this.collPrice});
            this.grdProductsList.Location = new System.Drawing.Point(12, 23);
            this.grdProductsList.Name = "grdProductsList";
            this.grdProductsList.RowTemplate.Height = 25;
            this.grdProductsList.Size = new System.Drawing.Size(762, 389);
            this.grdProductsList.TabIndex = 0;
            this.grdProductsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductsList_CellDoubleClick);
            // 
            // collID
            // 
            this.collID.DataPropertyName = "Id";
            this.collID.HeaderText = "ID";
            this.collID.Name = "collID";
            // 
            // collName
            // 
            this.collName.DataPropertyName = "Name";
            this.collName.HeaderText = "Ürün Adı";
            this.collName.Name = "collName";
            // 
            // collCategory
            // 
            this.collCategory.DataPropertyName = "Category";
            this.collCategory.HeaderText = "Ürün Kategorisi";
            this.collCategory.Name = "collCategory";
            // 
            // collPrice
            // 
            this.collPrice.DataPropertyName = "Price";
            this.collPrice.HeaderText = "Ürün Fiyatı";
            this.collPrice.Name = "collPrice";
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProductsList);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProductsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn collID;
        private System.Windows.Forms.DataGridViewTextBoxColumn collName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn collPrice;
    }
}