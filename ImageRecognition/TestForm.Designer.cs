namespace ImageRecognition
{
	partial class TestForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SetButton1 = new System.Windows.Forms.Button();
			this.SelectButton1 = new System.Windows.Forms.Button();
			this.SelectButton = new System.Windows.Forms.Button();
			this.SetButton2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.ReturnButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.TestButton = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(63, 84);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(133, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.Location = new System.Drawing.Point(23, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Number of images per class";
			// 
			// SetButton1
			// 
			this.SetButton1.Location = new System.Drawing.Point(63, 127);
			this.SetButton1.Name = "SetButton1";
			this.SetButton1.Size = new System.Drawing.Size(133, 28);
			this.SetButton1.TabIndex = 2;
			this.SetButton1.Text = "Set";
			this.SetButton1.UseVisualStyleBackColor = true;
			this.SetButton1.Click += new System.EventHandler(this.SetButton1_Click);
			// 
			// SelectButton1
			// 
			this.SelectButton1.Location = new System.Drawing.Point(63, 194);
			this.SelectButton1.Name = "SelectButton1";
			this.SelectButton1.Size = new System.Drawing.Size(133, 55);
			this.SelectButton1.TabIndex = 3;
			this.SelectButton1.Text = "Choose a root folder for learning class";
			this.SelectButton1.UseVisualStyleBackColor = true;
			this.SelectButton1.Click += new System.EventHandler(this.SelectButton1_Click);
			// 
			// SelectButton
			// 
			this.SelectButton.Location = new System.Drawing.Point(63, 279);
			this.SelectButton.Name = "SelectButton";
			this.SelectButton.Size = new System.Drawing.Size(133, 55);
			this.SelectButton.TabIndex = 4;
			this.SelectButton.Text = "Choose a root folder for images you want to recognise";
			this.SelectButton.UseVisualStyleBackColor = true;
			this.SelectButton.Click += new System.EventHandler(this.SelectButton2_Click);
			// 
			// SetButton2
			// 
			this.SetButton2.Location = new System.Drawing.Point(63, 420);
			this.SetButton2.Name = "SetButton2";
			this.SetButton2.Size = new System.Drawing.Size(133, 28);
			this.SetButton2.TabIndex = 7;
			this.SetButton2.Text = "Set";
			this.SetButton2.UseVisualStyleBackColor = true;
			this.SetButton2.Click += new System.EventHandler(this.SetButton2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label2.Location = new System.Drawing.Point(23, 359);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(204, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Recognisable images class number";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(63, 377);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(133, 20);
			this.textBox2.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Location = new System.Drawing.Point(569, 47);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(361, 182);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Learning Parameters";
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radioButton3.Location = new System.Drawing.Point(49, 128);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(60, 19);
			this.radioButton3.TabIndex = 5;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "10000";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radioButton2.Location = new System.Drawing.Point(49, 95);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(53, 19);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "5000";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.radioButton1.Location = new System.Drawing.Point(49, 61);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(53, 19);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "1000";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(6, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Number of Learning Iterations";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(221, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Learning Coefficient";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(238, 92);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(569, 247);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(361, 108);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// ReturnButton
			// 
			this.ReturnButton.Location = new System.Drawing.Point(683, 361);
			this.ReturnButton.Name = "ReturnButton";
			this.ReturnButton.Size = new System.Drawing.Size(163, 50);
			this.ReturnButton.TabIndex = 10;
			this.ReturnButton.Text = "Return to Start";
			this.ReturnButton.UseVisualStyleBackColor = true;
			this.ReturnButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(683, 421);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(163, 50);
			this.ExitButton.TabIndex = 11;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(268, 142);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 306);
			this.dataGridView1.TabIndex = 12;
			// 
			// TestButton
			// 
			this.TestButton.Location = new System.Drawing.Point(290, 84);
			this.TestButton.Name = "TestButton";
			this.TestButton.Size = new System.Drawing.Size(197, 43);
			this.TestButton.TabIndex = 13;
			this.TestButton.Text = "Test";
			this.TestButton.UseVisualStyleBackColor = true;
			this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Image Number";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Similarity with recognised image";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(942, 483);
			this.Controls.Add(this.TestButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ReturnButton);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.SetButton2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.SelectButton);
			this.Controls.Add(this.SelectButton1);
			this.Controls.Add(this.SetButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "TestForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestForm";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SetButton1;
		private System.Windows.Forms.Button SelectButton1;
		private System.Windows.Forms.Button SelectButton;
		private System.Windows.Forms.Button SetButton2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button ReturnButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button TestButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
	}
}