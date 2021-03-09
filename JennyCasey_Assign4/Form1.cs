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
       /* private static int xMin;    // -- the lowest x-coordinate value
        private static int xMax;        // -- the highest x-coordinate value
        private static int xInternval;  // -- the distance between ticks on the x-axis
        private static int yMin;        
        private static int yMax;
        private static int yInterval;*/

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

            using (Pen myPen = new Pen(Color.BurlyWood))
            {
               
                for (int i = 0; i < 10; i++)
                {
                    graphics.DrawLine(myPen, i*(graph.Width)/10, (graph.Height / 2) - 10, 
                        i * (graph.Width) / 10, (graph.Height / 2) + 10);
                }
                

                graphics.DrawLine(myPen, 0, graph.Height / 2, graph.Width, graph.Height / 2);
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
            if (Quad_Avalue.Text.Length != 0 && Quad_Bvalue.Text.Length != 0 && Quad_Cvalue.Text.Length !=0)
            {
                double A_Value = double.Parse(Quad_Avalue.Text);
                double B_Value = double.Parse(Quad_Bvalue.Text);
                double C_Value = double.Parse(Quad_Cvalue.Text);

                double H_Value = (-1 * B_Value) / (2 * A_Value);
                double K_Value = (A_Value * (H_Value * H_Value)) + (B_Value * H_Value) + C_Value;

                testOutput.AppendText("H value is " + H_Value + "K value is " + K_Value + "\n");

                //double Y_Value = (A_Value * (i * i)) + (B_Value * i) + C_Value; //find y value 


                // Point point1 = new Point(H_Value, K_Value); // represents the vertex


                Point point2 = new Point(graph.Width/2, graph.Height/2);
                Point point3 = new Point(graph.Width / 3, graph.Height / 3); //(0,2)
                Point point4 = new Point(10, 10); //(-2,2)
                //Point point5 = new Point(0,0);
               // Point point6 = new Point(0,0);
               // Point point7 = new Point(0,0);
                Point[] curvePoints = {point2, point3, point4 };

                Pen redPen = new Pen(Color.Red, 3);
                e.Graphics.DrawCurve(redPen, curvePoints, 1);

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
    }
}
