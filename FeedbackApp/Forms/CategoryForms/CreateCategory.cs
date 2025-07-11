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
	public partial class CreateCategory : Form
	{
		public CreateCategory()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string description = txtDescription.Text;

			var category = new CreateCategoryDto
			{
				Description = description,
				Name = name
			};

			CategoriesOperation categoriesOperation = new CategoriesOperation();

			categoriesOperation.AddCategory(category);

			MessageBox.Show("KATEGORİ EKLENDİ");
		}
	}
}
