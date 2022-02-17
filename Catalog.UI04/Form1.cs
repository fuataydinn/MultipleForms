using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog.UI04
{
    public partial class Form1 : Form
    {
        private List<Category> Categories = new List<Category>();
        private List<Product> Products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemNewCategory_Click(object sender, EventArgs e)
        {
            // Kategori oluşturma formunu görüntülemeyi burada yapılacak kodlamayla sağlayacağım

            //Kategori olsuturma formunu goruntulemeyi burada yapılacak kodlamayla saglayacagım
            var categoryForm = new CategoryCreateForm(Categories); //0x1234 adresini gönderdim
            categoryForm.Owner = this;
            categoryForm.Show();
        }

        private void menuItemAllCategories_Click(object sender, EventArgs e)
        {
            var categoryListForm = new CategoryListForm(Categories);
            categoryListForm.Owner = this;
            categoryListForm.Show();
        }

        private void menuItemNewProduct_Click(object sender, EventArgs e)
        {
            var productForm = new ProductEditForm(Products,Categories);
            productForm.Owner = this;
            productForm.Show();
            
        }

        private void menuItemAllProducts_Click(object sender, EventArgs e)
        {
            var productListForm = new ProductListForm(Products);
            productListForm.Owner = this;
            productListForm.Show();
        }
    }
}
