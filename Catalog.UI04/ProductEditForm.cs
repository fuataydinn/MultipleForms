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
    public partial class ProductEditForm : Form
    {
        private List<Product> _productRepository;
        private List<Category> _categoryRepository;
        public ProductEditForm(List<Product> productRepository,List<Category> categoryRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = txtProductName.Text.Trim(),
                Category = (Category)cmbProductCategory.SelectedItem,
                Price = nmrProductPrice.Value,

            };
            _productRepository.Add(product);

            txtProductName.Clear();
          
            //price . clear

            var dialogResult = MessageBox.Show(
               "Kayıt başarıyla gerçekleştirildi, yeni kayıt yapmak istiyor musunuz?",
               "Kayıt başarılı",
               MessageBoxButtons.YesNo);

            if (dialogResult==DialogResult.No)
            {
                Close();
            }
        }

        private void ProductEditForm_Load(object sender, EventArgs e)

        {
            cmbProductCategory.DataSource = null;
            cmbProductCategory.DisplayMember = "Name";
            cmbProductCategory.DataSource = _categoryRepository;
        }
    }
}
