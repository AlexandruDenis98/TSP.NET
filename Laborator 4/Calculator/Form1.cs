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
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
            button10.Click += Button_Click;
            button11.Click += Button_Click;
            button12.Click += Button_Click;
            button13.Click += Button_Click;
            button14.Click += Button_Click;
            button15.Click += Button_Click;
            button16.Click += Button_Click;
            button17.Click += Button_Click;
        }
        public String[] evaluateExpression(TextBox textBox)
        {
            String[] expressionArray = textBox.Text.Split(' ');
            return expressionArray;
        }
        public float returnExpressionResult(String[] expressionArray)
        {
            float result=-1;
            if (expressionArray[1] == "+") result = float.Parse(expressionArray[0]) + float.Parse(expressionArray[2]);
            if (expressionArray[1] == "-") result = float.Parse(expressionArray[0]) - float.Parse(expressionArray[2]);
            if (expressionArray[1] == "*") result = float.Parse(expressionArray[0]) * float.Parse(expressionArray[2]);
            if (expressionArray[1] == "/") result = float.Parse(expressionArray[0]) / float.Parse(expressionArray[2]);
            return result; 
        }
        private void Button_Click(object sender, EventArgs e)
        {
            String senderText = ((Button)sender).Text;
            if (senderText == "+" || senderText == "-" || senderText == "*" || senderText == "/" || senderText == "=")
            {
                this.textBox1.AppendText(" " + senderText + " ");
                if (senderText == "=") this.textBox1.AppendText(returnExpressionResult(evaluateExpression(this.textBox1)).ToString());
            }
            else if (senderText == "C") this.textBox1.Text = "";
            else this.textBox1.AppendText(senderText);
            
        }
    }
}
