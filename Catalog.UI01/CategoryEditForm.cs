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
    public partial class CategoryEditForm : Form
    {
        public CategoryEditForm()
        {
            InitializeComponent();
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

            Form ownerForm = Owner;
            //ownerForm.Categories // Bu property'e erişemem, çünkü Owner Form tipinde

            Form1 ownerMainForm = (Form1)ownerForm;

            // Owner formu esas tipine downcast ettikten sonra Categories field'ına erişebilirim
            ownerMainForm.Categories.Add(category);

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
