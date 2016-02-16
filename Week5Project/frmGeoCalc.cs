using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5Project
{
    public partial class GeoCalculator : Form
    {
        // global variables so we can use a single event listener.
        string selShape = "rectangle";
        string selCalculation = "area";

        public GeoCalculator()
        {
            InitializeComponent();
        }
        
        private void GeoCalculator_Load(object sender, EventArgs e)
        {   //Default settings

            //select rectangle and area radio buttons
            rdoRectangle.Select();
            rdoArea.Select();
            rdoRectangle.Checked = true;
            rdoArea.Checked = true;

            //hide all 5 text boxes
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            lblAnswer.Text = "";

            // set up default image to match autoselection of the rectangle
            picShape.ImageLocation = "..\\..\\..\\images\\rectangle.gif";
            lblEquations.Text = GetEquations();
        }

        private void rdoShape_CheckedChanged(object sender, EventArgs e) {
            if (rdoRectangle.Checked) selShape = "rectangle";
            if (rdoSquare.Checked) selShape = "square";
            if (rdoParallelogram.Checked) selShape = "parallelogram";
            if (rdoRhombus.Checked) selShape = "rhombus";
            if (rdoTriangle.Checked) selShape = "triangle";
            if (rdoTrapezoid.Checked) selShape = "trapezoid";
            if (rdoCircle.Checked) selShape = "circle";
            picShape.ImageLocation = "..\\..\\..\\images\\" + selShape + ".gif";
            lblEquations.Text = GetEquations();
        }
        
        private void rdoPerimeter_CheckedChanged(object sender, EventArgs e)
        {
            selCalculation = rdoPerimeter.Text.ToLower();
        }

        private void rdoArea_CheckedChanged(object sender, EventArgs e)
        {
            selCalculation = rdoArea.Text.ToLower();
        }

        private void rdoAreaPerimeter_CheckedChanged(object sender, EventArgs e) 
        {
            selCalculation = rdoAreaPerimeter.Text.ToLower();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(btnCalculate.Text, "button label");
            // make the appropriate number of text boxes visible and supply them with appropriate labels.
            if (btnCalculate.Text.Equals("&Calculate"))
            {
                ShowBoxes();

                btnCalculate.Text = "&Answer";  // Yes, this means alt-A triggers the calculation!
            }
            else if (btnCalculate.Text.Equals("&Answer"))
            {
                Calculate(selShape,selCalculation);
            }
        }

        private void ShowBoxes()
        {
            switch (selShape)
            {
                case "rectangle":
                    {
                        label1.Visible = true;
                        label1.Text = "length";
                        label2.Visible = true;
                        label2.Text = "width";
                        txt1.Visible = true;
                        txt2.Visible = true;
                        break;
                    }
                case "square":
                    {
                        label1.Visible = true;
                        label1.Text = "length";
                        txt1.Visible = true;
                        break;
                    }
                case "parallelogram":
                    {
                        label1.Visible = true;
                        label1.Text = "length";
                        label2.Visible = true;
                        label2.Text = "width";
                        label3.Visible = true;
                        label3.Text = "height";
                        txt1.Visible = true;
                        txt2.Visible = true;
                        txt3.Visible = true;
                        break;
                    }
                case "rhombus":
                    {
                        label1.Visible = true;
                        label1.Text = "length";
                        label2.Visible = true;
                        label2.Text = "height";
                        txt1.Visible = true;
                        txt2.Visible = true;
                        break;
                    }
                case "triangle":
                    {
                        label1.Visible = true;
                        label1.Text = "longest side";
                        label2.Visible = true;
                        label2.Text = "side 2";
                        label3.Visible = true;
                        label3.Text = "side 3";
                        label4.Visible = true;
                        label4.Text = "height";
                        txt1.Visible = true;
                        txt2.Visible = true;
                        txt3.Visible = true;
                        txt4.Visible = true;
                        break;
                    }
                case "trapezoid":
                    {
                        label1.Visible = true;
                        label1.Text = "length of top";
                        label2.Visible = true;
                        label2.Text = "length of bottom";
                        label3.Visible = true;
                        label3.Text = "side 1";
                        label4.Visible = true;
                        label4.Text = "side 2";
                        label5.Visible = true;
                        label5.Text = "height";
                        txt1.Visible = true;
                        txt2.Visible = true;
                        txt3.Visible = true;
                        txt4.Visible = true;
                        txt5.Visible = true;
                        break;
                    }
                case "circle":
                    {
                        label1.Visible = true;
                        label1.Text = "radius";
                        // label2.Visible = true;
                        // label2.Text = "diameter";
                        txt1.Visible = true;
                        // txt2.Visible = true;
                        break;
                    }
            }  // end switch-case
        } // end function ShowBoxes

        private void Calculate (string shape, string calc)
        {
            try
            {
                // throw new Exception();
                // MessageBox.Show("shape: " + shape + "\ncalc: " + calc, "Variables");
                if (calc.Equals("area"))
                {
                    lblAnswer.Text = GetArea(shape);
                }
                else if (calc.Equals("perimeter"))
                {
                    lblAnswer.Text = GetPerimeter(shape);
                }
                else
                {
                    // return both
                    lblAnswer.Text = GetArea(shape) + "\n" + GetPerimeter(shape);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Format Exception: You appear not to have entered a number in one of the text boxes.",
                    "Error!"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred: \n" + ex.ToString(),
                    ex.GetType().ToString()
                    );
            }
        } // end function Calculate

        private string GetArea(string shape)
        {
            double result = 0d;
            switch (shape)
            {
                case "rectangle":
                    { //calculate area of rectangle
                        double ht = double.Parse(txt1.Text);
                        double wd = double.Parse(txt2.Text);
                        double area = ht * wd;
                        result = area;
                        break;
                    }
                case "square":
                    { //calculate area of square
                        double s = double.Parse(txt1.Text);
                        double area = s * s;
                        result = area;
                        break;
                    }
                case "parallelogram":
                    { //calculate area of parallelogram
                        double b = double.Parse(txt1.Text);
                        double h = double.Parse(txt3.Text);
                        double area = b * h;
                        result = area;
                        break;
                    }
                case "rhombus":
                    { //calculate area of rhombus
                        double b = double.Parse(txt1.Text);
                        double h = double.Parse(txt2.Text);
                        double area = b * h;
                        result = area;
                        break;
                    }
                case "triangle":
                    { //calculate area of triangle
                        double b = double.Parse(txt1.Text);
                        double h = double.Parse(txt4.Text);
                        double area = (b * h) / 2;
                        result = area;
                        break;
                    }
                case "trapezoid":
                    { //calculate area of trapezoid
                        double t = double.Parse(txt1.Text);
                        double b = double.Parse(txt2.Text);
                        double h = double.Parse(txt5.Text);
                        double area = ((t + b) / 2) * h;
                        result = area;
                        break;
                    }
                case "circle":
                    { //calculate area of circle
                        double r = double.Parse(txt1.Text);
                        // double d = double.Parse(txt2.Text);
                        double area = (Math.PI * (r * r));
                        result = area;
                        break;
                    }
                default:
                    {
                        // do nothing
                        break;
                    }
            } // end switch-case

            // annoying to have two variables, but them's the breaks when working with someone else's code.
            return "Area is: " + result;
        } // end function GetArea

        private string GetPerimeter(string shape)
        {
            string answer = "";
            switch (shape)
            {
                case "rectangle":
                    { //calculate area of rectangle
                        double ht = double.Parse(txt1.Text);
                        double wd = double.Parse(txt2.Text);
                        double perim = 2* (ht + wd);
                        answer = "Perimeter is: " + perim.ToString();
                        break;
                    }
                case "square":
                    { //calculate area of square
                        double s = double.Parse(txt1.Text);
                        double perim = 4 * s;
                        answer = "Perimeter is: " + perim.ToString();
                        break;
                    }
                case "parallelogram":
                    { //calculate area of parallelogram
                        double b = double.Parse(txt1.Text);
                        double a = double.Parse(txt2.Text);
                        double perim = 2 * (b + a);
                        answer = "Perimeter is: " + perim.ToString();
                        break;
                    }
                case "rhombus":
                    { //calculate area of rhombus
                        double b = double.Parse(txt1.Text);
                        double h = double.Parse(txt2.Text);
                        double perim = b * 4;
                        answer = "Perimeter is: " + perim.ToString();
                        break;
                    }
                case "triangle":
                    { //calculate area of triangle
                        double b = double.Parse(txt1.Text);
                        double a = double.Parse(txt2.Text);
                        double c = double.Parse(txt3.Text);
                        double perim = a + b + c;
                        answer = "Perimeter is: " + perim.ToString();
                        break;
                    }
                case "trapezoid":
                    { //calculate area of trapezoid
                        double t = double.Parse(txt1.Text);
                        double b = double.Parse(txt2.Text);
                        double a = double.Parse(txt3.Text);
                        double c = double.Parse(txt4.Text);
                        double perim = a + b + c + t;
                        answer = "Perimeter is: " + perim.ToString();
                        break;
                    }
                case "circle":
                    { //calculate area of circle
                        double r = double.Parse(txt1.Text);
                        // double d = double.Parse(txt2.Text);
                        double perim = (Math.PI * (2 * r));
                        answer = "Perimeter is: " + perim.ToString();
                        break;
                    }
                default:
                    {
                        // do nothing
                        break;
                    }
            } // end switch-case

            // return our text string 
            return answer;
        } // end function GetPerimeter

        private void btnClear_Click(object sender, EventArgs e)
        {
            // turn off our labels and text boxes
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            // revert to defaults
            rdoRectangle.Select();
            rdoArea.Select();
            picShape.ImageLocation = "..\\..\\..\\images\\rectangle.gif";
            // and clear our text boxes
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            lblAnswer.Text = "";
            btnCalculate.Text = "&Calculate";
        
        } // end btnClear_Click

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxChanged_TextChanged(object sender, EventArgs e)
        {
            TextBox whatChanged = (TextBox)sender;
            //MessageBox.Show(whatChanged.Text);
            string textValue = whatChanged.Text;
            if (!(textValue == "" || ValidateInput(textValue)))
            {
                MessageBox.Show("You have entered an invalid value!", "Invalid input");
                whatChanged.Focus();
            }
            
        }

        private bool ValidateInput(string inputText)  
        {
            // verifies inputText is a number 
            double result;
            return double.TryParse(inputText, out result);
        }

        private string GetEquations()
        {
            Dictionary<string,string> shapeDict = new Dictionary<string,string>();
            shapeDict.Add("rectangle","area: l * w\nperimeter: 2 * (l + w)");
             shapeDict.Add("square","area: s * s\nperimeter: 4 * s");
             shapeDict.Add("parallelogram","area: b * h\nperimeter: 2 * (a + b)");
             shapeDict.Add("rhombus","area: b * h \nperimeter: 4 * b");
             shapeDict.Add("triangle","area: (b * h) / 2\nperimeter: a + b + c");
             shapeDict.Add("trapezoid","area: ((a + b) * h) / 2\nperimeter: a + b + c + d");
             shapeDict.Add("circle","area: π * r * r\nperimeter: 2 * π * r");

            return "Formulae for " + selShape + ":\n" + shapeDict[selShape];
        }
        private string GetModulus() {
            double operator1 = double.Parse(txt1.Text);
            double operator2 = double.Parse(txt2.Text);
            return (operator1 % operator2).ToString();
        }

        private string GetPercent()
        {
            double operator1 = double.Parse(txt1.Text);
            double operator2 = double.Parse(txt2.Text);
            double percent = operator1 / operator2;
            return (percent).ToString("p2");
        }


    } // end partial class GeoCalculator

   
}