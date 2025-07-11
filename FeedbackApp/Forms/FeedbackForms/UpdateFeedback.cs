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
	public partial class UpdateFeedback : Form
	{
		private string _userId;
		private string _categoryId;
		private string _message;
		private DateTime _submittedAt;
		private string _feedbackId;

		public UpdateFeedback(string userId, string categoryId, string message, DateTime submittedAt, string feedbackId)
		{
			InitializeComponent();
			_userId = userId;
			_categoryId = categoryId;
			_message = message;
			_submittedAt = submittedAt;
			_feedbackId = feedbackId;
		}

		private void UpdateFeedback_Load(object sender, EventArgs e)
		{
			txtCategoryId.Text = _categoryId;
			txtMessage.Text = _message;
			txtSubmittedAt.Text = Convert.ToDateTime(_submittedAt).ToString();
			txtUserId.Text = _userId;
			txtFeedbackId.Text = _feedbackId;
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string UpdatedFeedbackId = txtFeedbackId.Text;

			UpdateFeedbackDto updateFeedbackDto = new UpdateFeedbackDto()
			{
				CategoryId = txtCategoryId.Text,
				FeedbackId = UpdatedFeedbackId,
				Message = txtMessage.Text,
				UserId = txtUserId.Text,
				SubmittedAt = Convert.ToDateTime(txtSubmittedAt.Text)
			};

			FeedbacksOperation feedbacksOperation = new FeedbacksOperation();

			feedbacksOperation.UpdateFeedback(updateFeedbackDto);

			MessageBox.Show("GERİ BİLDİRİM GÜNCELLENDİ");
		}

		
	}
}
