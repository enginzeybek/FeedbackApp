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
	public partial class CreateFeedback : Form
	{
		public CreateFeedback()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateFeedbackDto createFeedbackDto = new CreateFeedbackDto()
			{
				CategoryId = txtCategoryId.Text,
				Message = txtMessage.Text,
				SubmittedAt = Convert.ToDateTime(txtSubmittedAt.Text),
				UserId = txtUserId.Text
			};

			FeedbacksOperation feedbacksOperation = new FeedbacksOperation();

			feedbacksOperation.CreateFeedback(createFeedbackDto);

			MessageBox.Show("GERİ BİLDİRİM EKLENDİ");
		}
	}
}
