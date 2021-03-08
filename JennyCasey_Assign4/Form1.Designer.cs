
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
            this.graph1 = new System.Windows.Forms.PictureBox();
            this.equation1 = new System.Windows.Forms.Label();
            this.equation1_mx = new System.Windows.Forms.Label();
            this.equation1_mxVal = new System.Windows.Forms.TextBox();
            this.equation1_bVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graph1)).BeginInit();
            this.SuspendLayout();
            // 
            // graph1
            // 
            this.graph1.Location = new System.Drawing.Point(3, 65);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(544, 306);
            this.graph1.TabIndex = 0;
            this.graph1.TabStop = false;
            // 
            // equation1
            // 
            this.equation1.AutoSize = true;
            this.equation1.Location = new System.Drawing.Point(35, 23);
            this.equation1.Name = "equation1";
            this.equation1.Size = new System.Drawing.Size(31, 17);
            this.equation1.TabIndex = 1;
            this.equation1.Text = "y = ";
            // 
            // equation1_mx
            // 
            this.equation1_mx.AutoSize = true;
            this.equation1_mx.Location = new System.Drawing.Point(92, 23);
            this.equation1_mx.Name = "equation1_mx";
            this.equation1_mx.Size = new System.Drawing.Size(26, 17);
            this.equation1_mx.TabIndex = 2;
            this.equation1_mx.Text = "x +";
            // 
            // equation1_mxVal
            // 
            this.equation1_mxVal.Location = new System.Drawing.Point(61, 20);
            this.equation1_mxVal.Name = "equation1_mxVal";
            this.equation1_mxVal.Size = new System.Drawing.Size(25, 22);
            this.equation1_mxVal.TabIndex = 3;
            // 
            // equation1_bVal
            // 
            this.equation1_bVal.Location = new System.Drawing.Point(124, 20);
            this.equation1_bVal.Name = "equation1_bVal";
            this.equation1_bVal.Size = new System.Drawing.Size(25, 22);
            this.equation1_bVal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 724);
            this.Controls.Add(this.equation1_bVal);
            this.Controls.Add(this.equation1_mxVal);
            this.Controls.Add(this.equation1_mx);
            this.Controls.Add(this.equation1);
            this.Controls.Add(this.graph1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graph1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graph1;
        private System.Windows.Forms.Label equation1;
        private System.Windows.Forms.Label equation1_mx;
        private System.Windows.Forms.TextBox equation1_mxVal;
        private System.Windows.Forms.TextBox equation1_bVal;
    }
}

