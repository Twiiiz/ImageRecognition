namespace ImageRecognition
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.Location = new System.Drawing.Point(180, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(165, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(180, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(165, 46);
			this.button1.TabIndex = 1;
			this.button1.Text = "Create and Teach Model";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(180, 210);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(165, 46);
			this.button2.TabIndex = 2;
			this.button2.Text = "Test Model Efficiency";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(180, 308);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(165, 46);
			this.button3.TabIndex = 3;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(71, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(403, 29);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter Number of classes for a model";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 378);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Start";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
	}
}

