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

namespace Catalog.UI01
{
    public partial class Form1 : Form
    {
        public List<Category> Categories = new List<Category>();

        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemNewCategory_Click(object sender, EventArgs e)
        {
            // Kategori oluşturma formunu görüntülemeyi burada yapılacak kodlamayla sağlayacağım

            var categoryForm = new CategoryEditForm();
            categoryForm.Owner = this;
            categoryForm.Show();
        }
    }
}
