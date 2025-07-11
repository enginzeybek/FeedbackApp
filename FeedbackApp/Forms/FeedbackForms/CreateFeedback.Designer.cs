namespace FeedbackApp.Forms.FeedbackForms
{
	partial class CreateFeedback
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblCategoryId = new Label();
			txtCategoryId = new TextBox();
			lblUserId = new Label();
			txtUserId = new TextBox();
			lblFeedbackPage = new Label();
			btnAdd = new Button();
			lblMessage = new Label();
			txtMessage = new TextBox();
			lblSubmittedAt = new Label();
			txtSubmittedAt = new TextBox();
			SuspendLayout();
			// 
			// lblCategoryId
			// 
			lblCategoryId.AutoSize = true;
			lblCategoryId.BackColor = Color.FromArgb(255, 56, 56);
			lblCategoryId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblCategoryId.Location = new Point(441, 318);
			lblCategoryId.Name = "lblCategoryId";
			lblCategoryId.Size = new Size(179, 41);
			lblCategoryId.TabIndex = 11;
			lblCategoryId.Text = "Kategori ID";
			// 
			// txtCategoryId
			// 
			txtCategoryId.Location = new Point(777, 318);
			txtCategoryId.Name = "txtCategoryId";
			txtCategoryId.Size = new Size(283, 27);
			txtCategoryId.TabIndex = 10;
			// 
			// lblUserId
			// 
			lblUserId.AutoSize = true;
			lblUserId.BackColor = Color.FromArgb(255, 56, 56);
			lblUserId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblUserId.Location = new Point(441, 225);
			lblUserId.Name = "lblUserId";
			lblUserId.Size = new Size(179, 41);
			lblUserId.TabIndex = 9;
			lblUserId.Text = "Kullanıcı ID";
			// 
			// txtUserId
			// 
			txtUserId.Location = new Point(777, 225);
			txtUserId.Name = "txtUserId";
			txtUserId.Size = new Size(283, 27);
			txtUserId.TabIndex = 8;
			// 
			// lblFeedbackPage
			// 
			lblFeedbackPage.AutoSize = true;
			lblFeedbackPage.BackColor = Color.FromArgb(205, 132, 241);
			lblFeedbackPage.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblFeedbackPage.ForeColor = SystemColors.ButtonHighlight;
			lblFeedbackPage.Location = new Point(382, 72);
			lblFeedbackPage.Name = "lblFeedbackPage";
			lblFeedbackPage.Size = new Size(688, 60);
			lblFeedbackPage.TabIndex = 7;
			lblFeedbackPage.Text = "GERİ BİLDİRİM EKLEME SAYFASI";
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(255, 250, 101);
			btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnAdd.Location = new Point(569, 553);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(275, 62);
			btnAdd.TabIndex = 6;
			btnAdd.Text = "EKLE";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// lblMessage
			// 
			lblMessage.AutoSize = true;
			lblMessage.BackColor = Color.FromArgb(255, 56, 56);
			lblMessage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblMessage.Location = new Point(441, 404);
			lblMessage.Name = "lblMessage";
			lblMessage.Size = new Size(101, 41);
			lblMessage.TabIndex = 13;
			lblMessage.Text = "Mesaj";
			// 
			// txtMessage
			// 
			txtMessage.Location = new Point(777, 404);
			txtMessage.Name = "txtMessage";
			txtMessage.Size = new Size(283, 27);
			txtMessage.TabIndex = 12;
			// 
			// lblSubmittedAt
			// 
			lblSubmittedAt.AutoSize = true;
			lblSubmittedAt.BackColor = Color.FromArgb(255, 56, 56);
			lblSubmittedAt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblSubmittedAt.Location = new Point(441, 471);
			lblSubmittedAt.Name = "lblSubmittedAt";
			lblSubmittedAt.Size = new Size(245, 41);
			lblSubmittedAt.TabIndex = 15;
			lblSubmittedAt.Text = "Gönderim Tarihi";
			// 
			// txtSubmittedAt
			// 
			txtSubmittedAt.Location = new Point(777, 485);
			txtSubmittedAt.Name = "txtSubmittedAt";
			txtSubmittedAt.Size = new Size(283, 27);
			txtSubmittedAt.TabIndex = 14;
			// 
			// CreateFeedback
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(50, 255, 126);
			ClientSize = new Size(1408, 738);
			Controls.Add(lblSubmittedAt);
			Controls.Add(txtSubmittedAt);
			Controls.Add(lblMessage);
			Controls.Add(txtMessage);
			Controls.Add(lblCategoryId);
			Controls.Add(txtCategoryId);
			Controls.Add(lblUserId);
			Controls.Add(txtUserId);
			Controls.Add(lblFeedbackPage);
			Controls.Add(btnAdd);
			Name = "CreateFeedback";
			Text = "CreateFeedback";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblCategoryId;
		private TextBox txtCategoryId;
		private Label lblUserId;
		private TextBox txtUserId;
		private Label lblFeedbackPage;
		private Button btnAdd;
		private Label lblMessage;
		private TextBox txtMessage;
		private Label lblSubmittedAt;
		private TextBox txtSubmittedAt;
	}
}