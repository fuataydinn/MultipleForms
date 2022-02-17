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
    public partial class CategoryListForm : Form
    {
        private List<Category> _categoryRepository;

        // Dependency Inversion
        //Veri kaynagını ( Bu senaryoda List<Category> tipindeki repository) bu sınıfta yeni instance olarak olusturmuyorum,
        //İnstance dısarıdan bana gonderiliyor.

        //Bu sınıf isini yapabilmesi icin CategoryRepository'e bagımlı (dependent) durumda Repository sınıfını dısarıdan alıyor olmak bu bagımlılıgı terse 
        //cevirmek (dependency inversion) anlamına geliyor
        public CategoryListForm(List<Category> categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            grdCategories.AutoGenerateColumns = false; //reflesh yapınca kolon bilgileri degisti, bunun sayesinde kolonlar eski halinde kalde
            grdCategories.DataSource = _categoryRepository;
        }

        private void grdCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = grdCategories.Rows[e.RowIndex];
            //Bound => Bind Fiilinin geçmiş hali
            //DataBoundItem => bu satıra bind edilmiş nesneyi bize verir
            //Bu nesne dogal olarak bize object tipinde donduruluyor, bizi nesneyi kendi tipine geri donusturmemiz (cast,downcast) yapmalıyız
            var category = (Category)dataRow.DataBoundItem;

            var updateForm = new CategoryUpdateForm(category);
            //burada this dersek sahibi CategoryListForm class' ı olacaktı fakat, biz form1 olsun dedigimiz icin bununda sahibi olan Owner dedik
            //Gelistirdigimiz uygulamanın senaryosu geregi tum alt formların sahibi Form1 ana formudur seklinde dusunulmus ise Update form icin de
            //Owner degeri Form1 olarak set edilebilir
            updateForm.Owner =Owner;
            updateForm.Show();
            //+= diyerek asagdaki metodu da bagladık buraya
            updateForm.FormClosed += UpdateForm_FormClosed;

            //MessageBox.Show($"Kategori Id : {category.Id}\n\r Kategori Adı : {category.Name}");

            //DataGridViewCell rowCell = dataRow.Cells["colId"];

        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Manuel reflesh yaptırdık burada event ile
            grdCategories.DataSource = null;
            grdCategories.DataSource = _categoryRepository;

        }
    }
}
