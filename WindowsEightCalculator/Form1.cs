using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsEightCalculator
{
    public partial class Form1 : Form
    {
        String sign;
        string number;
        double firstNumber;
        double secondNumber;
        double store = 0, ceStore = 0, result = 0;


        public Form1()
        {
            InitializeComponent();
           
        }

        private void zeroNumberButton_Click(object sender, EventArgs e)
        {
            inputOutputTextBox.Text += zeroNumberButton.Text;
        }

        private void oneNumberButton_Click(object sender, EventArgs e)
        {      
            inputOutputTextBox.Text += oneNumberButton.Text;
        }

        private void twoNumberButton_Click(object sender, EventArgs e)
        {
            inputOutputTextBox.Text += twoNumberButton.Text;
        }

        private void threeNumberButton_Click(object sender, EventArgs e)
        {
            inputOutputTextBox.Text += threeNumberButton.Text;
        }

        private void fourNumberButton_Click(object sender, EventArgs e)
        {
            inputOutputTextBox.Text += fourNumberButton.Text;
        }

        private void fiveNumberButton_Click(object sender, EventArgs e)
        {
            inputOutputTextBox.Text += fiveNumberButton.Text;
        }

        private void sixNumberButton_Click(object sender, EventArgs e)
        {
           inputOutputTextBox.Text += sixNumberButton.Text;
        }

        private void sevenNumberButton_Click(object sender, EventArgs e)
        {
            inputOutputTextBox.Text += sevenNumberButton.Text;
        }

        private void eightNumberButton_Click(object sender, EventArgs e)
        {
            inputOutputTextBox.Text += eightNumberButton.Text;
        }

        private void nineNumberButton_Click(object sender, EventArgs e)
        {
            inputOutputTextBox.Text += nineNumberButton.Text;
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (inputOutputTextBox.Text.Contains('.'))
                inputOutputTextBox.Text = inputOutputTextBox.Text;
            else
                inputOutputTextBox.Text+= '.';
        }


        private void sumButton_Click(object sender, EventArgs e)
        {
            try
            {
                sign = "+";
                firstNumber = double.Parse(inputOutputTextBox.Text);
                inputOutputTextBox.Clear();
                topTextBox.Text = firstNumber.ToString() + "+";
            }
            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            try
            {
                sign = "-";
                firstNumber = double.Parse(inputOutputTextBox.Text);
                inputOutputTextBox.Clear();
                topTextBox.Text = firstNumber.ToString() + "-";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            try
            {
                sign = "*";
                firstNumber = double.Parse(inputOutputTextBox.Text);
                inputOutputTextBox.Text = "";
                topTextBox.Text = firstNumber.ToString() + "*";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            try
            {
                sign = "/";
                firstNumber = double.Parse(inputOutputTextBox.Text);
                inputOutputTextBox.Text = "";
                topTextBox.Text = firstNumber.ToString() + "/";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }
        private void modulasButton_Click(object sender, EventArgs e)
        {
            try
            {
                sign = "%";
                firstNumber = double.Parse(inputOutputTextBox.Text);
                inputOutputTextBox.Text = "";
                topTextBox.Text = firstNumber.ToString() + "%";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                secondNumber = double.Parse(inputOutputTextBox.Text);

                if (sign == "+")
                {
                    result = firstNumber + secondNumber;
                }

                else if (sign == "-")
                {
                    result = firstNumber - secondNumber;
                }

                else if (sign == "*")
                {
                    result = firstNumber * secondNumber;
                }

                else if (sign == "/")
                {
                    if (secondNumber == 0)
                        inputOutputTextBox.Text = "0.0";
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                }
                else if (sign == "%")
                {
                    result = firstNumber % secondNumber;
                }
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }

            inputOutputTextBox.Text = result.ToString();
            topTextBox.Text = "";
        }

        private void inverseButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = double.Parse(inputOutputTextBox.Text);
                store = 1 / firstNumber;
                inputOutputTextBox.Text = store.ToString();
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void squreRootButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = double.Parse(inputOutputTextBox.Text);
                store = Math.Sqrt(firstNumber);
                inputOutputTextBox.Text = store.ToString();
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void positiveNegativeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputOutputTextBox.Text.Contains("-"))
                {
                    inputOutputTextBox.Text = inputOutputTextBox.Text.Remove(0,1);
                }
                else
                    inputOutputTextBox.Text = "-" + inputOutputTextBox.Text;
            }
            catch (Exception)
            {
                inputOutputTextBox.Text = "Error !!";
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {

                inputOutputTextBox.Text = "";
                topTextBox.Text = "";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }

        }

        private void clearExpressionButton_Click(object sender, EventArgs e)
        {
            try
            {

                ceStore = result;
                inputOutputTextBox.Clear();
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (inputOutputTextBox.TextLength > 0)
            {
                inputOutputTextBox.Text = inputOutputTextBox.Text.Substring(0, inputOutputTextBox.TextLength - 1);
            }
        }  


        
        private void memorySetButton_Click(object sender, EventArgs e)
        {
            try
            {
                store = Convert.ToDouble(inputOutputTextBox.Text);
                memoryLabal.Text = "M";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void memoryReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                inputOutputTextBox.Clear();
                inputOutputTextBox.Text = store.ToString();
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }
        private void memoryClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                store = 0;
                memoryLabal.Text = "";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
        }

        private void memoryIncrementButton_Click(object sender, EventArgs e)
        {
            try
            {
                store = store + Convert.ToDouble(inputOutputTextBox.Text);
                memoryLabal.Text = "M";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }
          
        }

        private void memoryDecrementButton_Click(object sender, EventArgs e)
        {

            try
            {
                store = store - Convert.ToDouble(inputOutputTextBox.Text);
                memoryLabal.Text = "M";
            }

            catch (Exception)
            {
                inputOutputTextBox.Text = "Error!!";
            }

        }
        private void inputOutputTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void topTextBox_TextChanged(object sender, EventArgs e)
        {

        }
   
    }
}
