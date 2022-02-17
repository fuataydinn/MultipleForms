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
    public partial class CategoryUpdateForm : Form
    {
        private Category _category;
        public CategoryUpdateForm(Category category)
        {
            InitializeComponent();
            _category = category;
        }

        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            //guncelleme olacagı icin inout alanlarının dolu gelmesi gerekiyor
            txtCategoryName.Text = _category.Name;
            txtCategoryDescription.Text = _category.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _category.Name = txtCategoryName.Text.Trim();
            _category.Description = txtCategoryDescription.Text.Trim();

            MessageBox.Show("Başarıyla Güncellendi :)");
            Close();
        }
    }
}
