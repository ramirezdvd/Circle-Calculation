using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathLibCircleInfo_DavidRamires

//Author: David Ramirez 
//Goal-Purpose of the Program: The purpose of the program is to calculate the area, circumference and the diameter
//of a circle when the radius is entered into the text box.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //  Button to calculate the radius into the given answer labels
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            // To convert the text into intergers.
            double Mytxt_RadiusOfACircle = 0;
            double MyLabel_Diameter = 0;
            double MyLabel_Circumference = 0;
            double MyLabel_Area = 0;

            // Converts the string representation of a number to its double-precision
            //floating-point (Floating point is used to represent fractional values) number equivalent.
            Mytxt_RadiusOfACircle = double.Parse(txt_RadiusOfACircle.Text);

            //Calculations to calculate the answers to the texbox ammount given
            //PI represents the number 
            MyLabel_Diameter = Mytxt_RadiusOfACircle * 2;
            MyLabel_Circumference = 2 * (Math.PI) * Mytxt_RadiusOfACircle;
            MyLabel_Area = (Math.PI) * (Mytxt_RadiusOfACircle) * (Mytxt_RadiusOfACircle);

            // Converts the number descriptions into numerical text
            Label_Diameter.Text = MyLabel_Diameter.ToString("n2");
            Label_Circumference.Text = MyLabel_Circumference.ToString("n2");
            Label_Area.Text = MyLabel_Area.ToString("n2");

           


        }

        private void Label_Circumference_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EROCLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label_Diameter_Click(object sender, EventArgs e)
        {

        }
    }
}
