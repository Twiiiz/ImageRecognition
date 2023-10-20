using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImageRecognition
{
	public partial class LearnForm : Form
	{
		public LearnForm()
		{
			InitializeComponent();
			this.MaximumSize = new Size(this.Width, this.Height);
			this.MinimumSize = new Size(this.Width, this.Height);
			imageNum = StartForm.numImage;
			learn_inputs.Clear();
		}

		Perceptron perceptron;
		public int imageNum;
		public double learn_rate;
		public int iterations;
		public static List<double[]> learn_inputs = new List<double[]>();
		public static double[,] weights_input_hidden;
		public static double[,] weights_hidden_output;
		bool hasLearned = false;
		Bitmap image;


		private void BackButton_Click(object sender, EventArgs e)
		{
			StartForm startForm = new StartForm();
			this.Close();
			startForm.Show();
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			if (!hasLearned)
			{
				MessageBox.Show("Can't go further. Model is not trained.", "Wait...");
			}
			else
			{
				RecognitionForm recognitionForm = new RecognitionForm();
				this.Close();
				recognitionForm.Show();
			}
		}

		private void LoadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				try
				{
					image = new Bitmap(openFileDialog1.FileName);
					pictureBox1.Image = image;
				}
				catch (IOException)
				{
					MessageBox.Show("Invalid image format. Please, try again.", "Error");
				}
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (learn_inputs.Count >= imageNum)
			{
				MessageBox.Show($"You already reached max number of classes - {learn_inputs.Count()}.", "Error");
				pictureBox1.Image = null;
			}
			else if (pictureBox1.Image == null)
			{
				MessageBox.Show("No Image to Load.", "Error");
			}
			else
			{
				image = ImageResizer.Resize(image, pictureBox1.Width / 6, pictureBox1.Height / 6);
				int[,] picture_pixels = new int[image.Width, image.Height];
				for (int row = 0; row < image.Width; row++)
				{

					for (int column = 0; column < image.Height; column++)
					{

						var colorValue = image.GetPixel(row, column);

						var averageValue = ((int)colorValue.R + (int)colorValue.B + (int)colorValue.G) / 3;
						if (averageValue < 150)
						{
							picture_pixels[row, column] = 1;
							image.SetPixel(row, column, Color.Black);
						}
						if (averageValue >= 150)
						{
							picture_pixels[row, column] = -1;
							image.SetPixel(row, column, Color.White);
						}
					}

				}
				pictureBox1.Image = image;

				List<double> vector = new List<double>();
				for (int x = 0; x < picture_pixels.GetLength(0); x++)
				{
					for (int y = 0; y < picture_pixels.GetLength(1); y++)
					{
						vector.Add(picture_pixels[x, y]);
					}
				}
				learn_inputs.Add(vector.ToArray());
				MessageBox.Show($"Image has been added. Total Image Number: {learn_inputs.Count()}");
			}
		}

		private void LearnButton_Click(object sender, EventArgs e)
		{
			bool IsNum = Double.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out learn_rate);
			if (!IsNum | learn_rate >= 1 | learn_rate <= 0)
			{
				MessageBox.Show("Invalid format. Please, try again.", "Error");
			}
			else if (iterations == 0)
			{
				MessageBox.Show("Select Number of learning iterations.", "Error");
			}
			else if (learn_inputs.Count() < imageNum)
			{
				MessageBox.Show("Not enough images to start learning.", "Error");
			}
			else
			{
				MessageBox.Show("Wait until message about learning completion.");
				perceptron = new Perceptron(learn_inputs[0].Length, (learn_inputs[0].Length + learn_inputs.Count()) / 2, learn_inputs.Count());
				List<double[]> desired_outputs = new List<double[]>();
				for (int i = 0; i < learn_inputs.Count(); i++)
				{
					double[] desired_output = new double[learn_inputs.Count()];
					for (int j = 0; j < desired_output.Length; j++)
					{
						desired_output[j] = 0;
						if (j == i)
						{
							desired_output[j] = 1;
						}
					}
					desired_outputs.Add(desired_output);
				}
				perceptron.Train(learn_inputs, desired_outputs, learn_rate, iterations);
				weights_input_hidden = perceptron.weightsInputHidden;
				weights_hidden_output = perceptron.weightsHiddenOutput;
				MessageBox.Show("Model has learned successfully.", "Result");
				hasLearned = true;
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			iterations = 1000;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			iterations = 5000;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			iterations = 1000;
		}

	}
}
