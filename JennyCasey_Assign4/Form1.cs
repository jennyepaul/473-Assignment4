using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics; 

namespace JennyCasey_Assign4
{
    public partial class Form1 : Form
    {
        //the following are the 4 colors that we can use to draw
        public static System.Drawing.Color Red { get; }
        public static System.Drawing.Color Black { get; }
        public static System.Drawing.Color Blue { get; }
        public static System.Drawing.Color Green { get; }

        //variable to check if the mouse is down when they click the "Graph" button
        private bool isDown;
        private static int xMin;        // -- the lowest x-coordinate value
        private static int xMax;        // -- the highest x-coordinate value
        private static int xInterval;  // -- the distance between ticks on the x-axis
        private static int yMin;        
        private static int yMax;
        private static int yInterval;
        private static Point origin;

        //linear equation points
        /*
        private static Point linearPointOne;
        private static Point linearPointTwo;
        private static Point linearPointThree;
        private static Point linearPointFour;
        private static Point linearPointFive;
        */
        public Form1()
        {
            InitializeComponent();
            cubic_Alabel.Text = "x\x00B3 +";
            cubic_Blabel.Text = "x\x00B2 +";

        }

        private void graph_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //need to do a check in here to ensure we have values for everything

            xMin = (int)xMinValue.Value;
            xMax = (int)xMaxValue.Value;

            yMin = (int)yMinValue.Value;
            yMax = (int)yMaxValue.Value;

            xInterval = (int)xIntervalValue.Value;
            yInterval = (int)yIntervalValue.Value;

            //find the distance between the y points
            int yDistance = Math.Abs(yMin) + Math.Abs(yMax);
            int numberOfYTicks = yDistance / yInterval;

            //find the distance between the x points
            int xDistance = Math.Abs(xMin) + Math.Abs(xMax);
            int numberOfXTicks = xDistance / xInterval;



            using (Pen graphPen = new Pen(Color.Black))
            {
                //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                //draw the x & y lines of the graph
                graphics.DrawLine(graphPen, graph.Width / 2, 0, graph.Width / 2, graph.Height);
                graphics.DrawLine(graphPen, 0, graph.Height / 2, graph.Width, graph.Height / 2);

                for (int i = 0; i <= numberOfXTicks; i++)
                {
                    graphics.DrawLine(graphPen, i * (graph.Width) / numberOfXTicks, (graph.Height / 2) - numberOfXTicks,
                                                i * (graph.Width) / numberOfXTicks, (graph.Height / 2) + numberOfXTicks);


                }
                for (int i = 0; i <= numberOfYTicks; i++)
                {
                    graphics.DrawLine(graphPen, (graph.Width / 2) + numberOfYTicks, i * (graph.Height) / numberOfYTicks,
                                               (graph.Width / 2) - numberOfYTicks, i * (graph.Height) / numberOfYTicks);
                }

                // graph.Refresh();
            }
            //LINEAR EQUATION GRAPHING
            if (linear_riseValue.TextLength != 0 && linear_runValue.TextLength != 0 && linear_yPointVal.TextLength != 0 && linear_xPointVal.TextLength != 0)
            {
                //grab the info entered for the equation 
                int rise = int.Parse(linear_riseValue.Text);
                int run = int.Parse(linear_runValue.Text);
                int yPoint = int.Parse(linear_yPointVal.Text);
                int xPoint = int.Parse(linear_xPointVal.Text);
                int xOrigin = graph.Width / 2;
                int yOrigin = graph.Height / 2;

                run = (graph.Width / xInterval) * run;
                rise = (graph.Height / yInterval) * rise;

                int xValue = (xOrigin + (graph.Width / numberOfXTicks) * xPoint);
                int yValue = (yOrigin - (graph.Height / numberOfYTicks) * yPoint);


                //first xpoint is going to be xOrigin + (graphWidth / xinterval)xPoint)
                //first ypoiint is going to be yOrigin + (yHeight / yInterval)yPoint)
                Point yIntercept = new Point(xValue, yValue);
                Point point1 = new Point(xValue + run, yValue - rise);

                ///find a way to extend the linear line more


                if (isDown == true)
                {
                    //depending on what color choice/radio button was clicked that is the color we will draw in
                    if (redColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Red))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, yIntercept, point1);


                        }
                    }

                    if (blueColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Blue))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, yIntercept, point1);


                        }
                    }
                    if (greenColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Green))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, yIntercept, point1);


                        }
                    }
                    if (blackColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Black))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, yIntercept, point1);


                        }
                    }

                    //if user didn't choose a color then let them know they need to
                    if (!blackColorRadioButton_Linear.Checked && !blueColorRadioButton_Linear.Checked
                        && !redColorRadioButton_Linear.Checked && !greenColorRadioButton_Linear.Checked)
                    {
                        testOutput.AppendText("Please pick a color");
                    }

                }
            }

            //CUBIC EQUATION GRAPHING
            if (cubic_AValue.TextLength != 0 && cubic_BValue.TextLength != 0 && cubic_CValue.TextLength != 0 && cubic_DValue.TextLength != 0)
            {
                //the y-intercept is always whatever d is since we set x = 0 to find equation, it cancels everything out but D value
                double yIntercept = double.Parse(cubic_DValue.Text);
                double dValue = double.Parse(cubic_DValue.Text);
                double aValue = int.Parse(cubic_AValue.Text);
                double bValue = int.Parse(cubic_BValue.Text);
                double cValue = int.Parse(cubic_CValue.Text);

                int x3 = 2;
                int x4 = 0;

                //testOutput.AppendText("A value is " + aValue + " B value is " + bValue + "c Value is " + cValue);
                //test output to see if we grabbed the right info
                //testOutput.AppendText("y intercept is " + yIntercept);

                double xIntercept = findXIntercept(aValue, bValue, cValue, yIntercept);

                //test output to see if we grabbed the right info
                //testOutput.AppendText("cubed root of A " + xIntercept);



                yIntercept = ((graph.Height / 2) - (graph.Height / numberOfYTicks) * yIntercept);
                xIntercept = ((graph.Width / 2) + (graph.Width / numberOfXTicks) * xIntercept);

                int x = (int)xIntercept;
                int y = (int)yIntercept;


                //yIntercept Point
                Point yPoint = new Point(0, y);

                //xIntercept Point
                Point xPoint = new Point(x, 0);


                //getting new points here
                double point3Y = aValue * (Math.Pow(x3, 3)) + bValue * (Math.Pow(x3, 2)) + cValue * x3 + dValue;
                double point4Y = aValue * (Math.Pow(x4, 3)) + bValue * (Math.Pow(x4, 2)) + cValue * x4 + dValue;

                //converting points 3 & 4 to ints
                int y3 = (int)point3Y;
                int y4 = (int)point4Y;

                //finding the right amount of space based on interbals
                x3  = ((graph.Width / 2) + (graph.Width / numberOfXTicks) * x3);
                x4 = ((graph.Width / 2) + (graph.Width / numberOfXTicks) * x4);

                y3 = ((graph.Height / 2) - (graph.Height / numberOfYTicks) * y3);
                y4 = ((graph.Height / 2) - (graph.Height / numberOfYTicks) * y4);


                Point point3 = new Point(x3, y3);
                Point point4 = new Point(x4, y4);

                //had xPoint in here before, took it out cause not sure if x-intercept math is right?
                Point[] cubicPoints = {yPoint, point3, point4};
                if (isDown == true)
                {
                    //depending on what color choice/radio button was clicked that is the color we will draw in
                    if (redColorRadioButton_Cubic.Checked)
                    {
                        using (Pen cubicPen = new Pen(Color.Red))
                        {
                            graphics.DrawCurve(cubicPen, cubicPoints);

                            //graph the x intercept point
                            //graphics.DrawRectangle(cubicPen, x, 0, 5, 5);

                            //graph the y intercept point
                            //graphics.DrawRectangle(cubicPen, 0, y, 5, 5);



                        }
                    }
                }
            }
        }
        

        //mouse Down event to draw the graphs only when the mouse is Down
        private void graphButton_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            testOutput.Clear();
            graph.Refresh();
        }

        //when Mouse is up, it will reset the "isDown" bool variable
        private void graphButton_MouseUp(object sender, MouseEventArgs e)
        { 
            isDown = false;
            //graph.Refresh();
        }

        //changes the x minimum value on the graph depending what user enters
        private void xMinValue_ValueChanged(object sender, EventArgs e)
        {
            string xMin = xMinValue.Value.ToString();
            xLabelMin.Text = xMin;
        }

        //changes the x max value on the graph depending what user enters
        private void xMaxValue_ValueChanged(object sender, EventArgs e)
        {
            string xMax = xMaxValue.Value.ToString();
            xLabelMax.Text = xMax;

        }

        //changes y min value on the graph depending what user enteres
        private void yMinValue_ValueChanged(object sender, EventArgs e)
        {
            string yMin = yMinValue.Value.ToString();
            yLabelMin.Text = yMin;
        }
        //changes y max value on the graph depending what user enters
        private void yMaxValue_ValueChanged(object sender, EventArgs e)
        {
            string yMax = yMaxValue.Value.ToString();
            yLabelMax.Text = yMax;
        }

        static double findXIntercept(double a, double b, double c, double d)
        {
            //equation is 0 = A * x * x * x + B * x * x + c * x + d
            //xValue = a + b + c + d
            double xIntercept;

            double xValue = 1;

            //get cubed root of value A
            double A = (Math.Ceiling(Math.Pow(a, 1.0/ 3.0)));

            //get square root of value B
            double B = (Math.Ceiling(Math.Pow(b, 1.0 / 2.0)));

            //add all X variables together
            A = A + B + c;

            //flip sign to account for subtracting the 'x' value over in the equation 
            A *= -1;

            //multiply x value by A
            xValue *= A;

            //divide by D value
            xValue /= d;

            //set x intercept to xValue just calculated
            xIntercept = xValue;

            return xIntercept;
        }
    }


}
