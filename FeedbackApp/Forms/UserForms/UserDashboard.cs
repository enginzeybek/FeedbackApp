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
	public partial class UserDashboard : Form
	{
		public UserDashboard()
		{
			InitializeComponent();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			UsersOperation usersOperation = new UsersOperation();

			dataGridView1.DataSource = usersOperation.UserList();
		}

		private void UserDashboard_Load(object sender, EventArgs e)
		{
			UsersOperation usersOperation = new UsersOperation();

			dataGridView1.DataSource = usersOperation.UserList();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateUser createUser = new CreateUser();

			createUser.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var chosenUserId = dataGridView1.SelectedRows[0].Cells["UserId"].Value.ToString();
			var chosenName = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
			var chosenEmail = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();

			UpdateUser updateUser = new UpdateUser(chosenUserId, chosenName, chosenEmail);

			updateUser.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var userId = dataGridView1.SelectedRows[0].Cells["UserId"].Value.ToString();

			UsersOperation usersOperation = new UsersOperation();

			usersOperation.DeleteUser(userId);

			MessageBox.Show("KULLANICI SİLİNDİ");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			var userId = txtGetById.Text;

			UsersOperation usersOperation = new UsersOperation();

			GetUserDto getUserDto = usersOperation.GetUser(userId);

			dataGridView1.DataSource = new List<GetUserDto> { getUserDto };
		}
	}
}
