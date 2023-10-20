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
using static System.Net.Mime.MediaTypeNames;

namespace ImageRecognition
{
	public partial class LearnForm : Form
	{
		public LearnForm()
		{
			InitializeComponent();
			imageNum = StartForm.numImage;
			learn_inputs.Clear();
		}

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
				MessageBox.Show("Перехід далі заборонено. Модель мережі не була навчена.", "Стривайте");
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
					MessageBox.Show("Сталася помилка при відкритті зображення. Будь-ласка, спробуйте ще раз.", "Помилка");
				}
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (learn_inputs.Count >= imageNum)
			{
				MessageBox.Show($"Кількість записаних образів уже досягла заданого значення - {learn_inputs.Count()}.", "Помилка");
				pictureBox1.Image = null;
			}
			else if (pictureBox1.Image == null)
			{
				MessageBox.Show("Відсутнє зображення для запису. Будь-ласка, завантажте образ.", "Помилка");
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
				MessageBox.Show($"Образ записано. Всього образів записано: {learn_inputs.Count()}");
			}
		}

	}
}
