using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition
{
	internal class Perceptron
	{
		private readonly int numInputNeurons;
		private readonly int numHiddenNeurons;
		private readonly int numOutputNeurons;

		public double[,] weightsInputHidden;
		public double[,] weightsHiddenOutput;

		public Perceptron(int numInputNeurons, int numHiddenNeurons, int numOutputNeurons)
		{
			this.numInputNeurons = numInputNeurons;
			this.numHiddenNeurons = numHiddenNeurons;
			this.numOutputNeurons = numOutputNeurons;

			weightsInputHidden = new double[numInputNeurons, numHiddenNeurons];
			weightsHiddenOutput = new double[numHiddenNeurons, numOutputNeurons];

			Random random = new Random();
			for (int i = 0; i < numInputNeurons; i++)
			{
				for (int j = 0; j < numHiddenNeurons; j++)
				{
					weightsInputHidden[i, j] = random.NextDouble() - 0.5;
				}
			}
			for (int i = 0; i < numHiddenNeurons; i++)
			{
				for (int j = 0; j < numOutputNeurons; j++)
				{
					weightsHiddenOutput[i, j] = random.NextDouble() - 0.5;
				}
			}
		}

		public double[] Predict(double[] input)
		{
			double[] hidden = new double[numHiddenNeurons];
			double[] output = new double[numOutputNeurons];

			for (int j = 0; j < numHiddenNeurons; j++)
			{
				double sum = 0;
				for (int i = 0; i < numInputNeurons; i++)
				{
					sum += input[i] * weightsInputHidden[i, j];
				}
				hidden[j] = Sigmoid(sum);
			}

			for (int j = 0; j < numOutputNeurons; j++)
			{
				double sum = 0;
				for (int i = 0; i < numHiddenNeurons; i++)
				{
					sum += hidden[i] * weightsHiddenOutput[i, j];
				}
				output[j] = Math.Exp(sum);
			}

			double sumExp = output.Sum();
			for (int j = 0; j < numOutputNeurons; j++)
			{
				output[j] /= sumExp;
			}

			return output;
		}

		public void Train(List<double[]> inputs, List<double[]> desiredOutputs, double learningRate, int numIterations)
		{
			int numTrainingData = inputs.Count;
			int inputSize = inputs[0].Length;
			int outputSize = desiredOutputs[0].Length;
			double[] input = new double[inputSize];
			double[] hidden = new double[numHiddenNeurons];
			double[] output = new double[outputSize];
			double[] desiredOutput = new double[outputSize];
			double[] outputError = new double[outputSize];
			double[] hiddenError = new double[numHiddenNeurons];

			for (int iteration = 0; iteration < numIterations; iteration++)
			{
				double error = 0;

				for (int i = 0; i < numTrainingData; i++)
				{
					// Копіювання значень входів та виходів зі списків у масиви
					input = inputs[i];
					desiredOutput = desiredOutputs[i];

					// обрахування виходів мережі методом пропуску входів через мережу
					for (int j = 0; j < numHiddenNeurons; j++)
					{
						double sum = 0;
						for (int k = 0; k < inputSize; k++)
						{
							sum += input[k] * weightsInputHidden[k, j];
						}
						hidden[j] = Sigmoid(sum);
					}
					for (int j = 0; j < outputSize; j++)
					{
						double sum = 0;
						for (int k = 0; k < numHiddenNeurons; k++)
						{
							sum += hidden[k] * weightsHiddenOutput[k, j];
						}
						output[j] = Math.Exp(sum);
					}

					double sumExp = output.Sum();
					for (int j = 0; j < outputSize; j++)
					{
						output[j] /= sumExp;
					}

					// обрахування помилки та оновлення ваг синапсів
					for (int j = 0; j < outputSize; j++)
					{
						outputError[j] = output[j] - desiredOutput[j];
						error += 0.5 * Math.Pow(outputError[j], 2);
					}

					if (error <= 0.2)
					{
						break;
					}

					for (int j = 0; j < numHiddenNeurons; j++)
					{
						double sum = 0;
						for (int k = 0; k < outputSize; k++)
						{
							sum += outputError[k] * weightsHiddenOutput[j, k];
						}
						hiddenError[j] = hidden[j] * (1 - hidden[j]) * sum;
					}

					for (int j = 0; j < numOutputNeurons; j++)
					{
						for (int k = 0; k < numHiddenNeurons; k++)
						{
							weightsHiddenOutput[k, j] -= learningRate * outputError[j] * hidden[k];
						}
					}

					for (int j = 0; j < numHiddenNeurons; j++)
					{
						for (int k = 0; k < inputSize; k++)
						{
							weightsInputHidden[k, j] -= learningRate * hiddenError[j] * input[k];
						}
					}
				}
			}
		}

		private static double Sigmoid(double x)
		{
			return 1.0 / (1.0 + Math.Exp(-x));
		}

		public void SetWeights(double[,] weights_input_hidden, double[,] weights_hidden_output)
		{
			weightsInputHidden = weights_input_hidden;
			weightsHiddenOutput = weights_hidden_output;
		}
	}

}
