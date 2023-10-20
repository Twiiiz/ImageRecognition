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

namespace ImageRecognition
{
	public partial class TestForm : Form
	{
		public TestForm()
		{
			InitializeComponent();
			images_path.Clear();
			recogn_images_path.Clear();
			classNum = StartForm.numImage;
			imageNum = 0;
			recogn_num = 0;
			setNum = false;
		}

		List<string[]> images_path = new List<string[]>();
		List<string> recogn_images_path = new List<string>();
		string[] imageExtensions = new string[] { ".png", ".jpg", ".jpeg", ".bmp" };

		int classNum;
		int imageNum;
		int recogn_num;
		double learn_rate;
		int iterations;

		bool setNum = false;

		private void SelectButton1_Click(object sender, EventArgs e)
		{
			if (images_path.Count() >= classNum)
			{
				MessageBox.Show("All Folders are already selected.", "Error");
			}
			else
			{
				FolderBrowserDialog dialog = new FolderBrowserDialog();
				DialogResult result = dialog.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrEmpty(dialog.SelectedPath))
				{
					if (!setNum)
					{
						MessageBox.Show("Number of images per learning class has not been set.", "Error");
					}
					else
					{
						List<string> temp = new List<string>();
						int count = 0;
						foreach (string path in Directory.GetFiles(dialog.SelectedPath))
						{
							if (imageExtensions.Any(path.Contains) && count < imageNum)
							{
								temp.Add(path);
							}
							count++;
						}

						if (temp.Count == 0)
						{
							MessageBox.Show("This folder doesn't contain images", "Error");
						}
						else if (temp.Count < imageNum)
						{
							MessageBox.Show("This folder doesn't contain enough images", "Error");
						}
						else
						{
							images_path.Add(temp.ToArray());
							MessageBox.Show($"Image folder of {images_path.Count()} class has been set", "Success");
						}
					}
				}
			}
		}

		private void SetButton1_Click(object sender, EventArgs e)
		{
			bool isNum = Int32.TryParse(textBox1.Text, out imageNum);
			if (!isNum)
			{
				MessageBox.Show("Invalid Format. Please, try again", "Error");
			}
			else
			{
				setNum = true;
				MessageBox.Show("Number of images per learning class has been set.", "Success");
			}
		}

		private void SetButton2_Click(object sender, EventArgs e)
		{
			bool isNum = Int32.TryParse(textBox2.Text, out recogn_num);
			if (!isNum)
			{
				MessageBox.Show("Invalid Format.", "Error");
			}
			else if (recogn_num > classNum)
			{
				MessageBox.Show($"Class {recogn_num} doesn't exist.", "Error");
			}
			else
			{
				setNum = true;
				MessageBox.Show("Class of recognisable images has been set.", "Success");
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
			iterations = 10000;
		}

		private void TestButton_Click(object sender, EventArgs e)
		{
			bool IsNum = Double.TryParse(textBox3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out learn_rate);
			if (!IsNum | learn_rate >= 1 | learn_rate <= 0)
			{
				MessageBox.Show("Invalid Format. Please, try again", "Error");
			}
			else if (iterations == 0)
			{
				MessageBox.Show("Choose number of learning iterations.", "Error");
			}
			else if (images_path.Count() < classNum)
			{
				MessageBox.Show("Not all learning classes have assigned folder.", "Error");
			}
			else if (recogn_images_path.Count() == 0)
			{
				MessageBox.Show("Recognisable images don't have an assigned folder.", "Error");
			}
			else
			{
				MessageBox.Show("Wait until you recieve message about testing completion.");
				double[] total_results = new double[imageNum];
				Bitmap image;
				Perceptron perceptron;
				List<double[]> learn_inputs = new List<double[]>();
				List<double[]> outputs = new List<double[]>();
				for (int i = 0; i < imageNum; i++)
				{
					foreach (string[] pictures in images_path)
					{
						image = new Bitmap(pictures[i]);
						image = ImageResizer.Resize(image, 40, 20);
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
						List<double> vector = new List<double>();
						for (int x = 0; x < picture_pixels.GetLength(0); x++)
						{
							for (int y = 0; y < picture_pixels.GetLength(1); y++)
							{
								vector.Add(picture_pixels[x, y]);
							}
						}
						learn_inputs.Add(vector.ToArray());
					}

					perceptron = new Perceptron(learn_inputs[0].Length, (learn_inputs[0].Length + learn_inputs.Count()) / 2, learn_inputs.Count());
					List<double[]> desired_outputs = new List<double[]>();
					for (int n = 0; n < learn_inputs.Count(); n++)
					{
						double[] desired_output = new double[learn_inputs.Count()];
						for (int j = 0; j < desired_output.Length; j++)
						{
							desired_output[j] = 0;
							if (j == n)
							{
								desired_output[j] = 1;
							}
						}
						desired_outputs.Add(desired_output);
					}
					perceptron.Train(learn_inputs, desired_outputs, learn_rate, iterations);

					image = new Bitmap(recogn_images_path[i]);
					image = ImageResizer.Resize(image, 40, 20);
					int[,] picture_pixels2 = new int[image.Width, image.Height];
					for (int row = 0; row < image.Width; row++)
					{

						for (int column = 0; column < image.Height; column++)
						{

							var colorValue = image.GetPixel(row, column);

							var averageValue = ((int)colorValue.R + (int)colorValue.B + (int)colorValue.G) / 3;
							if (averageValue < 150)
							{
								picture_pixels2[row, column] = 1;
								image.SetPixel(row, column, Color.Black);
							}
							if (averageValue >= 150)
							{
								picture_pixels2[row, column] = -1;
								image.SetPixel(row, column, Color.White);
							}
						}

					}
					List<double> vector2 = new List<double>();
					for (int x = 0; x < picture_pixels2.GetLength(0); x++)
					{
						for (int y = 0; y < picture_pixels2.GetLength(1); y++)
						{
							vector2.Add(picture_pixels2[x, y]);
						}
					}
					double[] recognition_input = vector2.ToArray();

					double[] recognition_outputs = perceptron.Predict(recognition_input);
					outputs.Add(recognition_outputs);
					total_results[i] = recognition_outputs[recogn_num - 1];
					learn_inputs.Clear();
				}

				MessageBox.Show("Testing has been completed.");
				dataGridView1.Rows.Add($"Recognition #1");
				for (int i = 0; i < outputs.Count(); i++)
				{
					string[] results = new string[outputs[i].Length];
					for (int n = 0; n < results.Length; n++)
					{
						string temp = outputs[i][n].ToString();
						if (temp.Contains("E"))
						{
							results[n] = outputs[i][n].ToString("E3");
						}
						else
						{
							results[n] = temp;
						}
					}
					int count = 0;
					for (int j = 0; j < outputs[i].Length; j++)
					{
						dataGridView1.Rows.Add(j + 1, results[j]);
						count++;
						if (count % classNum == 0 && i != outputs.Count() - 1)
						{
							dataGridView1.Rows.Add($"Recognition #{i + 2}");
						}
					}
				}
				int count2 = 0;
				for (int i = 0; i < total_results.Length; i++)
				{
					if (total_results[i] > 0.8)
					{
						count2++;
					}
				}
				double grade = ((double)count2 / total_results.Length) * 100.00;
				richTextBox1.Text = $"За результатами тестування виявлено, що кількість вдалих спроб розпізнавання - {count2}," +
					$" а кількість невдалих - {imageNum - count2}. Це означає, що точність роботи нейронної мережі перцептрон у даному тестуванні складає {grade}%.";
			}
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ви дійсно хочете закрити програму?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			StartForm startForm = new StartForm();
			this.Close();
			startForm.Show();
		}

		private void SelectButton2_Click(object sender, EventArgs e)
		{
			if (recogn_images_path.Count() != 0)
			{
				MessageBox.Show("Папку з образами для розпізнавання уже було обрано.", "Помилка");
			}
			else
			{
				if (!setNum)
				{
					MessageBox.Show("Не встановлено кількість образів у класах.", "Помилка");
				}
				else
				{
					if (recogn_num == 0)
					{
						MessageBox.Show("Не обрано клас, до якого відносити зображення для розпізнавання.", "Помилка");
					}
					else
					{
						FolderBrowserDialog dialog = new FolderBrowserDialog();
						DialogResult result = dialog.ShowDialog();
						if (result == DialogResult.OK && !string.IsNullOrEmpty(dialog.SelectedPath))
						{
							List<string> temp = new List<string>();
							int count = 0;
							foreach (string path in Directory.GetFiles(dialog.SelectedPath))
							{
								if (imageExtensions.Any(path.Contains) && count < imageNum)
								{
									temp.Add(path);
								}
								count++;
							}

							if (temp.Count == 0)
							{
								MessageBox.Show("Дана папка не містить зображень. Будь-ласка, спробуйте ще раз", "Помилка");
							}
							else if (temp.Count < imageNum)
							{
								MessageBox.Show("Дана папка не має достатньої кількості зображень.", "Помилка");
							}
							else
							{
								recogn_images_path = temp;
								MessageBox.Show($"Number of images for recognisable class has been set.", "Success");
							}
						}
					}
				}
			}

		}
	}
}
