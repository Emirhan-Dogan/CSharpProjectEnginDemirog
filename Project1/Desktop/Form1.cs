using Desktop.DataAccess.EntityFramework.Contexts;
using Desktop.Entities;
using System.Collections.Generic;

namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwUrünler.DataSource = ListProduct();

            var categories = ListCategory();
            foreach (var category in categories)
            {
                cbxKategori.Items.Add(category.CategoryName);
            }
        }

        private void tbxIsimAra_TextChanged(object sender, EventArgs e)
        {
            var searchName = tbxIsimAra.Text;
            if (String.IsNullOrEmpty(searchName))
            {
                ListProduct();
            }
            else
            {
                dgwUrünler.DataSource = ListProductsByProductName(searchName);
            }
        }

        private void cbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoryId = (cbxKategori.SelectedIndex + 1);
            dgwUrünler.DataSource = ListProductsByCategory((int)categoryId);
        }

        public List<Product> ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }

        public List<Product> ListProduct()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Category> ListCategory()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }

        public List<Product> ListProductsByProductName(string searchName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.Where(p => p.ProductName.ToLower().Contains(searchName.ToLower())).ToList();
            }
        }
    }
}