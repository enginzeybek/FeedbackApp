using FeedbackApp.DTOs.CategoryDTOs;
using FeedbackApp.MongoDbOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackApp.Forms.CategoryForms
{
	public partial class CategoryDashboard : Form
	{
		public CategoryDashboard()
		{
			InitializeComponent();
		}

		private void CategoryDashboard_Load(object sender, EventArgs e)
		{
			CategoriesOperation categoriesOperation = new CategoriesOperation();

			dataGridView1.DataSource = categoriesOperation.CategoryList();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			CategoriesOperation categoriesOperation = new CategoriesOperation();

			dataGridView1.DataSource = categoriesOperation.CategoryList();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateCategory createCategory = new CreateCategory();

			createCategory.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string CategoryId = dataGridView1.SelectedRows[0].Cells["CategoryId"].Value.ToString();
			string Name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
			string Description = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();

			UpdateCategory updateCategory = new UpdateCategory(CategoryId,Name,Description);

			updateCategory.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string categoryId = dataGridView1.SelectedRows[0].Cells["CategoryId"].Value.ToString();

			CategoriesOperation categoriesOperation = new CategoriesOperation();

			categoriesOperation.DeleteCategory(categoryId);

			MessageBox.Show("KATEGORİ SİLİNDİ");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			string categoryId = txtGetById.Text;

			CategoriesOperation categoriesOperation = new CategoriesOperation();

			GetCategoryDto getCategoryDto = categoriesOperation.GetCategory(categoryId);

			dataGridView1.DataSource = new List<GetCategoryDto> { getCategoryDto };
		}
	}
}
