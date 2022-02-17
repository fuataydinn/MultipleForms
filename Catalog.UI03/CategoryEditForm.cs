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

namespace Catalog.UI03
{
    public partial class CategoryEditForm : Form
    {
        private Form1 _form1;

        public CategoryEditForm(Form1 owner)
        {
            InitializeComponent();

            _form1 = owner;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = new Category()
            {
                Id = Guid.NewGuid(), // ID değerini kullanıcı değil sistem belirler
                // bu sebeple ekrandan okumadık
                Name = txtCategoryName.Text.Trim(),
                Description = txtCategoryDescription.Text.Trim()
            };

            _form1.SaveCategory(category);

            txtCategoryName.Clear();
            txtCategoryDescription.Clear();

            var dialogResult = MessageBox.Show(
                "Kayıt başarıyla gerçekleştirildi, yeni kayıt yapmak istiyor musunuz?",
                "Kayıt başarılı",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                Close();
            }
        }
    }
}
