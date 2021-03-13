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
                graphics.DrawLine(myPen, graph.Width / 2, 0, graph.Width / 2, graph.Height);
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
                int A_Value = int.Parse(Quad_Avalue.Text);
                int B_Value = int.Parse(Quad_Bvalue.Text);
                int C_Value = int.Parse(Quad_Cvalue.Text);

                int H_Value = (-1 * B_Value) / (2 * A_Value); //x-intercept of the vertex of the parabola

                //plug H -value into the equation to get the K-value
                int K_Value = (A_Value * (H_Value * H_Value)) + (B_Value * H_Value) + C_Value; //y-intercept of the vertex of the parabola
         


                double x,y;
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
                        x = (graph.Width / 2 + (graph.Width/20 * (int)x));
                    }

                    if (y == 0)
                    {
                        y = graph.Height / 2;
                    }
                    else
                    {
                        y = (graph.Height / 2 - (graph.Height/20 * (int)y));        
                    }

                    Point[n] = new Point((int)x, (int)y);
                    n++;
                }

                Pen redPen = new Pen(Color.Red, 3);
                if (RedColorRadioButton_Quadratic.Checked)
                {
                    e.Graphics.DrawCurve(redPen, Point);
                }
                Pen bluePen = new Pen(Color.Blue, 3);
                if (BlueColorRadioButton_Quadratic.Checked)
                {
                    e.Graphics.DrawCurve(bluePen, Point);
                }
                Pen greenPen = new Pen(Color.Green, 3);
                if (GreenColorRadioButton_Quadratic.Checked)
                {
                    e.Graphics.DrawCurve(greenPen, Point);
                }
                Pen blackPen = new Pen(Color.Black, 3);
                if (BlackColorRadioButton_Quadratic.Checked)
                {
                    e.Graphics.DrawCurve(blackPen, Point);
                }

            }
            
            if (Circle_HValue.Text.Length != 0 && Circle_KValue.Text.Length != 0 && Circle_RValue.Text.Length != 0)
            {
                int H_Value = int.Parse(Circle_HValue.Text);
                int K_Value = int.Parse(Circle_KValue.Text);
                int R_Value = int.Parse(Circle_RValue.Text);

                Pen blackPen = new Pen(Color.Black, 3);

                if (H_Value == 0)
                {
                    H_Value = graph.Width / 2;
                }
                else
                {
                    H_Value = (graph.Width / 2 + (graph.Width / 20 * H_Value));
                }
                if (K_Value == 0)
                {
                    K_Value = graph.Width / 2;
                }
                else
                {
                    K_Value = (graph.Width / 2 - (graph.Width / 20 * K_Value));
                }
                if (R_Value == 0)
                {
                    R_Value = H_Value;
                }
                else
                {
                    R_Value =  (graph.Width / 20 * R_Value);
                }

                

                e.Graphics.DrawEllipse(blackPen, H_Value - R_Value, K_Value - R_Value,
                      R_Value + R_Value, R_Value + R_Value);
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
