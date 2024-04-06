using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton2_Click(object sender, EventArgs e)
        {
            ResultLabel2.Text = string.Empty;

            string[] inputLines = textBox2DArray.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string[,] array2D = new string[inputLines.Length, inputLines[0].Split(' ').Length];

            for (int i = 0; i < inputLines.Length; i++)
            {
                string[] values = inputLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < values.Length; j++)
                {
                    array2D[i, j] = values[j];
                }
            }

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    ResultLabel2.Text += $"{array2D[i, j]} ";
                }
                ResultLabel2.Text += "\n";
            }

            double upperLeftCorner = double.Parse(array2D[0, 0]); // 1
            double upperRightCorner = double.Parse(array2D[0, array2D.GetLength(1) - 1]);

            if (upperLeftCorner > upperRightCorner)
            {
                ResultLabel2.Text += $"Елемент у верхньому лівому куті ({upperLeftCorner}) більший за елемент у верхньому правому куті ({upperRightCorner}).\n";
            }
            else if (upperLeftCorner < upperRightCorner)
            {
                ResultLabel2.Text += $"Елемент у верхньому правому куті ({upperRightCorner}) більший за елемент у верхньому лівому куті ({upperLeftCorner}).\n";
            }
            else
            {
                ResultLabel2.Text += $"Елементи у верхньому лівому та верхньому правому кутах однакові ({upperLeftCorner}).\n";
            }

            double lowerRightCorner = double.Parse(array2D[array2D.GetLength(0) - 1, array2D.GetLength(1) - 1]); 
            if (lowerRightCorner < upperLeftCorner)
            {
                ResultLabel2.Text += $"Елемент у нижньому правому куті ({lowerRightCorner}) менший за елемент у верхньому лівому куті ({upperLeftCorner}).\n";
            }
            else if (lowerRightCorner > upperLeftCorner)
            {
                ResultLabel2.Text += $"Елемент у верхньому лівому куті ({upperLeftCorner}) менший за елемент у нижньому правому куті ({lowerRightCorner}).\n ";
            }
            else
            {
                ResultLabel2.Text += $"Елементи у нижньому правому та верхньому лівому кутах однакові ({lowerRightCorner}).\n";
            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            double[] array = textBoxArray.Text.Split(' ').Select(x => double.Parse(x)).ToArray();

            double max = array.Max();
            double sum = 0;

            for(int i =0; i<array.Length-1; i++)
            {
                sum += array[i];
            }

            int n = array.Length;

            bool InRange(double x)
            {
                double absX = Math.Abs(x);
                return absX >= 20 && absX <= 50;
            }

            int countToRemove = 0;
            for (int i = 0; i < n; i++)
            {
                if (InRange(array[i]))
                {
                    countToRemove++;
                }
            }

            ResultLabel.Text += $"Максимальний елемент масиву : {max}\n";
            ResultLabel.Text += $"Сума елементів до останього елемента : {sum}\n";

            double[] newArr = new double[n - countToRemove];
            int j = 0; 

            for (int i = 0; i < n; i++)
            {
                if (!InRange(array[i]))
                {
                    newArr[j] = array[i];
                    j++;
                }
            }
            for (int i = j; i < newArr.Length; i++)
            {
                newArr[i] = 0;
            }

            Console.WriteLine("Новий стиснутий масив:");
            foreach (int x in newArr)
            {
                ResultLabel.Text += $"{x} ";
            }
            ResultLabel.Text +="\n";
        }
    } 
}
