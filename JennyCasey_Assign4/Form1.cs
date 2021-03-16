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
        private static bool isYMinGreat0 = false;
        private static bool isYMaxSmall0 = false;
        private static bool isXMinGreat0 = false;
        private static bool isXMaxSmall0 = false;
        private static bool isNormalGraph = false;

        //the following 8 variables hold the integer location of the x and y coordinates of the graph depending
        //on how we draw the graph
        private static int graph1xOrigin;
        private static int graph1yOrigin;

        private static int graph2xOrigin;
        private static int graph2yOrigin;

        private static int graph3xOrigin;
        private static int graph3yOrigin;


        private static int graph4xOrigin;
        private static int graph4yOrigin;

        public Form1()
        {
            InitializeComponent();

            //add in all the squared, and cubed labels
            cubic_Alabel.Text = "x\x00B3 +";
            cubic_Blabel.Text = "x\x00B2 +";
            quadratic_label1.Text = "\x00B2 +";
            circle_label1.Text = ")\x00B2 + (y-";
            circle_label2.Text = ")\x00B2 =";
            circle_label3.Text = "\x00B2)";

        }

        private void graph_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
        
            xMin = (int)xMinValue.Value;
            xMax = (int)xMaxValue.Value;

            yMin = (int)yMinValue.Value;
            yMax = (int)yMaxValue.Value;

            xInterval = (int)xIntervalValue.Value;
            yInterval = (int)yIntervalValue.Value;

            //find the distance between the y points
            int yDistance = 0; 
            int numberOfYTicks =0;

            //find the distance between the x points
            int xDistance =0;  
            int numberOfXTicks = 0; 


            using (Pen graphPen = new Pen(Color.Black))
            {
                if ((yMin > 0 || yMax < 0) && (xMin == 0 && xMax == 0))
                {
                    //if yMin is greater than 0 then we want the upper part of the graph (upside down T)
                    //if yMax is less than 0, then we want the lower part of the graph (T looking graph)
                    //only draw the y axis
                    if(yMin > 0)
                    {
                        //set the flag
                        isYMinGreat0 = true;

                        //set the x & y origin for graph
                        graph1xOrigin = graph.Width / 2;
                        graph1yOrigin = graph.Height;


                        graphics.DrawLine(graphPen, graph.Width / 2, 0, graph.Width / 2, graph.Height);

                        //the x distance is just the width of the drawing plane
                        xDistance = Math.Abs(yMin) + Math.Abs(yMax);

                        //number of ticks we should draw is the width / the interval the user entered
                        numberOfXTicks = xDistance / xInterval;

                        //the y distance is the ymin + the y max (maybe subtract this for this condition)
                        yDistance = Math.Abs(yMin) + Math.Abs(yMax);

                        //number of ticks is the distance / the interval the user entered
                        numberOfYTicks = yDistance / yInterval;


                        //draw ticks on bottom of screen ---causes screen to be black?
                        for (int i = 0; i <= numberOfXTicks; i++)
                        {
                            graphics.DrawLine(graphPen, i * (graph.Width) / numberOfXTicks, (graph.Height) - numberOfXTicks,
                                                        i * (graph.Width) / numberOfXTicks, (graph.Height) + numberOfXTicks);


                        }
                        for (int i = 0; i <= numberOfYTicks; i++)
                        {
                            graphics.DrawLine(graphPen, (graph.Width / 2) + numberOfYTicks, i * (graph.Height) / numberOfYTicks,
                                                       (graph.Width / 2) - numberOfYTicks, i * (graph.Height) / numberOfYTicks);
                        }

                    }
                    if(yMax < 0)
                    {
                        isYMaxSmall0 = true;
                        
                        //set the x & y origin for graph
                        graph2xOrigin = graph.Width / 2;
                        graph2yOrigin = 0;

                        graphics.DrawLine(graphPen, graph.Width / 2, 0, graph.Width / 2, graph.Height);

                        //the x distance is just the width of the drawing plane
                        xDistance = Math.Abs(yMin) + Math.Abs(yMax);

                        //number of ticks we should draw is the width / the interval the user entered
                        numberOfXTicks = xDistance / xInterval;

                        //the y distance is the ymin + the y max (maybe subtract this for this condition)
                        yDistance = Math.Abs(yMin) + Math.Abs(yMax);

                        //number of ticks is the distance / the interval the user entered
                        numberOfYTicks = yDistance / yInterval;


                        //draw ticks on top of screen
                        for (int i = 0; i <= numberOfXTicks; i++)
                        {
                            graphics.DrawLine(graphPen, i * (graph.Width) / numberOfXTicks, 0 - numberOfXTicks,
                                                        i * (graph.Width) / numberOfXTicks, 0 + numberOfXTicks);


                        }
                        for (int i = 0; i <= numberOfYTicks; i++)
                        {
                            graphics.DrawLine(graphPen, (graph.Width / 2) + numberOfYTicks, i * (graph.Height) / numberOfYTicks,
                                                       (graph.Width / 2) - numberOfYTicks, i * (graph.Height) / numberOfYTicks);
                        }

                    }

                }
                else if ((xMin > 0 || xMax < 0) && (yMin == 0 && yMax == 0))
                {
                    
                    graphics.DrawLine(graphPen, 0, graph.Height / 2, graph.Width, graph.Height / 2);

                    //if xMin is greater than 0, then we want the right side of the graph |_____
                    //                                                                    |
                    //is xMax is less than 0, we want the left side of the graph _____|
                    //                                                                |
                    //only draw the x-axis
                    if (xMin > 0)
                    {
                        isXMinGreat0 = true;

                        //set the x & y origin for graph
                        graph3xOrigin = 0;
                        graph3yOrigin = graph.Height /2;


                        //the x distance is just the width of the drawing plane
                        xDistance = Math.Abs(xMin) + Math.Abs(xMax);

                        //number of ticks we should draw is the width / the interval the user entered
                        numberOfXTicks = xDistance / xInterval;

                        //the y distance is the ymin + the y max (maybe subtract this for this condition)
                        yDistance = Math.Abs(xMin) + Math.Abs(xMax);

                        //number of ticks is the distance / the interval the user entered
                        numberOfYTicks = yDistance / yInterval;

                        //draw ticks on sides of screen
                        for (int i = 0; i <= numberOfXTicks; i++)
                        {
                            graphics.DrawLine(graphPen, i * (graph.Width) / numberOfXTicks, (graph.Height / 2) - numberOfXTicks,
                                                        i * (graph.Width) / numberOfXTicks, (graph.Height / 2) + numberOfXTicks);
                        }
                        for (int i = 0; i <= numberOfYTicks; i++)
                        {
                            graphics.DrawLine(graphPen, 0 + numberOfYTicks, i * (graph.Height) / numberOfYTicks,
                                                       0 - numberOfYTicks, i * (graph.Height) / numberOfYTicks);
                        }


                    }
                    if (xMax < 0)
                    {
                        isXMaxSmall0 = true;

                        //set the x & y origin for graph
                        graph4xOrigin = graph.Width;
                        graph4yOrigin = graph.Height / 2;

                        //the x distance is just the width of the drawing plane
                        xDistance = Math.Abs(xMin) + Math.Abs(xMax);

                        //number of ticks we should draw is the width / the interval the user entered
                        numberOfXTicks = xDistance / xInterval;

                        //the y distance is the ymin + the y max (maybe subtract this for this condition)
                        yDistance = Math.Abs(xMin) + Math.Abs(xMax);

                        //number of ticks is the distance / the interval the user entered
                        numberOfYTicks = yDistance / yInterval;

                        //draw ticks on sides of screen
                        for (int i = 0; i <= numberOfXTicks; i++)
                        {
                            graphics.DrawLine(graphPen, i * (graph.Width) / numberOfXTicks, (graph.Height / 2) - numberOfXTicks,
                                                        i * (graph.Width) / numberOfXTicks, (graph.Height / 2) + numberOfXTicks);
                        }
                        for (int i = 0; i <= numberOfYTicks; i++)
                        {
                            graphics.DrawLine(graphPen, graph.Width + numberOfYTicks, i * (graph.Height) / numberOfYTicks,
                                                       graph.Width - numberOfYTicks, i * (graph.Height) / numberOfYTicks);
                        }
                    }
                }
                else if ((xMin > 0 && yMin > 0) || (xMax < 0 && yMin > 0) || (xMax < 0 && yMax < 0) || (xMin > 0 && yMax < 0))
                {
                    //draw neither axis and just draw ticks
                }
                //draw the graph normally
                else
                {
                    if ((xMin != 0 && xMax != 0 && yMin != 0 && yMax != 0)  &&  (xMin <= 0 && yMin <= 0) || (yMax > 0 && xMax > 0))
                    {
                        isNormalGraph = true;
                        //find the distance between the y points
                        yDistance = Math.Abs(yMin) + Math.Abs(yMax);
                        numberOfYTicks = yDistance / yInterval;

                        //find the distance between the x points
                        xDistance = Math.Abs(xMin) + Math.Abs(xMax);
                        numberOfXTicks = xDistance / xInterval;

                        //draw the x & y lines of the graph in the middle of the drawing plane
                        graphics.DrawLine(graphPen, graph.Width / 2, 0, graph.Width / 2, graph.Height);
                        graphics.DrawLine(graphPen, 0, graph.Height / 2, graph.Width, graph.Height / 2);


                        //draw the tick marks
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
                    }
                }
                
            }
            //LINEAR EQUATION GRAPHING
            if (linear_riseValue.TextLength != 0 && linear_runValue.TextLength != 0 && linear_yPointVal.TextLength != 0 && linear_xPointVal.TextLength != 0)
            {
                //grab the info entered for the equation 
                int rise = int.Parse(linear_riseValue.Text);
                int run = int.Parse(linear_runValue.Text);
                int yPoint = int.Parse(linear_yPointVal.Text);
                int xPoint = int.Parse(linear_xPointVal.Text);

                int xValue = 0;
                int yValue = 0;
                int xOrigin = 0;
                int yOrigin = 0;

                //depending on what graph we have, we need to adjust the origin
                if(isNormalGraph)
                {
                    xOrigin = graph.Width / 2;
                    yOrigin = graph.Height / 2;
                }
                else if(isYMinGreat0)
                {
                    xOrigin = graph1xOrigin;
                    yOrigin = graph1yOrigin;
                }
                else if(isYMaxSmall0)
                {
                    xOrigin = graph2xOrigin;
                    yOrigin = graph2yOrigin;
                }
                else if(isXMinGreat0)
                {

                    xOrigin = graph3xOrigin;
                    yOrigin = graph3yOrigin;

                }
                else if(isXMaxSmall0)
                {
                    xOrigin = graph4xOrigin;
                    yOrigin = graph4yOrigin;
                }

                
                //NOTES:
                //might have to adjust the points that are calculated cause if there is no x or no y, we can't add or subtract from that point?

                xValue = (xOrigin + (graph.Width / numberOfXTicks) * xPoint);
                yValue = (yOrigin - (graph.Height / numberOfYTicks) * yPoint);
                run = (graph.Width / xInterval) * run;
                rise = (graph.Height / yInterval) * rise;

                //first xpoint is going to be xOrigin + (graphWidth / xinterval)xPoint)
                //first ypoiint is going to be yOrigin + (yHeight / yInterval)yPoint)
                Point yIntercept = new Point(xValue, yValue);
                Point point1 = new Point(xValue + run, yValue - rise);

                //another point to extend the linear line
                Point point2 = new Point(xValue - run, yValue + rise);

               if (isDown == true)
               {
                    //depending on what color choice/radio button was clicked that is the color we will draw in
                    if (redColorRadioButton_Linear.Checked && redColorRadioButton_Linear.Enabled)
                    {
                        using (Pen linearPen = new Pen(Color.Red))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, yIntercept, point1);
                            graphics.DrawLine(linearPen, point1, point2);
                        }
                    }

                    if (blueColorRadioButton_Linear.Checked && blueColorRadioButton_Linear.Enabled)
                    {
                        using (Pen linearPen = new Pen(Color.Blue))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, yIntercept, point1);
                            graphics.DrawLine(linearPen, point1, point2);
                        }
                    }
                    if (greenColorRadioButton_Linear.Checked && greenColorRadioButton_Linear.Enabled)
                    {
                        using (Pen linearPen = new Pen(Color.Green))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, yIntercept, point1);
                            graphics.DrawLine(linearPen, point1, point2);
                        }
                    }
                    if (blackColorRadioButton_Linear.Checked && blackColorRadioButton_Linear.Enabled)
                    {
                        using (Pen linearPen = new Pen(Color.Black))
                        {
                            //(System.Drawing.Pen pen, int x1, int y1, int x2, int y2);
                            graphics.DrawLine(linearPen, yIntercept, point1);
                            graphics.DrawLine(linearPen, point1, point2);
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
            
            //QUADRATIC EQUATION GRAPHING 
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

                if (isDown == true)
                { 
                    if (RedColorRadioButton_Quadratic.Checked && RedColorRadioButton_Quadratic.Enabled)
                    {
                        e.Graphics.DrawCurve(redPen, Point);
                    }
                    else if (BlueColorRadioButton_Quadratic.Checked && BlueColorRadioButton_Quadratic.Enabled)
                    {
                        e.Graphics.DrawCurve(bluePen, Point);
                    }
                    else if (GreenColorRadioButton_Quadratic.Checked && GreenColorRadioButton_Quadratic.Enabled)
                    {
                        e.Graphics.DrawCurve(greenPen, Point);
                    }
                    else if (BlackColorRadioButton_Quadratic.Checked && BlackColorRadioButton_Quadratic.Enabled)
                    {
                        e.Graphics.DrawCurve(blackPen, Point);
                    }
                    else
                    {
                        testOutput.AppendText("Please Choose a Color");
                    }
                }

            }

            //CUBIC EQUATION GRAPHING
            if (cubic_AValue.TextLength != 0 && cubic_BValue.TextLength != 0 && cubic_CValue.TextLength != 0 && cubic_DValue.TextLength != 0)
            {
                //the y-intercept is always whatever d is since we set x = 0 to find equation, it cancels everything out but D value
                int yIntercept = int.Parse(cubic_DValue.Text);
                int dValue = int.Parse(cubic_DValue.Text);
                int aValue = int.Parse(cubic_AValue.Text);
                int bValue = int.Parse(cubic_BValue.Text);
                int cValue = int.Parse(cubic_CValue.Text);

                int xOrigin = 0;
                int yOrigin = 0;

                //depending on what graph we have, we need to adjust the origin
                if (isNormalGraph)
                {
                    xOrigin = graph.Width / 2;
                    yOrigin = graph.Height / 2;
                }
                else if (isYMinGreat0)
                {
                    xOrigin = graph1xOrigin;
                    yOrigin = graph1yOrigin;
                }
                else if (isYMaxSmall0)
                {
                    xOrigin = graph2xOrigin;
                    yOrigin = graph2yOrigin;
                }
                else if (isXMinGreat0)
                {

                    xOrigin = graph3xOrigin;
                    yOrigin = graph3yOrigin;

                }
                else if (isXMaxSmall0)
                {
                    xOrigin = graph4xOrigin;
                    yOrigin = graph4yOrigin;
                }

                //check to ensure A value is nonzero
                if (aValue == 0)
                {
                    testOutput.AppendText("Sorry, first value cannot be 0, as this would cause this to not be a cubic equation!");
                }

                int yintercept_x = 0;

                int x;
                int y;
                int xPoint;
                int yPoint;
                Point[] Point = new Point[10000];
                int n = 0;

                for (int i = (yintercept_x - 5); i <= (yintercept_x + 5); i++)
                {
                    x = i;
                    y = (aValue * (x * x * x)) + ((bValue * (x * x)) + cValue * x + dValue);

                    if (x == 0)
                    {
                        xPoint = graph.Width / 2;
                    }
                    else
                    {
                        //need to adjust this based on the type of graph (how the ticks are drawn)
                        //getting an x point here i think?
                        xPoint = (xOrigin + (graph.Width / xDistance * x));
                    }

                    if (y == 0)
                    {
                        yPoint = graph.Height / 2;
                    }
                    else
                    {
                        //need to adjust this based on the type of graph (how the ticks are drawn)
                        yPoint= (yOrigin - (graph.Height / yDistance * y));
                    }

                    Point[n] = new Point(xPoint, yPoint);
                    n++;

                }
                if (isDown == true)
                {
                    //depending on what color choice/radio button was clicked that is the color we will draw in
                    if (redColorRadioButton_Cubic.Checked && redColorRadioButton_Cubic.Enabled)
                    {
                        using (Pen cubicPen = new Pen(Color.Red))
                        {
                            e.Graphics.DrawCurve(cubicPen, Point);
                        }
                    }
                    else if (blueColorRadioButton_Cubic.Checked && blueColorRadioButton_Cubic.Enabled)
                    {
                        using (Pen cubicPen = new Pen(Color.Blue))
                        {
                            e.Graphics.DrawCurve(cubicPen, Point);
                        }
                    }
                    else if (greenColorRadioButton_Cubic.Checked && greenColorRadioButton_Cubic.Enabled)
                    {
                        using (Pen cubicPen = new Pen(Color.Green))
                        {
                            e.Graphics.DrawCurve(cubicPen, Point);
                        }
                    }
                    else if (blackColorRadioButton_Cubic.Checked && blackColorRadioButton_Cubic.Enabled)
                    {
                        using (Pen cubicPen = new Pen(Color.Black))
                        {
                            e.Graphics.DrawCurve(cubicPen, Point);
                        }
                    }
                    else
                    {
                        testOutput.AppendText("Please Choose a Color");
                    }
                }
            }
           

            //CIRCLE EQUATIONS GRAPHING
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
                    H_Value = (graph.Width / 2 + (graph.Width / xDistance * H_Value));
                }
                if (K_Value == 0)
                {
                    K_Value = graph.Width / 2;
                }
                else
                {
                    K_Value = (graph.Width / 2 - (graph.Width / yDistance * K_Value));
                }
                if (R_Value == 0)
                {
                    R_Value = H_Value;
                }
                else
                {
                    R_Value = (graph.Width / xDistance * R_Value);
                }
                Pen redPen = new Pen(Color.Red, 3);
                Pen bluePen = new Pen(Color.Blue, 3);
                Pen greenPen = new Pen(Color.Green, 3);

                if (isDown == true)
                {
                    if (RedColorRadioButton_Circle.Checked && RedColorRadioButton_Circle.Enabled)
                    {
                        e.Graphics.DrawEllipse(redPen, H_Value - R_Value, K_Value - R_Value,
                           R_Value + R_Value, R_Value + R_Value);
                    }
                    else if (BlueColorRadioButton_Circle.Checked && BlueColorRadioButton_Circle.Enabled)
                    {
                        e.Graphics.DrawEllipse(bluePen, H_Value - R_Value, K_Value - R_Value,
                          R_Value + R_Value, R_Value + R_Value);
                    }
                    else if (GreenColorRadioButton_Circle.Checked && GreenColorRadioButton_Circle.Enabled)
                    {
                        e.Graphics.DrawEllipse(greenPen, H_Value - R_Value, K_Value - R_Value,
                          R_Value + R_Value, R_Value + R_Value);
                    }
                    else if (BlackColorRadioButton_Circle.Checked && BlackColorRadioButton_Circle.Enabled)
                    {
                        e.Graphics.DrawEllipse(blackPen, H_Value - R_Value, K_Value - R_Value,
                          R_Value + R_Value, R_Value + R_Value);
                    }
                    else
                    {
                        testOutput.AppendText("Please Choose a Color");
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
            //xLabelMin.Text = xMin;
        }

        //changes the x max value on the graph depending what user enters
        private void xMaxValue_ValueChanged(object sender, EventArgs e)
        {
            string xMax = xMaxValue.Value.ToString();
            //xLabelMax.Text = xMax;

        }

        //changes y min value on the graph depending what user enteres
        private void yMinValue_ValueChanged(object sender, EventArgs e)
        {
            string yMin = yMinValue.Value.ToString();
            //yLabelMin.Text = yMin;
        }
        //changes y max value on the graph depending what user enters
        private void yMaxValue_ValueChanged(object sender, EventArgs e)
        {
            string yMax = yMaxValue.Value.ToString();
            //yLabelMax.Text = yMax;
        }

        static double findXIntercept(double a, double b, double c, double d)
        {
            double xIntercept;

            //get cubed root of value a
            double cubedRoot  = (Math.Pow(a,(1.0 / 3.0)));

            //get square root of value b
            double squareRoot = (Math.Pow(b, (1.0 / 2.0)));

            xIntercept = cubedRoot + squareRoot + c + d;
            return xIntercept;
        }

        //the following 4 functions adjust the color options availble for when linear colors are selected
        private void blueColorRadioButton_Linear_CheckedChanged(object sender, EventArgs e)
        {
            //if the user chose blue for linear, disable it for all other graphs
            if (blueColorRadioButton_Linear.Checked)
            {
                BlueColorRadioButton_Quadratic.Enabled = false;
                BlueColorRadioButton_Circle.Enabled = false;
                blueColorRadioButton_Cubic.Enabled = false;
            }
            if(!blueColorRadioButton_Linear.Checked)
            {
                BlueColorRadioButton_Quadratic.Enabled = true;
                BlueColorRadioButton_Circle.Enabled = true;
                blueColorRadioButton_Cubic.Enabled = true;
            }
        }

        private void redColorRadioButton_Linear_CheckedChanged(object sender, EventArgs e)
        {
            //if the user chose red for linear, disable it for all other graphs
            if (redColorRadioButton_Linear.Checked)
            {
                RedColorRadioButton_Quadratic.Enabled = false;
                RedColorRadioButton_Circle.Enabled = false;
                redColorRadioButton_Cubic.Enabled = false;
            }
            if (!redColorRadioButton_Linear.Checked)
            {
                RedColorRadioButton_Quadratic.Enabled = true;
                RedColorRadioButton_Circle.Enabled = true;
                redColorRadioButton_Cubic.Enabled = true;
            }

        }

        private void greenColorRadioButton_Linear_CheckedChanged(object sender, EventArgs e)
        {
            if (greenColorRadioButton_Linear.Checked)
            {
                GreenColorRadioButton_Quadratic.Enabled = false;
                GreenColorRadioButton_Circle.Enabled = false;
                greenColorRadioButton_Cubic.Enabled = false;
            }
            if (!greenColorRadioButton_Linear.Checked)
            {
                GreenColorRadioButton_Quadratic.Enabled = true;
                GreenColorRadioButton_Circle.Enabled = true;
                greenColorRadioButton_Cubic.Enabled = true;
            }

        }

        private void blackColorRadioButton_Linear_CheckedChanged(object sender, EventArgs e)
        {

            if (blackColorRadioButton_Linear.Checked)
            {
                BlackColorRadioButton_Quadratic.Enabled = false;
                BlackColorRadioButton_Circle.Enabled = false;
                blackColorRadioButton_Cubic.Enabled = false;
            }
            if (!blackColorRadioButton_Linear.Checked)
            {
                BlackColorRadioButton_Quadratic.Enabled = true;
                BlackColorRadioButton_Circle.Enabled = true;
                blackColorRadioButton_Cubic.Enabled = true;
            }
        }

        //the following 4 functions adjust the color options available for when cubic colors are selected
        private void blueColorRadioButton_Cubic_CheckedChanged(object sender, EventArgs e)
        {
            //if the user chose blue for cubic, disable it for all other graphs
            if (blueColorRadioButton_Cubic.Checked)
            {
                BlueColorRadioButton_Quadratic.Enabled = false;
                BlueColorRadioButton_Circle.Enabled = false;
                blueColorRadioButton_Linear.Enabled = false;
            }
            if (!blueColorRadioButton_Cubic.Checked)
            {
                BlueColorRadioButton_Quadratic.Enabled = true;
                BlueColorRadioButton_Circle.Enabled = true;
                blueColorRadioButton_Linear.Enabled = true;
            }
        }

        private void redColorRadioButton_Cubic_CheckedChanged(object sender, EventArgs e)
        {
            //if the user chose red for cubic, disable it for all other graphs
            if (redColorRadioButton_Cubic.Checked)
            {
                RedColorRadioButton_Quadratic.Enabled = false;
                RedColorRadioButton_Circle.Enabled = false;
                redColorRadioButton_Linear.Enabled = false;
            }
            if (!redColorRadioButton_Cubic.Checked)
            {
                RedColorRadioButton_Quadratic.Enabled = true;
                RedColorRadioButton_Circle.Enabled = true;
                redColorRadioButton_Linear.Enabled = true;
            }
        }

        private void greenColorRadioButton_Cubic_CheckedChanged(object sender, EventArgs e)
        {
            if (greenColorRadioButton_Cubic.Checked)
            {
                GreenColorRadioButton_Quadratic.Enabled = false;
                GreenColorRadioButton_Circle.Enabled = false;
                greenColorRadioButton_Linear.Enabled = false;
            }
            if (!greenColorRadioButton_Cubic.Checked)
            {
                GreenColorRadioButton_Quadratic.Enabled = true;
                GreenColorRadioButton_Circle.Enabled = true;
                greenColorRadioButton_Linear.Enabled = true;
            }

        }

        private void blackColorRadioButton_Cubic_CheckedChanged(object sender, EventArgs e)
        {
            if (blackColorRadioButton_Cubic.Checked)
            {
                BlackColorRadioButton_Quadratic.Enabled = false;
                BlackColorRadioButton_Circle.Enabled = false;
                blackColorRadioButton_Linear.Enabled = false;
            }
            if (!blackColorRadioButton_Linear.Checked)
            {
                BlackColorRadioButton_Quadratic.Enabled = true;
                BlackColorRadioButton_Circle.Enabled = true;
                blackColorRadioButton_Linear.Enabled = true;
            }
        }

        //the following 4 functions adjust the color options available for when quadratic colors are selected

        private void BlueColorRadioButton_Quadratic_CheckedChanged(object sender, EventArgs e)
        {
            if (BlueColorRadioButton_Quadratic.Checked)
            {
                blueColorRadioButton_Cubic.Enabled = false;
                BlueColorRadioButton_Circle.Enabled = false;
                blueColorRadioButton_Linear.Enabled = false;
            }
            if (!BlueColorRadioButton_Quadratic.Checked)
            {
                blueColorRadioButton_Cubic.Enabled = true;
                BlueColorRadioButton_Circle.Enabled = true;
                blueColorRadioButton_Linear.Enabled = true;
            }

        }

        private void RedColorRadioButton_Quadratic_CheckedChanged(object sender, EventArgs e)
        {
            if (RedColorRadioButton_Quadratic.Checked)
            {
                redColorRadioButton_Cubic.Enabled = false;
                RedColorRadioButton_Circle.Enabled = false;
                redColorRadioButton_Linear.Enabled = false;
            }
            if (!RedColorRadioButton_Quadratic.Checked)
            {
                redColorRadioButton_Cubic.Enabled = true;
                RedColorRadioButton_Circle.Enabled = true;
                redColorRadioButton_Linear.Enabled = true;
            }
        }

        private void GreenColorRadioButton_Quadratic_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenColorRadioButton_Quadratic.Checked)
            {
                greenColorRadioButton_Cubic.Enabled = false;
                GreenColorRadioButton_Circle.Enabled = false;
                greenColorRadioButton_Linear.Enabled = false;
            }
            if (!GreenColorRadioButton_Quadratic.Checked)
            {
                greenColorRadioButton_Cubic.Enabled = true;
                GreenColorRadioButton_Circle.Enabled = true;
                greenColorRadioButton_Linear.Enabled = true;
            }
        }

        private void BlackColorRadioButton_Quadratic_CheckedChanged(object sender, EventArgs e)
        {
            if (BlackColorRadioButton_Quadratic.Checked)
            {
                blackColorRadioButton_Cubic.Enabled = false;
                BlackColorRadioButton_Circle.Enabled = false;
                blackColorRadioButton_Linear.Enabled = false;
            }
            if (!BlackColorRadioButton_Quadratic.Checked)
            {
                blackColorRadioButton_Cubic.Enabled = true;
                BlackColorRadioButton_Circle.Enabled = true;
                blackColorRadioButton_Linear.Enabled = true;
            }
        }

        //the following 4 functions adjust the color options available for when circle colors are selected

        private void BlueColorRadioButton_Circle_CheckedChanged(object sender, EventArgs e)
        {
            if (BlueColorRadioButton_Circle.Checked)
            {
                blueColorRadioButton_Cubic.Enabled = false;
                BlueColorRadioButton_Quadratic.Enabled = false;
                blueColorRadioButton_Linear.Enabled = false;
            }
            if (!BlueColorRadioButton_Circle.Checked)
            {
                blueColorRadioButton_Cubic.Enabled = true;
                BlueColorRadioButton_Quadratic.Enabled = true;
                blueColorRadioButton_Linear.Enabled = true;
            }
        }

        private void RedColorRadioButton_Circle_CheckedChanged(object sender, EventArgs e)
        {
            if (RedColorRadioButton_Circle.Checked)
            {
                redColorRadioButton_Cubic.Enabled = false;
                RedColorRadioButton_Quadratic.Enabled = false;
                redColorRadioButton_Linear.Enabled = false;
            }
            if (!RedColorRadioButton_Circle.Checked)
            {
                redColorRadioButton_Cubic.Enabled = true;
                RedColorRadioButton_Quadratic.Enabled = true;
                redColorRadioButton_Linear.Enabled = true;
            }
        }

        private void GreenColorRadioButton_Circle_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenColorRadioButton_Circle.Checked)
            {
                greenColorRadioButton_Cubic.Enabled = false;
                GreenColorRadioButton_Quadratic.Enabled = false;
                greenColorRadioButton_Linear.Enabled = false;
            }
            if (!GreenColorRadioButton_Circle.Checked)
            {
                greenColorRadioButton_Cubic.Enabled = true;
                GreenColorRadioButton_Quadratic.Enabled = true;
                greenColorRadioButton_Linear.Enabled = true;
            }
        }

        private void BlackColorRadioButton_Circle_CheckedChanged(object sender, EventArgs e)
        {
            if (BlackColorRadioButton_Circle.Checked)
            {
                blackColorRadioButton_Cubic.Enabled = false;
                BlackColorRadioButton_Quadratic.Enabled = false;
                blackColorRadioButton_Linear.Enabled = false;
            }
            if (!BlackColorRadioButton_Circle.Checked)
            {
                blackColorRadioButton_Cubic.Enabled = true;
                BlackColorRadioButton_Quadratic.Enabled = true;
                blackColorRadioButton_Linear.Enabled = true;
            }
        }
    }


}
