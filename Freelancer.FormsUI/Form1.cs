using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Freelancer.Business.Abstract;
using Freelancer.Business.DependencyResolvers.Ninject;
using Freelancer.Entities.Concrate;

namespace Freelancer.FormsUI
{
    public partial class Form1 : Form
    {
        private static KeyValuePair<string, int> selectedCategory;
        private readonly IProductService _productService;

        public Form1()
        {
            InitializeComponent();
            dgwProduct.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgwProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }


        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = new BindingSource(_productService.GetCategoryNamesIds(), null);
            cbxCategory.DisplayMember = "Key";
            cbxCategory.ValueMember = "Value";
            cbxCategoryId.DataSource = new BindingSource(_productService.GetCategoryNamesIds(), null);
            cbxCategoryId.DisplayMember = "Key";
            cbxCategoryId.ValueMember = "Value";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedCategory = (KeyValuePair<string, int>)cbxCategory.SelectedItem;
                dgwProduct.DataSource =
                    _productService.GetProductsByCategory(selectedCategory.Value);
            }
            catch
            {
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxProductName.Text))
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            else
                LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedCategory = (KeyValuePair<string, int>)cbxCategoryId.SelectedItem;
            _productService.Add(new Product
            {
                CategoryId = selectedCategory.Value,
                ProductName = tbxProductName2.Text,
                CategoryName = selectedCategory.Key,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                QuantityPerUnit = tbxQuantityPerUnit.Text,
                UnitsInStock = Convert.ToInt16(tbxStock.Text)
            });
            MessageBox.Show("Urun Kaydedildi.");
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedCategory = (KeyValuePair<string, int>)cbxCategoryId.SelectedItem;
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = selectedCategory.Value,
                ProductName = tbxProductName2.Text,
                CategoryName = selectedCategory.Key,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                QuantityPerUnit = tbxQuantityPerUnit.Text,
                UnitsInStock = Convert.ToInt16(tbxStock.Text)
            });
            MessageBox.Show("Urun Guncellendi.");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductName2.Text = row.Cells[2].Value.ToString();
            cbxCategoryId.SelectedItem = _productService.GetCategoryNamesIds()
                .Where(i => i.Key == row.Cells[3].Value.ToString()).SingleOrDefault();
            tbxUnitPrice.Text = row.Cells[4].Value.ToString();
            tbxQuantityPerUnit.Text = row.Cells[5].Value.ToString();
            tbxStock.Text = row.Cells[6].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
                _productService.Delete(
                    new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });

            MessageBox.Show("Urun Silindi.");
            LoadProducts();
        }

        private void btnFiltreSifirla_Click(object sender, EventArgs e)
        {
            LoadCategories();
            tbxProductName.Text = string.Empty;
            LoadProducts();
        }
    }
}