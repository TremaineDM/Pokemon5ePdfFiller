namespace Pokemon5ePdfFiller
{
	partial class Pokemon5ePDFFiller
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			BrowseButton = new Button();
			textBox1 = new TextBox();
			CreatePdf = new Button();
			button1 = new Button();
			openFileDialog1 = new OpenFileDialog();
			label1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// BrowseButton
			// 
			BrowseButton.Location = new Point(258, 148);
			BrowseButton.Name = "BrowseButton";
			BrowseButton.Size = new Size(75, 23);
			BrowseButton.TabIndex = 0;
			BrowseButton.Text = "Browse...";
			BrowseButton.UseVisualStyleBackColor = true;
			BrowseButton.Click += BrowseButton_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(355, 148);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(370, 23);
			textBox1.TabIndex = 1;
			// 
			// CreatePdf
			// 
			CreatePdf.Dock = DockStyle.Fill;
			CreatePdf.Location = new Point(3, 3);
			CreatePdf.Name = "CreatePdf";
			CreatePdf.Size = new Size(194, 44);
			CreatePdf.TabIndex = 2;
			CreatePdf.Text = "Create PDF";
			CreatePdf.UseVisualStyleBackColor = true;
			CreatePdf.Click += CreatePdf_Click;
			// 
			// button1
			// 
			button1.Location = new Point(0, 0);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "Json files|*.json";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(3, 50);
			label1.Name = "label1";
			label1.Size = new Size(194, 50);
			label1.TabIndex = 6;
			label1.Text = "\"\"";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(CreatePdf, 0, 0);
			tableLayoutPanel1.Controls.Add(label1, 0, 1);
			tableLayoutPanel1.Location = new Point(373, 417);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(200, 100);
			tableLayoutPanel1.TabIndex = 7;
			// 
			// Pokemon5ePDFFiller
			// 
			ClientSize = new Size(922, 529);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(BrowseButton);
			Controls.Add(textBox1);
			Name = "Pokemon5ePDFFiller";
			Text = "Pokemon5ePDFFiller";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button BrowseButton;
		private TextBox textBox1;
		private Button CreatePdf;
		private Button button1;
		private OpenFileDialog openFileDialog1;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
	}
}