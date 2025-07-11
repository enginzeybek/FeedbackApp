using FeedbackApp.DTOs.UserDTOs;
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

namespace FeedbackApp.Forms.UserForms
{
	public partial class UpdateUser : Form
	{
		private string _userId;
		private string _name;
		private string _email;
		public UpdateUser(string userId,string name,string email)
		{
			InitializeComponent();
			_userId = userId;
			_name = name;
			_email = email;
		}

		private void UpdateUser_Load(object sender, EventArgs e)
		{
			txtUserId.Text = _userId;
			txtName.Text = _name;
			txtEMail.Text = _email;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			UsersOperation usersOperation = new UsersOperation();

			usersOperation.UpdateUser(new UpdateUserDto
			{
				Email = txtEMail.Text,
				Name = txtName.Text,
				UserId = txtUserId.Text
			});

			MessageBox.Show("KULLANICI GÜNCELLENDİ");
		}
	}
}
