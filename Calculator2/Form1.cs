///////////////////////////////////////////////////////////////////////////////////
//TINFO 200, Winter 2024
//Andrew McDonald
//C#Programming Project
//Date          Developer       Description
//2023-1-16      atmcdon         Creation Calculator 
//2023-1-18      atmcdon         Implemented Design form
//2023-1-22      atmcdon         Exception handling initiated 
//2023-1-22      atmcdon         Exception handling numBTn_click and btnOperand_Click V1
//2023-1-25      atmcdon         Exception handling btnOperand_Click V2 redesign + method operandOperation()
//2023-1-25      atmcdon         Exception handling numBtn_click changed to work Operand_clickV2
//2023-1-26      atmcdon         Exceptions for the rest of the buttons made.
//2023-1-26      atmcdon         Tested with nominal numbers - PASSED Testing
//2023-1-27      atmcdon         Tested outcomes at the bottom of the code
//2023-1-27      atmcdon         updated events that happened after pressing = equals button
//used for scientific notation https://www.c-sharpcorner.com/UploadFile/c25b6d/exponential-e-format-specifier-in-C-Sharp1/
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Calculator

{
    public partial class Calculator : Form
    {

        double newPrevValue = 0;
        double currentValue = 0;
        double previousValue = 0;
        int operatorCount = 0;
        string operatorSymbol = "";
        bool operTrue = false;

        //This is Methods and Event handling for the calculator program this should display and operator much like the 
        //Microsoft Windows Calculator. 
        public Calculator()
        {
            InitializeComponent();
        }

        //This event handling for when a number is pressed this will determine if the a operator is pressed and if so
        //will store the value on the display and record it as previous value.
        //This will also store the currentValue on the display.
        private void numBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //if the display has a zero or told to clear then it will clear.
            if (display.Text == "0" || operatorSymbol == "=")
            {
                display.Text = "";
                operatorSymbol = "";
            }

            if (operTrue == true && operatorCount >= 1)
            {
                display.Text = "";
                previousValue = newPrevValue;
                currentValue = 0;
                operTrue = false;
            }

            //only allow display 14 digits on the display
            if ((operatorSymbol != "=" && display.Text == "") || display.Text.Length != 14)
            {
                display.Text = display.Text + btn.Text;
            }
            currentValue = Convert.ToDouble(display.Text);

        }

        //This Event handler will only operate when the = equals button is pressed.
        //It will compute the prev and current value if the value is to big it will
        //display in scientific notation.
        private void btnEquals_Click(object sender, EventArgs e)
        {
            //in case the = is pressed multiple times. 
            if (operatorSymbol != "=")
            {
                newPrevValue = operandOperation();
            }

            //displays new value 
            //in case the value is to large or to small it will display in scientific notation.
            if (newPrevValue >= 1E10 || newPrevValue <= -1E10)
            {
                //source https://www.c-sharpcorner.com/UploadFile/c25b6d/exponential-e-format-specifier-in-C-Sharp1/
                display.Text = newPrevValue.ToString("E", CultureInfo.InvariantCulture);
            }
            else
            {
                display.Text = newPrevValue.ToString();
            }

            //displays error if dividing by 0.
            if (currentValue == 0 && operatorSymbol == "/")
            {
                display.Text = "Can't Divide by 0";
            }

            //makes the display the prev value for continued equations.
            operTrue = true;
            previousValue = newPrevValue;
            currentValue = 0;
            operatorCount = 0;
            operatorSymbol = "=";
        }


        //When the a Operator ie. + - / x is clicked this method will take the previous value
        //and the current value and compute them to a new value called new PrevValue.
        private void btnOperand_Click(object sender, EventArgs e)
        {
            //TESTS
            // 10+ DISPLAY 10
            // 10+10 DISPLAY 10
            // 10+10+ DISPLAY 20
            // 10+10+x DISPLAY 100

            Button btn = (Button)sender;
            //assigns the operator for the operandOperation method
            operatorSymbol = btn.Text;

            //if this is the second iteration of a operator then it will compute the operation.
            //EX. 5+5+ output to display 10
            //this allows the ability to change the operator.
            if (operatorCount >= 1)
            {
                //gets calculations of prev value and current value
                newPrevValue = operandOperation();

                //displays new value 
                //in case the value is to large or to small it will display in scientific notation.
                if (newPrevValue >= 1E10 || newPrevValue <= -1E10)
                {
                    //source https://www.c-sharpcorner.com/UploadFile/c25b6d/exponential-e-format-specifier-in-C-Sharp1/
                    display.Text = newPrevValue.ToString("E", CultureInfo.InvariantCulture);
                }
                else
                {
                    display.Text = newPrevValue.ToString();
                }
            }
            //if this is the 1st itration of a operator then it will not compute anything
            else if (operatorCount == 0)
            {
                newPrevValue = Convert.ToDouble(display.Text);

            }

            //tells numBtn_click that a operator has been pressed
            operTrue = true;
            operatorCount++;
        }

        // This is a method that is used to compute the prev value and current value 
        // into a result, based on the operator symbol pressed.
        // will throw an error if soemthing is wrong.
        private double operandOperation()
        {
            double result = 0;
            //previous value (operatorSymbol) current value = result
            //This uses a switch depending on the symbol.
            switch (operatorSymbol)

            {
                case "+":
                    result = (previousValue + currentValue);
                    break;
                case "-":
                    result = (previousValue - currentValue);
                    break;
                case "x":
                    result = (previousValue * currentValue);
                    break;
                case "/":
                    result = (previousValue / currentValue);

                    break;
                default:
                    MessageBox.Show("Error In the OperandOperation method");
                    break;
            }
            return (result);
        }

        // clears and resets all values.
        private void btnClear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            currentValue = 0;
            operatorCount = 0;
            previousValue = 0;
            operatorSymbol = "";
            newPrevValue = 0;
            operTrue = false;
        }

        //clears only the screen.
        private void btnClearError_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }
        //Will put a Minus sign in front of the number unless its a 0 or empty.
        private void btnMinusConversion_Click(object sender, EventArgs e)
        {
            if (display.Text != "0" || display.Text != "")
                display.Text = (-double.Parse(display.Text)).ToString();

        }
        //If allowed in the display or if it already contains one, this will add a decimal point.
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (operatorSymbol != "=" && display.Text.Length != 14)
            {
                display.Text = display.Text.Contains(".") ? display.Text : display.Text + ".";
            }
        }
        //This is the backspace event that will delete one digit on the right.
        //will keep deleteing till the text box length is at 0 or there just a - minus sign.
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0 && operatorSymbol != "=")
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
                if (display.Text.Length == 0 || display.Text == "-")
                {
                    display.Text = "0";
                }

            }
        }
    }
}
// TESTS PREFORMED
//Test          |   expected output  |  actual output
//15+15         |   15               |  15
//15-15-        |   0                |  0
//15*15*-       |   0                |  0
//15+15=        |   30               |  30
//-15+15=       |   0                |  0
//15/15         |   1                |  1
//1.5+1.5=      |   3                |  3
// 5/0          |   0                |  0
//15/15         |   1                |  1