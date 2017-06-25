using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || (isOperationPerformed))
                    textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ",")
            {
                if (!textBox_Result.Text.Contains(","))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button14.PerformClick();
                operationPerformed = button.Text;
                //resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
          
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            labelCurrentOperation.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            labelCurrentOperation.Text = "";
            resultValue = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            isOperationPerformed = false;
            labelCurrentOperation.Text = "";
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            operationPerformed = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "1":
                    button4.PerformClick();
                    break;
                case "2":
                    button5.PerformClick();
                    break;
                case "3":
                    button6.PerformClick();
                    break;
                case "4":
                    button7.PerformClick();
                    break;
                case "5":
                    button8.PerformClick();
                    break;
                case "6":
                    button9.PerformClick();
                    break;
                case "7":
                    button10.PerformClick();
                    break;
                case "8":
                    button11.PerformClick();
                    break;
                case "9":
                    button12.PerformClick();
                    break;
                case "0":
                    button1.PerformClick();
                    break;
                case "+":
                    button3.PerformClick();
                    break;
                case "-":
                    button13.PerformClick();
                    break;
                case "*":
                    button15.PerformClick();
                    break;
                case "/":
                    button16.PerformClick();
                    break;
                case "=":
                    button14.PerformClick();
                    break;
                case "ENTER":
                    button14.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}
