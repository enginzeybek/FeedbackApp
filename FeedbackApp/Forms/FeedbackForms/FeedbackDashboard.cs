using FeedbackApp.DTOs.FeedbackDTOs;
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

namespace FeedbackApp.Forms.FeedbackForms
{
	public partial class FeedbackDashboard : Form
	{
		public FeedbackDashboard()
		{
			InitializeComponent();
		}

		private void FeedbackDashboard_Load(object sender, EventArgs e)
		{
			FeedbacksOperation feedbacksOperation = new FeedbacksOperation();

			dataGridView1.DataSource = feedbacksOperation.FeedbackList();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			FeedbacksOperation feedbacksOperation = new FeedbacksOperation();

			dataGridView1.DataSource = feedbacksOperation.FeedbackList();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateFeedback createFeedback = new CreateFeedback();

			createFeedback.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string FeedbackId = dataGridView1.SelectedRows[0].Cells["FeedbackId"].Value.ToString();
			string UserId = dataGridView1.SelectedRows[0].Cells["UserId"].Value.ToString();
			string CategoryId = dataGridView1.SelectedRows[0].Cells["categoryId"].Value.ToString();
			string Message = dataGridView1.SelectedRows[0].Cells["Message"].Value.ToString();
			DateTime SubmittedAt = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["submittedAt"].Value.ToString());


			UpdateFeedback updateFeedback = new UpdateFeedback(UserId,CategoryId,Message,SubmittedAt,FeedbackId);

			updateFeedback.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string FeedbackId = dataGridView1.SelectedRows[0].Cells["FeedbackId"].Value.ToString();

			FeedbacksOperation feedbacksOperation = new FeedbacksOperation();

			feedbacksOperation.DeleteFeedback(FeedbackId);

			MessageBox.Show("GERİ BİLDİRİM BAŞARI İLE SİLİNDİ");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			string feedbackId = txtGetById.Text;

			FeedbacksOperation feedbacksOperation = new FeedbacksOperation();

			GetFeedbackDto getFeedbackDto = feedbacksOperation.GetFeedback(feedbackId);

			dataGridView1.DataSource = new List<GetFeedbackDto> { getFeedbackDto };
		}
	}
}
