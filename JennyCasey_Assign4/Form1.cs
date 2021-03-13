using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                graphics.DrawLine(graphPen, graph.Width/2, 0, graph.Width/2, graph.Height);
                graphics.DrawLine(graphPen, 0, graph.Height / 2, graph.Width, graph.Height/2);

                for(int i = 0; i <= numberOfXTicks; i++)
                {
                    graphics.DrawLine(graphPen, i * (graph.Width) / numberOfXTicks, (graph.Height / 2) - numberOfXTicks,
                                                i * (graph.Width) / numberOfXTicks, (graph.Height / 2) + numberOfXTicks);

                    
                }
                for(int i = 0; i <= numberOfYTicks; i++)
                {
                    graphics.DrawLine(graphPen, (graph.Width / 2) + numberOfYTicks, i * (graph.Height) / numberOfYTicks,
                                               (graph.Width / 2) - numberOfYTicks, i * (graph.Height) / numberOfYTicks);
                }
               
                graph.Refresh();
            }
            //need to find a few points from the slope and then draw that

            //LINEAR EQUATION GRAPHING
            if (linear_slopeValue.Text.Length != 0 && linear_yValue.Text.Length != 0)
            {
                //grab the info entered for the equation 
                int yIntercept = int.Parse(linear_yValue.Text);
                int slope = int.Parse(linear_slopeValue.Text);

                testOutput.AppendText("y intercept is " + yIntercept + " and slope value is " + slope);
                if (isDown == true)
                {
                    //depending on what color choice/radio button was clicked that is the color we will draw in
                    if (redColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Red))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, 0, yIntercept, 100, 100);
                        }
                    }
                    if (blueColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Blue))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, 0, yIntercept, 100, 100);
                        }
                    }
                    if (greenColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Green))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, 0, yIntercept, 100, 100);
                        }
                    }
                    if (blackColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Black))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, 0, yIntercept, 100, 100);
                        }
                    }
                    //if user didn't choose a color then let them know they need to
                    if(!blackColorRadioButton_Linear.Checked && !blueColorRadioButton_Linear.Checked
                        && !redColorRadioButton_Linear.Checked && !greenColorRadioButton_Linear.Checked)
                    {
                        testOutput.AppendText("Please pick a color");
                    }

                }
            }

            //QUADRADTIC EQUATION GRAPHING 
            if (Quad_Avalue.Text.Length != 0 && Quad_Bvalue.Text.Length != 0 && Quad_Cvalue.Text.Length != 0)
            {
                int A_Value = int.Parse(Quad_Avalue.Text);
                int B_Value = int.Parse(Quad_Bvalue.Text);
                int C_Value = int.Parse(Quad_Cvalue.Text);

                int H_Value = (-1 * B_Value) / (2 * A_Value); //x-intercept of the vertex of the parabola

                //plug H -value into the equation to get the K-value
                int K_Value = (A_Value * (H_Value * H_Value)) + (B_Value * H_Value) + C_Value; //y-intercept of the vertex of the parabola



                double x, y;
                Point[] Point = new Point[10000];
                int n = 0;

                //get point, two to the left and two to the right of the vertex and put them in an array
                for (int i = (H_Value - 4); i <= (H_Value + 4); i += 1)
                {

                    x = i;
                    y = (A_Value * (x * x)) + ((B_Value * x) + C_Value);

                    if (x == 0)
                    {
                        x = graph.Width / 2;
                    }
                    else
                    {
                        x = (graph.Width / 2 + (graph.Width / xDistance * (int)x));
                    }

                    if (y == 0)
                    {
                        y = graph.Height / 2;
                    }
                    else
                    {
                        y = (graph.Height / 2 - (graph.Height / yDistance * (int)y));
                    }

                    Point[n] = new Point((int)x, (int)y);
                    n++;
                }

                Pen redPen = new Pen(Color.Red, 3);
                Pen bluePen = new Pen(Color.Blue, 3);
                Pen greenPen = new Pen(Color.Green, 3);
                Pen blackPen = new Pen(Color.Black, 3);
                if (RedColorRadioButton_Quadratic.Checked)
                {
                    e.Graphics.DrawCurve(redPen, Point);
                } 
                else if (BlueColorRadioButton_Quadratic.Checked)
                {
                    e.Graphics.DrawCurve(bluePen, Point);
                }              
                else if (GreenColorRadioButton_Quadratic.Checked)
                {
                    e.Graphics.DrawCurve(greenPen, Point);
                }              
                else if (BlackColorRadioButton_Quadratic.Checked)
                {
                    e.Graphics.DrawCurve(blackPen, Point);
                }
                else
                {
                    testOutput.AppendText("Please Choose a Color");
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

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
