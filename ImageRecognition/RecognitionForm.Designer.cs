namespace ImageRecognition
{
	partial class RecognitionForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LoadButton = new System.Windows.Forms.Button();
			this.RecognitionButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Nextbutton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(21, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(321, 290);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(297, 254);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// LoadButton
			// 
			this.LoadButton.Location = new System.Drawing.Point(96, 358);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(163, 50);
			this.LoadButton.TabIndex = 2;
			this.LoadButton.Text = "Load Image";
			this.LoadButton.UseVisualStyleBackColor = true;
			// 
			// RecognitionButton
			// 
			this.RecognitionButton.Location = new System.Drawing.Point(96, 440);
			this.RecognitionButton.Name = "RecognitionButton";
			this.RecognitionButton.Size = new System.Drawing.Size(163, 50);
			this.RecognitionButton.TabIndex = 3;
			this.RecognitionButton.Text = "Recognise";
			this.RecognitionButton.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTextBox1);
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(405, 34);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(319, 366);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Result";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(65, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(192, 140);
			this.dataGridView1.TabIndex = 0;
			// 
			// Nextbutton
			// 
			this.Nextbutton.Location = new System.Drawing.Point(499, 406);
			this.Nextbutton.Name = "Nextbutton";
			this.Nextbutton.Size = new System.Drawing.Size(163, 50);
			this.Nextbutton.TabIndex = 5;
			this.Nextbutton.Text = "Go to Testing";
			this.Nextbutton.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(499, 472);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(163, 50);
			this.button3.TabIndex = 6;
			this.button3.Text = "Return";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(7, 186);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(306, 163);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// RecognitionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 545);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Nextbutton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.RecognitionButton);
			this.Controls.Add(this.LoadButton);
			this.Controls.Add(this.groupBox1);
			this.Name = "RecognitionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RecognitionForm";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button LoadButton;
		private System.Windows.Forms.Button RecognitionButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Nextbutton;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}