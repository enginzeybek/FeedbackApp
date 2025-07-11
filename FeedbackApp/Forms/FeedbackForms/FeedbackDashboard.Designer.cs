namespace FeedbackApp.Forms.FeedbackForms
{
	partial class FeedbackDashboard
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
			panel2 = new Panel();
			lblDataScreen = new Label();
			dataGridView1 = new DataGridView();
			panel1 = new Panel();
			txtGetById = new TextBox();
			btnGetById = new Button();
			lblFeedbackProcess = new Label();
			btnDelete = new Button();
			btnUpdate = new Button();
			btnAdd = new Button();
			lblProcess = new Label();
			btnList = new Button();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(189, 197, 129);
			panel2.Controls.Add(lblDataScreen);
			panel2.Controls.Add(dataGridView1);
			panel2.Location = new Point(707, 6);
			panel2.Name = "panel2";
			panel2.Size = new Size(688, 724);
			panel2.TabIndex = 1;
			// 
			// lblDataScreen
			// 
			lblDataScreen.AutoSize = true;
			lblDataScreen.BackColor = Color.FromArgb(234, 181, 67);
			lblDataScreen.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
			lblDataScreen.Location = new Point(254, 592);
			lblDataScreen.Name = "lblDataScreen";
			lblDataScreen.Size = new Size(155, 41);
			lblDataScreen.TabIndex = 1;
			lblDataScreen.Text = "Veri Ekranı";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(0, 0);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(685, 528);
			dataGridView1.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(179, 55, 113);
			panel1.Controls.Add(txtGetById);
			panel1.Controls.Add(btnGetById);
			panel1.Controls.Add(lblFeedbackProcess);
			panel1.Controls.Add(btnDelete);
			panel1.Controls.Add(btnUpdate);
			panel1.Controls.Add(btnAdd);
			panel1.Controls.Add(lblProcess);
			panel1.Controls.Add(btnList);
			panel1.Location = new Point(9, 6);
			panel1.Name = "panel1";
			panel1.Size = new Size(692, 724);
			panel1.TabIndex = 2;
			// 
			// txtGetById
			// 
			txtGetById.Location = new Point(122, 592);
			txtGetById.Name = "txtGetById";
			txtGetById.Size = new Size(439, 27);
			txtGetById.TabIndex = 10;
			// 
			// btnGetById
			// 
			btnGetById.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnGetById.Location = new Point(122, 496);
			btnGetById.Name = "btnGetById";
			btnGetById.Size = new Size(439, 61);
			btnGetById.TabIndex = 9;
			btnGetById.Text = "ID'ye Göre Getir";
			btnGetById.UseVisualStyleBackColor = true;
			btnGetById.Click += btnGetById_Click;
			// 
			// lblFeedbackProcess
			// 
			lblFeedbackProcess.AutoSize = true;
			lblFeedbackProcess.BackColor = Color.FromArgb(253, 114, 114);
			lblFeedbackProcess.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblFeedbackProcess.Location = new Point(144, 9);
			lblFeedbackProcess.Name = "lblFeedbackProcess";
			lblFeedbackProcess.Size = new Size(431, 54);
			lblFeedbackProcess.TabIndex = 8;
			lblFeedbackProcess.Text = "Geri Bildirim İşlemleri\r\n";
			// 
			// btnDelete
			// 
			btnDelete.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnDelete.Location = new Point(122, 410);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(439, 63);
			btnDelete.TabIndex = 7;
			btnDelete.Text = "SİL";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnUpdate.Location = new Point(122, 330);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(439, 65);
			btnUpdate.TabIndex = 6;
			btnUpdate.Text = "GÜNCELLE";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnAdd.Location = new Point(122, 249);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(439, 66);
			btnAdd.TabIndex = 5;
			btnAdd.Text = "EKLE";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// lblProcess
			// 
			lblProcess.AutoSize = true;
			lblProcess.BackColor = Color.FromArgb(214, 162, 232);
			lblProcess.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblProcess.Location = new Point(37, 82);
			lblProcess.Name = "lblProcess";
			lblProcess.Size = new Size(605, 54);
			lblProcess.TabIndex = 4;
			lblProcess.Text = "Yapılmak İstenen İşlemi Seçiniz";
			// 
			// btnList
			// 
			btnList.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnList.Location = new Point(122, 171);
			btnList.Name = "btnList";
			btnList.Size = new Size(439, 60);
			btnList.TabIndex = 3;
			btnList.Text = "LİSTELE";
			btnList.UseVisualStyleBackColor = true;
			btnList.Click += btnList_Click;
			// 
			// FeedbackDashboard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1404, 736);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FeedbackDashboard";
			Text = "FeedbackDashboard";
			Load += FeedbackDashboard_Load;
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Label lblDataScreen;
		private DataGridView dataGridView1;
		private Panel panel1;
		private TextBox txtGetById;
		private Button btnGetById;
		private Label lblFeedbackProcess;
		private Button btnDelete;
		private Button btnUpdate;
		private Button btnAdd;
		private Label lblProcess;
		private Button btnList;
	}
}