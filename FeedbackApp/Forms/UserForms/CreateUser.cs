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
	public partial class CreateUser : Form
	{
		public CreateUser()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			UsersOperation usersOperation = new UsersOperation();

			usersOperation.CreateUser(new CreateUserDto
			{
				Email = txtEMail.Text,
				Name = txtName.Text
			});

			MessageBox.Show("KULLANICI EKLENDİ");
		}
	}
}
