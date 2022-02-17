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
    public partial class ProductListForm : Form
    {
        private List<Product> _productRepository;
        public ProductListForm(List<Product> productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
           //Data Binding // Data bind (yapıstırma) veriyi baglamak
            grdProductsList.DataSource = _productRepository;
        }

        private void grdProductsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
