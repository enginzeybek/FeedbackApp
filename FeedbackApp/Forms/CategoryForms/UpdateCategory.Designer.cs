namespace FeedbackApp.Forms.CategoryForms
{
	partial class UpdateCategory
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
			lblDescription = new Label();
			txtDescription = new TextBox();
			lblName = new Label();
			txtName = new TextBox();
			lblCategoryPage = new Label();
			btnUpdate = new Button();
			lblCategoryId = new Label();
			txtCategoryId = new TextBox();
			SuspendLayout();
			// 
			// lblDescription
			// 
			lblDescription.AutoSize = true;
			lblDescription.BackColor = Color.FromArgb(88, 177, 159);
			lblDescription.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblDescription.Location = new Point(461, 364);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(147, 41);
			lblDescription.TabIndex = 11;
			lblDescription.Text = "Açıklama";
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(683, 364);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(283, 27);
			txtDescription.TabIndex = 10;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.FromArgb(88, 177, 159);
			lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblName.Location = new Point(461, 271);
			lblName.Name = "lblName";
			lblName.Size = new Size(77, 41);
			lblName.TabIndex = 9;
			lblName.Text = "İsim";
			// 
			// txtName
			// 
			txtName.Location = new Point(683, 271);
			txtName.Name = "txtName";
			txtName.Size = new Size(283, 27);
			txtName.TabIndex = 8;
			// 
			// lblCategoryPage
			// 
			lblCategoryPage.AutoSize = true;
			lblCategoryPage.BackColor = Color.FromArgb(130, 88, 159);
			lblCategoryPage.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblCategoryPage.ForeColor = SystemColors.ButtonHighlight;
			lblCategoryPage.Location = new Point(369, 59);
			lblCategoryPage.Name = "lblCategoryPage";
			lblCategoryPage.Size = new Size(715, 60);
			lblCategoryPage.TabIndex = 7;
			lblCategoryPage.Text = "KATEGORİ GÜNCELLEME SAYFASI";
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.FromArgb(154, 236, 219);
			btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnUpdate.Location = new Point(554, 482);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(275, 62);
			btnUpdate.TabIndex = 6;
			btnUpdate.Text = "GÜNCELLE";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// lblCategoryId
			// 
			lblCategoryId.AutoSize = true;
			lblCategoryId.BackColor = Color.FromArgb(88, 177, 159);
			lblCategoryId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblCategoryId.Location = new Point(461, 166);
			lblCategoryId.Name = "lblCategoryId";
			lblCategoryId.Size = new Size(179, 41);
			lblCategoryId.TabIndex = 13;
			lblCategoryId.Text = "Kategori ID";
			// 
			// txtCategoryId
			// 
			txtCategoryId.Location = new Point(683, 166);
			txtCategoryId.Name = "txtCategoryId";
			txtCategoryId.Size = new Size(283, 27);
			txtCategoryId.TabIndex = 12;
			// 
			// UpdateCategory
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(252, 66, 123);
			ClientSize = new Size(1412, 740);
			Controls.Add(lblCategoryId);
			Controls.Add(txtCategoryId);
			Controls.Add(lblDescription);
			Controls.Add(txtDescription);
			Controls.Add(lblName);
			Controls.Add(txtName);
			Controls.Add(lblCategoryPage);
			Controls.Add(btnUpdate);
			Name = "UpdateCategory";
			Text = "UpdateCategory";
			Load += UpdateCategory_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblDescription;
		private TextBox txtDescription;
		private Label lblName;
		private TextBox txtName;
		private Label lblCategoryPage;
		private Button btnUpdate;
		private Label lblCategoryId;
		private TextBox txtCategoryId;
	}
}