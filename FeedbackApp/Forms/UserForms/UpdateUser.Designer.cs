namespace FeedbackApp.Forms.UserForms
{
	partial class UpdateUser
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
			lblEmail = new Label();
			txtEMail = new TextBox();
			lblName = new Label();
			txtName = new TextBox();
			lblUserPage = new Label();
			btnUpdate = new Button();
			lblUserId = new Label();
			txtUserId = new TextBox();
			SuspendLayout();
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.BackColor = Color.FromArgb(254, 202, 87);
			lblEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblEmail.Location = new Point(409, 357);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(81, 41);
			lblEmail.TabIndex = 31;
			lblEmail.Text = "Mail";
			// 
			// txtEMail
			// 
			txtEMail.Location = new Point(595, 371);
			txtEMail.Name = "txtEMail";
			txtEMail.Size = new Size(433, 27);
			txtEMail.TabIndex = 30;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.FromArgb(254, 202, 87);
			lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblName.Location = new Point(409, 290);
			lblName.Name = "lblName";
			lblName.Size = new Size(77, 41);
			lblName.TabIndex = 29;
			lblName.Text = "İsim";
			// 
			// txtName
			// 
			txtName.Location = new Point(595, 290);
			txtName.Name = "txtName";
			txtName.Size = new Size(433, 27);
			txtName.TabIndex = 28;
			// 
			// lblUserPage
			// 
			lblUserPage.AutoSize = true;
			lblUserPage.BackColor = Color.FromArgb(0, 210, 211);
			lblUserPage.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblUserPage.ForeColor = SystemColors.ButtonHighlight;
			lblUserPage.Location = new Point(385, 94);
			lblUserPage.Name = "lblUserPage";
			lblUserPage.Size = new Size(731, 60);
			lblUserPage.TabIndex = 27;
			lblUserPage.Text = "KULLANICI GÜNCELLEME SAYFASI";
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.FromArgb(255, 107, 107);
			btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnUpdate.Location = new Point(513, 580);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(275, 62);
			btnUpdate.TabIndex = 26;
			btnUpdate.Text = "GÜNCELLE";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// lblUserId
			// 
			lblUserId.AutoSize = true;
			lblUserId.BackColor = Color.FromArgb(254, 202, 87);
			lblUserId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblUserId.Location = new Point(409, 213);
			lblUserId.Name = "lblUserId";
			lblUserId.Size = new Size(179, 41);
			lblUserId.TabIndex = 33;
			lblUserId.Text = "Kullanıcı ID";
			// 
			// txtUserId
			// 
			txtUserId.Location = new Point(595, 213);
			txtUserId.Name = "txtUserId";
			txtUserId.Size = new Size(433, 27);
			txtUserId.TabIndex = 32;
			// 
			// UpdateUser
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 159, 243);
			ClientSize = new Size(1412, 736);
			Controls.Add(lblUserId);
			Controls.Add(txtUserId);
			Controls.Add(lblEmail);
			Controls.Add(txtEMail);
			Controls.Add(lblName);
			Controls.Add(txtName);
			Controls.Add(lblUserPage);
			Controls.Add(btnUpdate);
			Name = "UpdateUser";
			Text = "UpdateUser";
			Load += UpdateUser_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblEmail;
		private TextBox txtEMail;
		private Label lblName;
		private TextBox txtName;
		private Label lblUserPage;
		private Button btnUpdate;
		private Label lblUserId;
		private TextBox txtUserId;
	}
}