using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRecognition
{
	public partial class RecognitionForm : Form
	{
		public RecognitionForm()
		{
			InitializeComponent();
			this.MaximumSize = new Size(this.Width, this.Height);
			this.MinimumSize = new Size(this.Width, this.Height);

			perceptron = new Perceptron(LearnForm.learn_inputs[0].Length,
				(LearnForm.learn_inputs[0].Length + LearnForm.learn_inputs.Count()) / 2,
				LearnForm.learn_inputs.Count());
			perceptron.weightsInputHidden = LearnForm.weights_input_hidden;
			perceptron.weightsHiddenOutput = LearnForm.weights_hidden_output;

		}

		Perceptron perceptron;
		Bitmap image;

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
					MessageBox.Show("Сталася помилка при відкритті зображення. Будь-ласка, спробуйте ще раз.", "Помилка");
				}
			}
		}

		private void RecognitionButton_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null)
			{
				MessageBox.Show("Відсутнє зображення для запису. Будь-ласка, завантежте образ.", "Помилка");
			}
			else
			{
				dataGridView1.Rows.Clear();

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
				double[] recognition_input = vector.ToArray();
				double[] recognition_outputs = perceptron.Predict(recognition_input);
				string[] results = new string[recognition_outputs.Length];
				for (int i = 0; i < results.Length; i++)
				{
					string temp = recognition_outputs[i].ToString();
					if (temp.Contains("E"))
					{
						results[i] = recognition_outputs[i].ToString("E3");
					}
					else
					{
						results[i] = temp;
					}
				}

				for (int i = 0; i < recognition_outputs.Length; i++)
				{
					dataGridView1.Rows.Add(i + 1, results[i]);
				}
				richTextBox1.Text = $"Conclusion: the recognized image can be assigned " +
					$"to image class {Array.IndexOf(recognition_outputs, recognition_outputs.Max()) + 1}, " +
					$"because it has the highest output value of the network model.";
			}
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			StartForm startForm = new StartForm();
			this.Close();
			startForm.Show();
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			TestForm testForm = new TestForm();
			this.Close();
			testForm.Show();
		}

	}
}
