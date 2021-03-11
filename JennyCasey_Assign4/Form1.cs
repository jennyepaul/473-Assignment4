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
               
               // graph.Refresh();
            }
            //need to find a few points from the slope and then draw that

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
                /*
                xValue = xValue + run;
                yValue = yValue - rise;
                Point point3 = new Point(xValue + run, yValue - rise);
                xValue = xValue + run;
                yValue = yValue - rise;
                Point point4 = new Point(xValue + run, yValue - rise);
                */


                if (isDown == true)
                {
                    //depending on what color choice/radio button was clicked that is the color we will draw in
                    if (redColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Red))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            //graphics.DrawRectangle(linearPen, new Rectangle(xValue, yValue, 5, 5));
                            testOutput.AppendText("y intercept is: " + yIntercept + " and second point is: " + point1);

                            graphics.DrawLine(linearPen, yIntercept, point1);
                            //graphics.DrawLine(linearPen, point3, point4);


                        }
                    }
                    
                    if (blueColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Blue))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);

                        }
                    }
                    if (greenColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Green))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);

                        }
                    }
                    if (blackColorRadioButton_Linear.Checked)
                    {
                        using (Pen linearPen = new Pen(Color.Black))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);

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
    }
}
