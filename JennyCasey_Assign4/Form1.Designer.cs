
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
            this.equation1_mxVal = new System.Windows.Forms.TextBox();
            this.equation1_bVal = new System.Windows.Forms.TextBox();
            this.linearEquation = new System.Windows.Forms.GroupBox();
            this.graphButton = new System.Windows.Forms.Button();
            this.cubicEquation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorBox_Linear = new System.Windows.Forms.GroupBox();
            this.blueColorRadioButton_Linear = new System.Windows.Forms.RadioButton();
            this.greenColorRadioButton_Linear = new System.Windows.Forms.RadioButton();
            this.redColorRadioButton_Linear = new System.Windows.Forms.RadioButton();
            this.blackColorRadioButton_Linear = new System.Windows.Forms.RadioButton();
            this.colorBox_Cubic = new System.Windows.Forms.GroupBox();
            this.blackColorRadioButton_Cubic = new System.Windows.Forms.RadioButton();
            this.redColorRadioButton_Cubic = new System.Windows.Forms.RadioButton();
            this.greenColorRadioButton_Cubic = new System.Windows.Forms.RadioButton();
            this.blueColorRadioButton_Cubic = new System.Windows.Forms.RadioButton();
            this.equationColumnLabel = new System.Windows.Forms.Label();
            this.colorToDrawWith = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.linearEquation.SuspendLayout();
            this.cubicEquation.SuspendLayout();
            this.colorBox_Linear.SuspendLayout();
            this.colorBox_Cubic.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(3, 25);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(751, 687);
            this.graph.TabIndex = 0;
            this.graph.TabStop = false;
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
            // equation1_mxVal
            // 
            this.equation1_mxVal.Location = new System.Drawing.Point(46, 41);
            this.equation1_mxVal.Name = "equation1_mxVal";
            this.equation1_mxVal.Size = new System.Drawing.Size(25, 22);
            this.equation1_mxVal.TabIndex = 3;
            // 
            // equation1_bVal
            // 
            this.equation1_bVal.Location = new System.Drawing.Point(109, 41);
            this.equation1_bVal.Name = "equation1_bVal";
            this.equation1_bVal.Size = new System.Drawing.Size(25, 22);
            this.equation1_bVal.TabIndex = 4;
            // 
            // linearEquation
            // 
            this.linearEquation.Controls.Add(this.equation1);
            this.linearEquation.Controls.Add(this.equation1_bVal);
            this.linearEquation.Controls.Add(this.equation1_mxVal);
            this.linearEquation.Controls.Add(this.equation1_mx);
            this.linearEquation.Location = new System.Drawing.Point(771, 65);
            this.linearEquation.Name = "linearEquation";
            this.linearEquation.Size = new System.Drawing.Size(200, 100);
            this.linearEquation.TabIndex = 5;
            this.linearEquation.TabStop = false;
            this.linearEquation.Text = "Linear Equation";
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
            // 
            // cubicEquation
            // 
            this.cubicEquation.Controls.Add(this.label1);
            this.cubicEquation.Controls.Add(this.textBox1);
            this.cubicEquation.Controls.Add(this.textBox2);
            this.cubicEquation.Controls.Add(this.label2);
            this.cubicEquation.Location = new System.Drawing.Point(771, 208);
            this.cubicEquation.Name = "cubicEquation";
            this.cubicEquation.Size = new System.Drawing.Size(200, 100);
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
            this.colorBox_Linear.Size = new System.Drawing.Size(130, 131);
            this.colorBox_Linear.TabIndex = 8;
            this.colorBox_Linear.TabStop = false;
            this.colorBox_Linear.Text = "Color:";
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
            // redColorRadioButton_Linear
            // 
            this.redColorRadioButton_Linear.AutoSize = true;
            this.redColorRadioButton_Linear.Location = new System.Drawing.Point(7, 76);
            this.redColorRadioButton_Linear.Name = "redColorRadioButton_Linear";
            this.redColorRadioButton_Linear.Size = new System.Drawing.Size(55, 21);
            this.redColorRadioButton_Linear.TabIndex = 2;
            this.redColorRadioButton_Linear.TabStop = true;
            this.redColorRadioButton_Linear.Text = "Red";
            this.redColorRadioButton_Linear.UseVisualStyleBackColor = true;
            // 
            // blackColorRadioButton_Linear
            // 
            this.blackColorRadioButton_Linear.AutoSize = true;
            this.blackColorRadioButton_Linear.Location = new System.Drawing.Point(6, 103);
            this.blackColorRadioButton_Linear.Name = "blackColorRadioButton_Linear";
            this.blackColorRadioButton_Linear.Size = new System.Drawing.Size(63, 21);
            this.blackColorRadioButton_Linear.TabIndex = 3;
            this.blackColorRadioButton_Linear.TabStop = true;
            this.blackColorRadioButton_Linear.Text = "Black";
            this.blackColorRadioButton_Linear.UseVisualStyleBackColor = true;
            // 
            // colorBox_Cubic
            // 
            this.colorBox_Cubic.Controls.Add(this.blackColorRadioButton_Cubic);
            this.colorBox_Cubic.Controls.Add(this.redColorRadioButton_Cubic);
            this.colorBox_Cubic.Controls.Add(this.greenColorRadioButton_Cubic);
            this.colorBox_Cubic.Controls.Add(this.blueColorRadioButton_Cubic);
            this.colorBox_Cubic.Location = new System.Drawing.Point(1020, 208);
            this.colorBox_Cubic.Name = "colorBox_Cubic";
            this.colorBox_Cubic.Size = new System.Drawing.Size(130, 131);
            this.colorBox_Cubic.TabIndex = 9;
            this.colorBox_Cubic.TabStop = false;
            this.colorBox_Cubic.Text = "Color:";
            // 
            // blackColorRadioButton_Cubic
            // 
            this.blackColorRadioButton_Cubic.AutoSize = true;
            this.blackColorRadioButton_Cubic.Location = new System.Drawing.Point(6, 103);
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
            this.redColorRadioButton_Cubic.Location = new System.Drawing.Point(7, 76);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 724);
            this.Controls.Add(this.colorToDrawWith);
            this.Controls.Add(this.equationColumnLabel);
            this.Controls.Add(this.colorBox_Cubic);
            this.Controls.Add(this.colorBox_Linear);
            this.Controls.Add(this.cubicEquation);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.linearEquation);
            this.Controls.Add(this.graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.linearEquation.ResumeLayout(false);
            this.linearEquation.PerformLayout();
            this.cubicEquation.ResumeLayout(false);
            this.cubicEquation.PerformLayout();
            this.colorBox_Linear.ResumeLayout(false);
            this.colorBox_Linear.PerformLayout();
            this.colorBox_Cubic.ResumeLayout(false);
            this.colorBox_Cubic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.Label equation1;
        private System.Windows.Forms.Label equation1_mx;
        private System.Windows.Forms.TextBox equation1_mxVal;
        private System.Windows.Forms.TextBox equation1_bVal;
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
    }
}

