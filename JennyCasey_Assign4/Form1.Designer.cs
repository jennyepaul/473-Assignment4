
namespace JennyCasey_Assign4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.graph = new System.Windows.Forms.PictureBox();
            this.equation1 = new System.Windows.Forms.Label();
            this.equation1_mx = new System.Windows.Forms.Label();
            this.linear_riseValue = new System.Windows.Forms.TextBox();
            this.linear_yPointVal = new System.Windows.Forms.TextBox();
            this.linearEquation = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linear_xPointVal = new System.Windows.Forms.TextBox();
            this.linear_runValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.graphButton = new System.Windows.Forms.Button();
            this.cubicEquation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorBox_Linear = new System.Windows.Forms.GroupBox();
            this.blackColorRadioButton_Linear = new System.Windows.Forms.RadioButton();
            this.redColorRadioButton_Linear = new System.Windows.Forms.RadioButton();
            this.greenColorRadioButton_Linear = new System.Windows.Forms.RadioButton();
            this.blueColorRadioButton_Linear = new System.Windows.Forms.RadioButton();
            this.colorBox_Cubic = new System.Windows.Forms.GroupBox();
            this.blackColorRadioButton_Cubic = new System.Windows.Forms.RadioButton();
            this.redColorRadioButton_Cubic = new System.Windows.Forms.RadioButton();
            this.greenColorRadioButton_Cubic = new System.Windows.Forms.RadioButton();
            this.blueColorRadioButton_Cubic = new System.Windows.Forms.RadioButton();
            this.equationColumnLabel = new System.Windows.Forms.Label();
            this.colorToDrawWith = new System.Windows.Forms.Label();
            this.testOutput = new System.Windows.Forms.RichTextBox();
            this.quadraticEquation = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.circleEquation = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.xMinValue = new System.Windows.Forms.NumericUpDown();
            this.xMinLabel = new System.Windows.Forms.Label();
            this.xIntervalValue = new System.Windows.Forms.NumericUpDown();
            this.xMaxValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yMinValue = new System.Windows.Forms.NumericUpDown();
            this.yMaxValue = new System.Windows.Forms.NumericUpDown();
            this.yIntervalValue = new System.Windows.Forms.NumericUpDown();
            this.yMinLabel = new System.Windows.Forms.Label();
            this.yMaxLabel = new System.Windows.Forms.Label();
            this.yIntervalLabel = new System.Windows.Forms.Label();
            this.xLabelMax = new System.Windows.Forms.Label();
            this.yLabelMax = new System.Windows.Forms.Label();
            this.xLabelMin = new System.Windows.Forms.Label();
            this.yLabelMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.linearEquation.SuspendLayout();
            this.cubicEquation.SuspendLayout();
            this.colorBox_Linear.SuspendLayout();
            this.colorBox_Cubic.SuspendLayout();
            this.quadraticEquation.SuspendLayout();
            this.circleEquation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xIntervalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yIntervalValue)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(10, 25);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(751, 687);
            this.graph.TabIndex = 0;
            this.graph.TabStop = false;
            this.graph.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Paint);
            // 
            // equation1
            // 
            this.equation1.AutoSize = true;
            this.equation1.Location = new System.Drawing.Point(9, 46);
            this.equation1.Name = "equation1";
            this.equation1.Size = new System.Drawing.Size(31, 17);
            this.equation1.TabIndex = 1;
            this.equation1.Text = "y = ";
            // 
            // equation1_mx
            // 
            this.equation1_mx.AutoSize = true;
            this.equation1_mx.Location = new System.Drawing.Point(77, 44);
            this.equation1_mx.Name = "equation1_mx";
            this.equation1_mx.Size = new System.Drawing.Size(26, 17);
            this.equation1_mx.TabIndex = 2;
            this.equation1_mx.Text = "x +";
            // 
            // linear_riseValue
            // 
            this.linear_riseValue.Location = new System.Drawing.Point(50, 22);
            this.linear_riseValue.Name = "linear_riseValue";
            this.linear_riseValue.Size = new System.Drawing.Size(25, 22);
            this.linear_riseValue.TabIndex = 3;
            // 
            // linear_yPointVal
            // 
            this.linear_yPointVal.Location = new System.Drawing.Point(109, 22);
            this.linear_yPointVal.Name = "linear_yPointVal";
            this.linear_yPointVal.Size = new System.Drawing.Size(25, 22);
            this.linear_yPointVal.TabIndex = 4;
            // 
            // linearEquation
            // 
            this.linearEquation.Controls.Add(this.label11);
            this.linearEquation.Controls.Add(this.linear_xPointVal);
            this.linearEquation.Controls.Add(this.linear_runValue);
            this.linearEquation.Controls.Add(this.label10);
            this.linearEquation.Controls.Add(this.equation1);
            this.linearEquation.Controls.Add(this.linear_yPointVal);
            this.linearEquation.Controls.Add(this.linear_riseValue);
            this.linearEquation.Controls.Add(this.equation1_mx);
            this.linearEquation.Location = new System.Drawing.Point(771, 65);
            this.linearEquation.Name = "linearEquation";
            this.linearEquation.Size = new System.Drawing.Size(200, 91);
            this.linearEquation.TabIndex = 5;
            this.linearEquation.TabStop = false;
            this.linearEquation.Text = "Linear Equation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "-----";
            // 
            // linear_xPointVal
            // 
            this.linear_xPointVal.Location = new System.Drawing.Point(109, 63);
            this.linear_xPointVal.Name = "linear_xPointVal";
            this.linear_xPointVal.Size = new System.Drawing.Size(25, 22);
            this.linear_xPointVal.TabIndex = 7;
            // 
            // linear_runValue
            // 
            this.linear_runValue.Location = new System.Drawing.Point(50, 58);
            this.linear_runValue.Name = "linear_runValue";
            this.linear_runValue.Size = new System.Drawing.Size(25, 22);
            this.linear_runValue.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "-----";
            // 
            // graphButton
            // 
            this.graphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphButton.Location = new System.Drawing.Point(771, 676);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(94, 36);
            this.graphButton.TabIndex = 6;
            this.graphButton.Text = "Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphButton_MouseDown);
            this.graphButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphButton_MouseUp);
            // 
            // cubicEquation
            // 
            this.cubicEquation.Controls.Add(this.label1);
            this.cubicEquation.Controls.Add(this.textBox1);
            this.cubicEquation.Controls.Add(this.textBox2);
            this.cubicEquation.Controls.Add(this.label2);
            this.cubicEquation.Location = new System.Drawing.Point(771, 162);
            this.cubicEquation.Name = "cubicEquation";
            this.cubicEquation.Size = new System.Drawing.Size(200, 78);
            this.cubicEquation.TabIndex = 7;
            this.cubicEquation.TabStop = false;
            this.cubicEquation.Text = "Cubic Equation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "y = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "x +";
            // 
            // colorBox_Linear
            // 
            this.colorBox_Linear.Controls.Add(this.blackColorRadioButton_Linear);
            this.colorBox_Linear.Controls.Add(this.redColorRadioButton_Linear);
            this.colorBox_Linear.Controls.Add(this.greenColorRadioButton_Linear);
            this.colorBox_Linear.Controls.Add(this.blueColorRadioButton_Linear);
            this.colorBox_Linear.Location = new System.Drawing.Point(1020, 65);
            this.colorBox_Linear.Name = "colorBox_Linear";
            this.colorBox_Linear.Size = new System.Drawing.Size(230, 80);
            this.colorBox_Linear.TabIndex = 8;
            this.colorBox_Linear.TabStop = false;
            this.colorBox_Linear.Text = "Color:";
            // 
            // blackColorRadioButton_Linear
            // 
            this.blackColorRadioButton_Linear.AutoSize = true;
            this.blackColorRadioButton_Linear.Location = new System.Drawing.Point(82, 49);
            this.blackColorRadioButton_Linear.Name = "blackColorRadioButton_Linear";
            this.blackColorRadioButton_Linear.Size = new System.Drawing.Size(63, 21);
            this.blackColorRadioButton_Linear.TabIndex = 3;
            this.blackColorRadioButton_Linear.TabStop = true;
            this.blackColorRadioButton_Linear.Text = "Black";
            this.blackColorRadioButton_Linear.UseVisualStyleBackColor = true;
            // 
            // redColorRadioButton_Linear
            // 
            this.redColorRadioButton_Linear.AutoSize = true;
            this.redColorRadioButton_Linear.Location = new System.Drawing.Point(82, 22);
            this.redColorRadioButton_Linear.Name = "redColorRadioButton_Linear";
            this.redColorRadioButton_Linear.Size = new System.Drawing.Size(55, 21);
            this.redColorRadioButton_Linear.TabIndex = 2;
            this.redColorRadioButton_Linear.TabStop = true;
            this.redColorRadioButton_Linear.Text = "Red";
            this.redColorRadioButton_Linear.UseVisualStyleBackColor = true;
            // 
            // greenColorRadioButton_Linear
            // 
            this.greenColorRadioButton_Linear.AutoSize = true;
            this.greenColorRadioButton_Linear.Location = new System.Drawing.Point(7, 49);
            this.greenColorRadioButton_Linear.Name = "greenColorRadioButton_Linear";
            this.greenColorRadioButton_Linear.Size = new System.Drawing.Size(69, 21);
            this.greenColorRadioButton_Linear.TabIndex = 1;
            this.greenColorRadioButton_Linear.TabStop = true;
            this.greenColorRadioButton_Linear.Text = "Green";
            this.greenColorRadioButton_Linear.UseVisualStyleBackColor = true;
            // 
            // blueColorRadioButton_Linear
            // 
            this.blueColorRadioButton_Linear.AutoSize = true;
            this.blueColorRadioButton_Linear.Location = new System.Drawing.Point(7, 22);
            this.blueColorRadioButton_Linear.Name = "blueColorRadioButton_Linear";
            this.blueColorRadioButton_Linear.Size = new System.Drawing.Size(57, 21);
            this.blueColorRadioButton_Linear.TabIndex = 0;
            this.blueColorRadioButton_Linear.TabStop = true;
            this.blueColorRadioButton_Linear.Text = "Blue";
            this.blueColorRadioButton_Linear.UseVisualStyleBackColor = true;
            // 
            // colorBox_Cubic
            // 
            this.colorBox_Cubic.Controls.Add(this.blackColorRadioButton_Cubic);
            this.colorBox_Cubic.Controls.Add(this.redColorRadioButton_Cubic);
            this.colorBox_Cubic.Controls.Add(this.greenColorRadioButton_Cubic);
            this.colorBox_Cubic.Controls.Add(this.blueColorRadioButton_Cubic);
            this.colorBox_Cubic.Location = new System.Drawing.Point(1020, 162);
            this.colorBox_Cubic.Name = "colorBox_Cubic";
            this.colorBox_Cubic.Size = new System.Drawing.Size(230, 78);
            this.colorBox_Cubic.TabIndex = 9;
            this.colorBox_Cubic.TabStop = false;
            this.colorBox_Cubic.Text = "Color:";
            // 
            // blackColorRadioButton_Cubic
            // 
            this.blackColorRadioButton_Cubic.AutoSize = true;
            this.blackColorRadioButton_Cubic.Location = new System.Drawing.Point(82, 49);
            this.blackColorRadioButton_Cubic.Name = "blackColorRadioButton_Cubic";
            this.blackColorRadioButton_Cubic.Size = new System.Drawing.Size(63, 21);
            this.blackColorRadioButton_Cubic.TabIndex = 3;
            this.blackColorRadioButton_Cubic.TabStop = true;
            this.blackColorRadioButton_Cubic.Text = "Black";
            this.blackColorRadioButton_Cubic.UseVisualStyleBackColor = true;
            // 
            // redColorRadioButton_Cubic
            // 
            this.redColorRadioButton_Cubic.AutoSize = true;
            this.redColorRadioButton_Cubic.Location = new System.Drawing.Point(82, 21);
            this.redColorRadioButton_Cubic.Name = "redColorRadioButton_Cubic";
            this.redColorRadioButton_Cubic.Size = new System.Drawing.Size(55, 21);
            this.redColorRadioButton_Cubic.TabIndex = 2;
            this.redColorRadioButton_Cubic.TabStop = true;
            this.redColorRadioButton_Cubic.Text = "Red";
            this.redColorRadioButton_Cubic.UseVisualStyleBackColor = true;
            // 
            // greenColorRadioButton_Cubic
            // 
            this.greenColorRadioButton_Cubic.AutoSize = true;
            this.greenColorRadioButton_Cubic.Location = new System.Drawing.Point(7, 49);
            this.greenColorRadioButton_Cubic.Name = "greenColorRadioButton_Cubic";
            this.greenColorRadioButton_Cubic.Size = new System.Drawing.Size(69, 21);
            this.greenColorRadioButton_Cubic.TabIndex = 1;
            this.greenColorRadioButton_Cubic.TabStop = true;
            this.greenColorRadioButton_Cubic.Text = "Green";
            this.greenColorRadioButton_Cubic.UseVisualStyleBackColor = true;
            // 
            // blueColorRadioButton_Cubic
            // 
            this.blueColorRadioButton_Cubic.AutoSize = true;
            this.blueColorRadioButton_Cubic.Location = new System.Drawing.Point(7, 22);
            this.blueColorRadioButton_Cubic.Name = "blueColorRadioButton_Cubic";
            this.blueColorRadioButton_Cubic.Size = new System.Drawing.Size(57, 21);
            this.blueColorRadioButton_Cubic.TabIndex = 0;
            this.blueColorRadioButton_Cubic.TabStop = true;
            this.blueColorRadioButton_Cubic.Text = "Blue";
            this.blueColorRadioButton_Cubic.UseVisualStyleBackColor = true;
            // 
            // equationColumnLabel
            // 
            this.equationColumnLabel.AutoSize = true;
            this.equationColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equationColumnLabel.Location = new System.Drawing.Point(767, 25);
            this.equationColumnLabel.Name = "equationColumnLabel";
            this.equationColumnLabel.Size = new System.Drawing.Size(185, 24);
            this.equationColumnLabel.TabIndex = 10;
            this.equationColumnLabel.Text = "Equation to Graph:";
            // 
            // colorToDrawWith
            // 
            this.colorToDrawWith.AutoSize = true;
            this.colorToDrawWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorToDrawWith.Location = new System.Drawing.Point(1020, 25);
            this.colorToDrawWith.Name = "colorToDrawWith";
            this.colorToDrawWith.Size = new System.Drawing.Size(205, 24);
            this.colorToDrawWith.TabIndex = 11;
            this.colorToDrawWith.Text = "Color to Draw Graph:";
            // 
            // testOutput
            // 
            this.testOutput.Location = new System.Drawing.Point(771, 609);
            this.testOutput.Name = "testOutput";
            this.testOutput.Size = new System.Drawing.Size(467, 61);
            this.testOutput.TabIndex = 12;
            this.testOutput.Text = "";
            // 
            // quadraticEquation
            // 
            this.quadraticEquation.Controls.Add(this.label3);
            this.quadraticEquation.Controls.Add(this.textBox3);
            this.quadraticEquation.Controls.Add(this.textBox4);
            this.quadraticEquation.Controls.Add(this.label4);
            this.quadraticEquation.Location = new System.Drawing.Point(771, 255);
            this.quadraticEquation.Name = "quadraticEquation";
            this.quadraticEquation.Size = new System.Drawing.Size(200, 78);
            this.quadraticEquation.TabIndex = 13;
            this.quadraticEquation.TabStop = false;
            this.quadraticEquation.Text = "Quadratic Equation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "y = ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(46, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 22);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "x +";
            // 
            // circleEquation
            // 
            this.circleEquation.Controls.Add(this.label5);
            this.circleEquation.Controls.Add(this.textBox5);
            this.circleEquation.Controls.Add(this.textBox6);
            this.circleEquation.Controls.Add(this.label6);
            this.circleEquation.Location = new System.Drawing.Point(771, 350);
            this.circleEquation.Name = "circleEquation";
            this.circleEquation.Size = new System.Drawing.Size(200, 78);
            this.circleEquation.TabIndex = 8;
            this.circleEquation.TabStop = false;
            this.circleEquation.Text = "Circle Equation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "y = ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(25, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(46, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(25, 22);
            this.textBox6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "x +";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(1020, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 78);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Black";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(82, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Red";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 21);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Green";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 21);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Blue";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Location = new System.Drawing.Point(1020, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 78);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color:";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(82, 49);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(63, 21);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Black";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(82, 21);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 21);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Red";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(7, 49);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(69, 21);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Green";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 22);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(57, 21);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Blue";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(767, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Graph Size Specifications:";
            // 
            // xMinValue
            // 
            this.xMinValue.Location = new System.Drawing.Point(816, 480);
            this.xMinValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMinValue.Name = "xMinValue";
            this.xMinValue.Size = new System.Drawing.Size(49, 22);
            this.xMinValue.TabIndex = 16;
            this.xMinValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xMinValue.ValueChanged += new System.EventHandler(this.xMinValue_ValueChanged);
            // 
            // xMinLabel
            // 
            this.xMinLabel.AutoSize = true;
            this.xMinLabel.Location = new System.Drawing.Point(774, 485);
            this.xMinLabel.Name = "xMinLabel";
            this.xMinLabel.Size = new System.Drawing.Size(36, 17);
            this.xMinLabel.TabIndex = 17;
            this.xMinLabel.Text = "xMin";
            // 
            // xIntervalValue
            // 
            this.xIntervalValue.Location = new System.Drawing.Point(815, 537);
            this.xIntervalValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xIntervalValue.Name = "xIntervalValue";
            this.xIntervalValue.Size = new System.Drawing.Size(49, 22);
            this.xIntervalValue.TabIndex = 18;
            this.xIntervalValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xMaxValue
            // 
            this.xMaxValue.Location = new System.Drawing.Point(815, 508);
            this.xMaxValue.Name = "xMaxValue";
            this.xMaxValue.Size = new System.Drawing.Size(50, 22);
            this.xMaxValue.TabIndex = 19;
            this.xMaxValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xMaxValue.ValueChanged += new System.EventHandler(this.xMaxValue_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(775, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "xMax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(754, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "xInterval";
            // 
            // yMinValue
            // 
            this.yMinValue.Location = new System.Drawing.Point(976, 480);
            this.yMinValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yMinValue.Name = "yMinValue";
            this.yMinValue.Size = new System.Drawing.Size(49, 22);
            this.yMinValue.TabIndex = 22;
            this.yMinValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yMinValue.ValueChanged += new System.EventHandler(this.yMinValue_ValueChanged);
            // 
            // yMaxValue
            // 
            this.yMaxValue.Location = new System.Drawing.Point(976, 508);
            this.yMaxValue.Name = "yMaxValue";
            this.yMaxValue.Size = new System.Drawing.Size(49, 22);
            this.yMaxValue.TabIndex = 23;
            this.yMaxValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yMaxValue.ValueChanged += new System.EventHandler(this.yMaxValue_ValueChanged);
            // 
            // yIntervalValue
            // 
            this.yIntervalValue.Location = new System.Drawing.Point(976, 537);
            this.yIntervalValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yIntervalValue.Name = "yIntervalValue";
            this.yIntervalValue.Size = new System.Drawing.Size(49, 22);
            this.yIntervalValue.TabIndex = 24;
            this.yIntervalValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yMinLabel
            // 
            this.yMinLabel.AutoSize = true;
            this.yMinLabel.Location = new System.Drawing.Point(934, 485);
            this.yMinLabel.Name = "yMinLabel";
            this.yMinLabel.Size = new System.Drawing.Size(37, 17);
            this.yMinLabel.TabIndex = 25;
            this.yMinLabel.Text = "yMin";
            // 
            // yMaxLabel
            // 
            this.yMaxLabel.AutoSize = true;
            this.yMaxLabel.Location = new System.Drawing.Point(933, 510);
            this.yMaxLabel.Name = "yMaxLabel";
            this.yMaxLabel.Size = new System.Drawing.Size(40, 17);
            this.yMaxLabel.TabIndex = 26;
            this.yMaxLabel.Text = "yMax";
            // 
            // yIntervalLabel
            // 
            this.yIntervalLabel.AutoSize = true;
            this.yIntervalLabel.Location = new System.Drawing.Point(912, 539);
            this.yIntervalLabel.Name = "yIntervalLabel";
            this.yIntervalLabel.Size = new System.Drawing.Size(61, 17);
            this.yIntervalLabel.TabIndex = 27;
            this.yIntervalLabel.Text = "yInterval";
            // 
            // xLabelMax
            // 
            this.xLabelMax.AutoSize = true;
            this.xLabelMax.Location = new System.Drawing.Point(721, 350);
            this.xLabelMax.Name = "xLabelMax";
            this.xLabelMax.Size = new System.Drawing.Size(44, 17);
            this.xLabelMax.TabIndex = 28;
            this.xLabelMax.Text = "NULL";
            // 
            // yLabelMax
            // 
            this.yLabelMax.AutoSize = true;
            this.yLabelMax.Location = new System.Drawing.Point(338, 25);
            this.yLabelMax.Name = "yLabelMax";
            this.yLabelMax.Size = new System.Drawing.Size(44, 17);
            this.yLabelMax.TabIndex = 29;
            this.yLabelMax.Text = "NULL";
            // 
            // xLabelMin
            // 
            this.xLabelMin.AutoSize = true;
            this.xLabelMin.Location = new System.Drawing.Point(0, 350);
            this.xLabelMin.Name = "xLabelMin";
            this.xLabelMin.Size = new System.Drawing.Size(44, 17);
            this.xLabelMin.TabIndex = 30;
            this.xLabelMin.Text = "NULL";
            // 
            // yLabelMin
            // 
            this.yLabelMin.AutoSize = true;
            this.yLabelMin.Location = new System.Drawing.Point(338, 695);
            this.yLabelMin.Name = "yLabelMin";
            this.yLabelMin.Size = new System.Drawing.Size(44, 17);
            this.yLabelMin.TabIndex = 31;
            this.yLabelMin.Text = "NULL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 724);
            this.Controls.Add(this.yLabelMin);
            this.Controls.Add(this.xLabelMin);
            this.Controls.Add(this.yLabelMax);
            this.Controls.Add(this.xLabelMax);
            this.Controls.Add(this.yIntervalLabel);
            this.Controls.Add(this.yMaxLabel);
            this.Controls.Add(this.yMinLabel);
            this.Controls.Add(this.yIntervalValue);
            this.Controls.Add(this.yMaxValue);
            this.Controls.Add(this.yMinValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.xMaxValue);
            this.Controls.Add(this.xIntervalValue);
            this.Controls.Add(this.xMinLabel);
            this.Controls.Add(this.xMinValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.circleEquation);
            this.Controls.Add(this.quadraticEquation);
            this.Controls.Add(this.testOutput);
            this.Controls.Add(this.colorToDrawWith);
            this.Controls.Add(this.equationColumnLabel);
            this.Controls.Add(this.colorBox_Cubic);
            this.Controls.Add(this.colorBox_Linear);
            this.Controls.Add(this.cubicEquation);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.linearEquation);
            this.Controls.Add(this.graph);
            this.Name = "Form1";
            this.Text = "Graphing Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.linearEquation.ResumeLayout(false);
            this.linearEquation.PerformLayout();
            this.cubicEquation.ResumeLayout(false);
            this.cubicEquation.PerformLayout();
            this.colorBox_Linear.ResumeLayout(false);
            this.colorBox_Linear.PerformLayout();
            this.colorBox_Cubic.ResumeLayout(false);
            this.colorBox_Cubic.PerformLayout();
            this.quadraticEquation.ResumeLayout(false);
            this.quadraticEquation.PerformLayout();
            this.circleEquation.ResumeLayout(false);
            this.circleEquation.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xIntervalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yIntervalValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.Label equation1;
        private System.Windows.Forms.Label equation1_mx;
        private System.Windows.Forms.TextBox linear_riseValue;
        private System.Windows.Forms.TextBox linear_yPointVal;
        private System.Windows.Forms.GroupBox linearEquation;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.GroupBox cubicEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox colorBox_Linear;
        private System.Windows.Forms.RadioButton blackColorRadioButton_Linear;
        private System.Windows.Forms.RadioButton redColorRadioButton_Linear;
        private System.Windows.Forms.RadioButton greenColorRadioButton_Linear;
        private System.Windows.Forms.RadioButton blueColorRadioButton_Linear;
        private System.Windows.Forms.GroupBox colorBox_Cubic;
        private System.Windows.Forms.RadioButton blackColorRadioButton_Cubic;
        private System.Windows.Forms.RadioButton redColorRadioButton_Cubic;
        private System.Windows.Forms.RadioButton greenColorRadioButton_Cubic;
        private System.Windows.Forms.RadioButton blueColorRadioButton_Cubic;
        private System.Windows.Forms.Label equationColumnLabel;
        private System.Windows.Forms.Label colorToDrawWith;
        private System.Windows.Forms.RichTextBox testOutput;
        private System.Windows.Forms.GroupBox quadraticEquation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox circleEquation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown xMinValue;
        private System.Windows.Forms.Label xMinLabel;
        private System.Windows.Forms.NumericUpDown xIntervalValue;
        private System.Windows.Forms.NumericUpDown xMaxValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown yMinValue;
        private System.Windows.Forms.NumericUpDown yMaxValue;
        private System.Windows.Forms.NumericUpDown yIntervalValue;
        private System.Windows.Forms.Label yMinLabel;
        private System.Windows.Forms.Label yMaxLabel;
        private System.Windows.Forms.Label yIntervalLabel;
        private System.Windows.Forms.Label xLabelMax;
        private System.Windows.Forms.Label yLabelMax;
        private System.Windows.Forms.Label xLabelMin;
        private System.Windows.Forms.Label yLabelMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox linear_runValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox linear_xPointVal;
    }
}

