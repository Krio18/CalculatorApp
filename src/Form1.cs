using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator.App
{
    public partial class Form1 : Form
    {
        private double total = 0;
        private int index = 0;
        private bool isResults = false;
        private string[] Signe { get; set; }
        private string[] Current { get; set; }
        public Form1()
        {
            InitializeComponent();
            Current = new string[100];
            Signe = new string[100];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EqualButtonClick(object sender, EventArgs e)
        {
            Current[index] = textBox1.Text;
            textBox1.Clear();
            total = TotalCalculator();
            textBox1.Text += total;
            isResults = true;
            total = 0;
            index = 0;
        }
        #region imput operation
        private void CancelButtonClick(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void PlusButtonClick(object sender, EventArgs e)
        {
            Current[index] = textBox1.Text;
            Signe[index] = "+";
            textBox1.Clear();
            index++;
        }

        private void SubButtonClick(object sender, EventArgs e)
        {
            Current[index] = textBox1.Text;
            Signe[index] = "-";
            textBox1.Clear();
            index++;
        }

        private void DivideButtonClick(object sender, EventArgs e)
        {
            Current[index] = textBox1.Text;
            Signe[index] = "/";
            textBox1.Clear();
            index++;
        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            Current[index] = textBox1.Text;
            Signe[index] = "*";
            textBox1.Clear();
            index++;
        }

        #region imput nbr

        private void ZeroButtonClick(object sender, EventArgs e)
        {
            int nbr = 0;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            Console.WriteLine(nbr);
            textBox1.Text += nbr;
        }

        private void OneButtonClick(object sender, EventArgs e)
        {
            int nbr = 1;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        private void TwoButtonClick(object sender, EventArgs e)
        {
            int nbr = 2;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        private void ThreeButtonClick(object sender, EventArgs e)
        {
            int nbr = 3;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        private void FourButtonClick(object sender, EventArgs e)
        {
            int nbr = 4;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        private void FiveButtonClick(object sender, EventArgs e)
        {
            int nbr = 5;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        private void SixButtonClick(object sender, EventArgs e)
        {
            int nbr = 6;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        private void SevenButtonClick(object sender, EventArgs e)
        {
            int nbr = 7;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        private void EightButtonClick(object sender, EventArgs e)
        {
            int nbr = 8;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        private void NineButtonClick(object sender, EventArgs e)
        {
            int nbr = 9;

            if (isResults)
            {
                textBox1.Clear();
                isResults = false;
            }

            textBox1.Text += nbr;
        }

        #endregion imput nbr

        private void Display(object sender, EventArgs e)
        {

        }

        #endregion imput operation

        private double TotalCalculator()
        {
            total = Convert.ToInt32(Current[0]);

            for (int i = 1, j = 0; i <= index; i++, j++)
            {
                double nbr = Convert.ToDouble(Current[i]);
                switch (Signe[j])
                {
                    case "+":
                        total += nbr;
                        break;
                    case "-":
                        total -= nbr;
                        break;
                    case "*":
                        total *= nbr;
                        break;
                    case "/":
                        total /= nbr;
                        break;
                    default:
                        break;
                }
            }
            return total;
        }

        private void Debug(object sender, EventArgs e)
        {

        }
    }
}
