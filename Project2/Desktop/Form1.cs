using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = this._categoryService.GetAll().ToArray();
            foreach (var category in categories)
            {
                cbxKategori.Items.Add(category.CategoryName);
                cbxAddedCategory.Items.Add(category.CategoryName);
                cbxUpdatedCategory.Items.Add(category.CategoryName);
            }
        }

        private void LoadProducts()
        {
            dgwUr�nler.DataSource = this._productService.GetAll();

        }

        private void cbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = (cbxKategori.SelectedIndex + 1);
            dgwUr�nler.DataSource = _productService.GetByCategoryId(categoryId);
        }

        private void tbxIsimAra_TextChanged(object sender, EventArgs e)
        {
            string name = tbxIsimAra.Text;
            if (!String.IsNullOrEmpty(name))
            {
                dgwUr�nler.DataSource = _productService.GetByProductName(name).ToList();
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Delete(new Product()
                {
                    ProductId = Convert.ToInt32(dgwUr�nler.CurrentRow.Cells[0].Value)
                });
                LoadProducts();
                MessageBox.Show("�r�n Ba�ar� ile Silindi!! ");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product()
                {
                    ProductId = Convert.ToInt32(dgwUr�nler.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdatedProductName.Text,
                    CategoryId = (cbxUpdatedCategory.SelectedIndex + 1),
                    QuantityPerUnit = tbxUpdatedQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxUpdatedUnitsInStock.Text),
                    UnitPrice = Convert.ToDecimal(tbxUpdatedUnitPrice.Text),
                });

                LoadProducts();
                MessageBox.Show("�r�n Ba�ar� ile G�ncellendi!! ");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                {
                    ProductName = tbxAddedProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddedUnitPrice.Text),
                    QuantityPerUnit = tbxAddedQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxAddedUnitsInStock.Text),
                    CategoryId = Convert.ToInt32(cbxAddedCategory.SelectedIndex + 1)
                });

                LoadProducts();
                MessageBox.Show("�r�n Ba�ar� ile Eklendi!! ");
        }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
}

        private void dgwUr�nler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdatedProductName.Text = dgwUr�nler.CurrentRow.Cells[2].Value.ToString();
            tbxUpdatedQuantityPerUnit.Text = dgwUr�nler.CurrentRow.Cells[4].Value.ToString();
            tbxUpdatedUnitPrice.Text = dgwUr�nler.CurrentRow.Cells[3].Value.ToString();
            tbxUpdatedUnitsInStock.Text = dgwUr�nler.CurrentRow.Cells[5].Value.ToString();
            cbxUpdatedCategory.SelectedIndex = (Convert.ToInt32(dgwUr�nler.CurrentRow.Cells[1].Value) - 1);
        }
    }
}