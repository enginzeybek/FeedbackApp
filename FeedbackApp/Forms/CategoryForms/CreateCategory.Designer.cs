namespace FeedbackApp.Forms.CategoryForms
{
	partial class CreateCategory
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
			btnAdd = new Button();
			lblCategoryPage = new Label();
			txtName = new TextBox();
			lblName = new Label();
			lblDescription = new Label();
			txtDescription = new TextBox();
			SuspendLayout();
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(234, 181, 67);
			btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnAdd.Location = new Point(554, 418);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(275, 62);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "EKLE";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// lblCategoryPage
			// 
			lblCategoryPage.AutoSize = true;
			lblCategoryPage.BackColor = Color.FromArgb(179, 55, 113);
			lblCategoryPage.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblCategoryPage.ForeColor = SystemColors.ButtonHighlight;
			lblCategoryPage.Location = new Point(364, 54);
			lblCategoryPage.Name = "lblCategoryPage";
			lblCategoryPage.Size = new Size(596, 60);
			lblCategoryPage.TabIndex = 1;
			lblCategoryPage.Text = "KATEGORİ EKLEME SAYFASI";
			// 
			// txtName
			// 
			txtName.Location = new Point(677, 207);
			txtName.Name = "txtName";
			txtName.Size = new Size(283, 27);
			txtName.TabIndex = 2;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.FromArgb(37, 204, 247);
			lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblName.Location = new Point(455, 207);
			lblName.Name = "lblName";
			lblName.Size = new Size(77, 41);
			lblName.TabIndex = 3;
			lblName.Text = "İsim";
			// 
			// lblDescription
			// 
			lblDescription.AutoSize = true;
			lblDescription.BackColor = Color.FromArgb(37, 204, 247);
			lblDescription.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblDescription.Location = new Point(455, 300);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(147, 41);
			lblDescription.TabIndex = 5;
			lblDescription.Text = "Açıklama";
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(677, 300);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(283, 27);
			txtDescription.TabIndex = 4;
			// 
			// CreateCategory
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(165, 94, 234);
			ClientSize = new Size(1404, 732);
			Controls.Add(lblDescription);
			Controls.Add(txtDescription);
			Controls.Add(lblName);
			Controls.Add(txtName);
			Controls.Add(lblCategoryPage);
			Controls.Add(btnAdd);
			Name = "CreateCategory";
			Text = "CreateCategory";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAdd;
		private Label lblCategoryPage;
		private TextBox txtName;
		private Label lblName;
		private Label lblDescription;
		private TextBox txtDescription;
	}
}