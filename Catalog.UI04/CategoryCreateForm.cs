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
    public partial class CategoryCreateForm : Form
    {
        //SOLID prensiplerinin S harfını uygulamaya calısıyorum
        //Sıngle responsibility=> tek sorumluluk
        //Projedeki Form1 eski haliyle hem ana form gorevini hem de veri kaydetme gorevini üstlenmişti, bu uygun bir yaklasım degildi...

        //NOT : Repository pattern!ı tam anlamıyla uygulamak icin farklı bir nesne gelistirmek gerekiyor. Şimdilik List<Category> tipindeki bir koleksiyon da
        //(Çok benzer bir yapıya sahip oldugu icin) repository görevini gorebilir.

        private List<Category> _categoryRepository;
        public CategoryCreateForm(List<Category> categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
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

            //SOLID Prensipleri

            //Kaydetme islemleri artık bu sekilde gerceklesiyor
            _categoryRepository.Add(category);  //0x1234.Add(category)

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
