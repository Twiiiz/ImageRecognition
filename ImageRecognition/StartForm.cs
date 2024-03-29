﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRecognition
{
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
			this.MaximumSize = new Size(this.Width, this.Height);
			this.MinimumSize = new Size(this.Width, this.Height);
		}

		public static int numImage;

		private void button1_Click(object sender, EventArgs e)
		{
			bool isNum = Int32.TryParse(textBox1.Text, out numImage);
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Please, enter a Number.", "Error");
			}
			else if (!isNum)
			{
				MessageBox.Show("Invalid Format. Please, try again.", "Error");
			}
			else
			{
				LearnForm learn = new LearnForm();
				this.Hide();
				learn.Show();
			}
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do You want to Quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			bool isNum = Int32.TryParse(textBox1.Text, out numImage);
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Please, enter a Number.", "Error");
			}
			else if (!isNum)
			{
				MessageBox.Show("Invalid Format. Please, try again.", "Error");
			}
			else
			{
				TestForm testForm = new TestForm();
				this.Hide();
				testForm.Show();
			}
		}

	}
}
