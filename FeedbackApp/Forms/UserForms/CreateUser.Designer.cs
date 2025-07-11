namespace FeedbackApp.Forms.UserForms
{
	partial class CreateUser
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
			btnAdd = new Button();
			SuspendLayout();
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.BackColor = Color.FromArgb(154, 236, 219);
			lblEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblEmail.Location = new Point(445, 354);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(81, 41);
			lblEmail.TabIndex = 25;
			lblEmail.Text = "Mail";
			// 
			// txtEMail
			// 
			txtEMail.Location = new Point(631, 368);
			txtEMail.Name = "txtEMail";
			txtEMail.Size = new Size(433, 27);
			txtEMail.TabIndex = 24;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.FromArgb(154, 236, 219);
			lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblName.Location = new Point(445, 287);
			lblName.Name = "lblName";
			lblName.Size = new Size(77, 41);
			lblName.TabIndex = 23;
			lblName.Text = "İsim";
			// 
			// txtName
			// 
			txtName.Location = new Point(631, 287);
			txtName.Name = "txtName";
			txtName.Size = new Size(433, 27);
			txtName.TabIndex = 22;
			// 
			// lblUserPage
			// 
			lblUserPage.AutoSize = true;
			lblUserPage.BackColor = Color.FromArgb(85, 230, 193);
			lblUserPage.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblUserPage.ForeColor = SystemColors.ButtonHighlight;
			lblUserPage.Location = new Point(421, 91);
			lblUserPage.Name = "lblUserPage";
			lblUserPage.Size = new Size(612, 60);
			lblUserPage.TabIndex = 17;
			lblUserPage.Text = "KULLANICI EKLEME SAYFASI";
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(202, 211, 200);
			btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnAdd.Location = new Point(549, 577);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(275, 62);
			btnAdd.TabIndex = 16;
			btnAdd.Text = "EKLE";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// CreateUser
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 114, 114);
			ClientSize = new Size(1413, 734);
			Controls.Add(lblEmail);
			Controls.Add(txtEMail);
			Controls.Add(lblName);
			Controls.Add(txtName);
			Controls.Add(lblUserPage);
			Controls.Add(btnAdd);
			Name = "CreateUser";
			Text = "CreateUser";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblEmail;
		private TextBox txtEMail;
		private Label lblName;
		private TextBox txtName;
		private Label lblUserPage;
		private Button btnAdd;
	}
}