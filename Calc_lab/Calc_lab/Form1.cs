using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_lab
{
    public partial class Form1 : Form
    {
        Boolean newCalc = true;
        int storedNumber = 0;
        string operation = "";
        int lastNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button CB = (Button)sender;
            if (newCalc != true)
            {
                newCalc = true;
                inputField.Clear();
            }
            inputField.Text = inputField.Text + CB.Text;
            int.TryParse(inputField.Text, out lastNumber);
            

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if(prevNumber.Text != "")
            {
                int.TryParse(inputField.Text, out lastNumber);
            }
            performOperation(operation, lastNumber);
            prevNumber.Text = "";
            label1.Text = "lastNumber" + lastNumber + " StoredNumber:" + storedNumber + " operation:" + operation;
            newCalc = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button CB = (Button)sender;
            operation = CB.Text;
            if (int.TryParse(inputField.Text, out storedNumber))
            {
                prevNumber.Text = inputField.Text + operation;
                inputField.Clear();
            }
            else
                inputField.Text = "Error";
        }

        private void performOperation(string operation, int number)
        {
            int totalSum = 0;
            Boolean error = false;
            switch (operation)
            {
                case "+": totalSum = storedNumber + number; break;
                case "-": totalSum = storedNumber - number; break;
                case "%": if (number != 0) totalSum = storedNumber / number; else error = true; break;
                case "*": totalSum = storedNumber * number; break;
                default: break;
            }
            //if (!error)
                inputField.Text = totalSum.ToString();
                storedNumber = totalSum;
            //else
                //inputField.Text = "Error";
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            storedNumber = 0;
            operation = "";
            lastNumber = 0;
            inputField.Clear();
            prevNumber.Text = "";
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            inputField.Clear();
        }
    }
}
