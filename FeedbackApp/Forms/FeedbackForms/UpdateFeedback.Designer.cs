namespace FeedbackApp.Forms.FeedbackForms
{
	partial class UpdateFeedback
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
			lblSubmittedAt = new Label();
			txtSubmittedAt = new TextBox();
			lblMessage = new Label();
			txtMessage = new TextBox();
			lblCategoryId = new Label();
			txtCategoryId = new TextBox();
			lblUserId = new Label();
			txtUserId = new TextBox();
			lblFeedbackPage = new Label();
			btnUpdate = new Button();
			lblFeedbackId = new Label();
			txtFeedbackId = new TextBox();
			SuspendLayout();
			// 
			// lblSubmittedAt
			// 
			lblSubmittedAt.AutoSize = true;
			lblSubmittedAt.BackColor = Color.FromArgb(60, 64, 198);
			lblSubmittedAt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblSubmittedAt.Location = new Point(419, 460);
			lblSubmittedAt.Name = "lblSubmittedAt";
			lblSubmittedAt.Size = new Size(245, 41);
			lblSubmittedAt.TabIndex = 25;
			lblSubmittedAt.Text = "Gönderim Tarihi";
			// 
			// txtSubmittedAt
			// 
			txtSubmittedAt.Location = new Point(755, 460);
			txtSubmittedAt.Name = "txtSubmittedAt";
			txtSubmittedAt.Size = new Size(283, 27);
			txtSubmittedAt.TabIndex = 24;
			// 
			// lblMessage
			// 
			lblMessage.AutoSize = true;
			lblMessage.BackColor = Color.FromArgb(60, 64, 198);
			lblMessage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblMessage.Location = new Point(419, 393);
			lblMessage.Name = "lblMessage";
			lblMessage.Size = new Size(101, 41);
			lblMessage.TabIndex = 23;
			lblMessage.Text = "Mesaj";
			// 
			// txtMessage
			// 
			txtMessage.Location = new Point(755, 393);
			txtMessage.Name = "txtMessage";
			txtMessage.Size = new Size(283, 27);
			txtMessage.TabIndex = 22;
			// 
			// lblCategoryId
			// 
			lblCategoryId.AutoSize = true;
			lblCategoryId.BackColor = Color.FromArgb(60, 64, 198);
			lblCategoryId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblCategoryId.Location = new Point(419, 307);
			lblCategoryId.Name = "lblCategoryId";
			lblCategoryId.Size = new Size(179, 41);
			lblCategoryId.TabIndex = 21;
			lblCategoryId.Text = "Kategori ID";
			// 
			// txtCategoryId
			// 
			txtCategoryId.Location = new Point(755, 307);
			txtCategoryId.Name = "txtCategoryId";
			txtCategoryId.Size = new Size(283, 27);
			txtCategoryId.TabIndex = 20;
			// 
			// lblUserId
			// 
			lblUserId.AutoSize = true;
			lblUserId.BackColor = Color.FromArgb(60, 64, 198);
			lblUserId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblUserId.Location = new Point(419, 214);
			lblUserId.Name = "lblUserId";
			lblUserId.Size = new Size(179, 41);
			lblUserId.TabIndex = 19;
			lblUserId.Text = "Kullanıcı ID";
			// 
			// txtUserId
			// 
			txtUserId.Location = new Point(755, 214);
			txtUserId.Name = "txtUserId";
			txtUserId.Size = new Size(283, 27);
			txtUserId.TabIndex = 18;
			// 
			// lblFeedbackPage
			// 
			lblFeedbackPage.AutoSize = true;
			lblFeedbackPage.BackColor = Color.FromArgb(239, 87, 119);
			lblFeedbackPage.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblFeedbackPage.ForeColor = SystemColors.ButtonHighlight;
			lblFeedbackPage.Location = new Point(315, 58);
			lblFeedbackPage.Name = "lblFeedbackPage";
			lblFeedbackPage.Size = new Size(807, 60);
			lblFeedbackPage.TabIndex = 17;
			lblFeedbackPage.Text = "GERİ BİLDİRİM GÜNCELLEME SAYFASI\r\n";
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.FromArgb(11, 232, 129);
			btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnUpdate.Location = new Point(547, 542);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(275, 62);
			btnUpdate.TabIndex = 16;
			btnUpdate.Text = "GÜNCELLE";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// lblFeedbackId
			// 
			lblFeedbackId.AutoSize = true;
			lblFeedbackId.BackColor = Color.FromArgb(60, 64, 198);
			lblFeedbackId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblFeedbackId.Location = new Point(419, 145);
			lblFeedbackId.Name = "lblFeedbackId";
			lblFeedbackId.Size = new Size(237, 41);
			lblFeedbackId.TabIndex = 27;
			lblFeedbackId.Text = "Geri Bildirim ID";
			// 
			// txtFeedbackId
			// 
			txtFeedbackId.Location = new Point(755, 145);
			txtFeedbackId.Name = "txtFeedbackId";
			txtFeedbackId.Size = new Size(283, 27);
			txtFeedbackId.TabIndex = 26;
			// 
			// UpdateFeedback
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(72, 84, 96);
			ClientSize = new Size(1405, 740);
			Controls.Add(lblFeedbackId);
			Controls.Add(txtFeedbackId);
			Controls.Add(lblSubmittedAt);
			Controls.Add(txtSubmittedAt);
			Controls.Add(lblMessage);
			Controls.Add(txtMessage);
			Controls.Add(lblCategoryId);
			Controls.Add(txtCategoryId);
			Controls.Add(lblUserId);
			Controls.Add(txtUserId);
			Controls.Add(lblFeedbackPage);
			Controls.Add(btnUpdate);
			Name = "UpdateFeedback";
			Text = "UpdateFeedback";
			Load += UpdateFeedback_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblSubmittedAt;
		private TextBox txtSubmittedAt;
		private Label lblMessage;
		private TextBox txtMessage;
		private Label lblCategoryId;
		private TextBox txtCategoryId;
		private Label lblUserId;
		private TextBox txtUserId;
		private Label lblFeedbackPage;
		private Button btnUpdate;
		private Label lblFeedbackId;
		private TextBox txtFeedbackId;
	}
}