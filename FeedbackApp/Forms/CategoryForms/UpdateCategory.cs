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
	public partial class UpdateCategory : Form
	{
		private string _categoryId;
		private string _name;
		private string _description;
		public UpdateCategory(string categoryId,string name,string description)
		{
			InitializeComponent();
			_categoryId = categoryId;
			_name = name;
			_description = description;
		}

		private void UpdateCategory_Load(object sender, EventArgs e)
		{
			txtCategoryId.Text = _categoryId;
			txtDescription.Text = _description;
			txtName.Text = _name;
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string categoryId = txtCategoryId.Text;

			string name = txtName.Text;

			string description = txtDescription.Text;

			UpdateCategoryDto updateCategoryDto = new UpdateCategoryDto();

			updateCategoryDto.Name = name;
			updateCategoryDto.Description = description;
			updateCategoryDto.CategoryId = categoryId;

			CategoriesOperation categoriesOperation = new CategoriesOperation();

			categoriesOperation.UpdateCategory(updateCategoryDto);

			MessageBox.Show("KATEGORİ GÜNCELLENDİ");
		}

		
	}
}
