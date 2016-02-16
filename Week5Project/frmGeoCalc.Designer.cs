namespace Week5Project
{
    partial class GeoCalculator
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
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.rdoParallelogram = new System.Windows.Forms.RadioButton();
            this.rdoRhombus = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoTrapezoid = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.rdoArea = new System.Windows.Forms.RadioButton();
            this.rdoPerimeter = new System.Windows.Forms.RadioButton();
            this.rdoAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.lblNames = new System.Windows.Forms.Label();
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.grpAreaPerimeter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picShape = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblEquations = new System.Windows.Forms.Label();
            this.grpShapes.SuspendLayout();
            this.grpAreaPerimeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShape)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Checked = true;
            this.rdoRectangle.Location = new System.Drawing.Point(7, 24);
            this.rdoRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdoRectangle.TabIndex = 0;
            this.rdoRectangle.TabStop = true;
            this.rdoRectangle.Text = "Rectangle";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            this.rdoRectangle.CheckedChanged += new System.EventHandler(this.rdoShape_CheckedChanged);
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(7, 46);
            this.rdoSquare.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(59, 17);
            this.rdoSquare.TabIndex = 1;
            this.rdoSquare.Text = "Square";
            this.rdoSquare.UseVisualStyleBackColor = true;
            this.rdoSquare.CheckedChanged += new System.EventHandler(this.rdoShape_CheckedChanged);
            // 
            // rdoParallelogram
            // 
            this.rdoParallelogram.AutoSize = true;
            this.rdoParallelogram.Location = new System.Drawing.Point(7, 68);
            this.rdoParallelogram.Margin = new System.Windows.Forms.Padding(2);
            this.rdoParallelogram.Name = "rdoParallelogram";
            this.rdoParallelogram.Size = new System.Drawing.Size(88, 17);
            this.rdoParallelogram.TabIndex = 2;
            this.rdoParallelogram.Text = "Parallelogram";
            this.rdoParallelogram.UseVisualStyleBackColor = true;
            this.rdoParallelogram.CheckedChanged += new System.EventHandler(this.rdoShape_CheckedChanged);
            // 
            // rdoRhombus
            // 
            this.rdoRhombus.AutoSize = true;
            this.rdoRhombus.Location = new System.Drawing.Point(7, 90);
            this.rdoRhombus.Margin = new System.Windows.Forms.Padding(2);
            this.rdoRhombus.Name = "rdoRhombus";
            this.rdoRhombus.Size = new System.Drawing.Size(70, 17);
            this.rdoRhombus.TabIndex = 3;
            this.rdoRhombus.Text = "Rhombus";
            this.rdoRhombus.UseVisualStyleBackColor = true;
            this.rdoRhombus.CheckedChanged += new System.EventHandler(this.rdoShape_CheckedChanged);
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Location = new System.Drawing.Point(7, 112);
            this.rdoTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(63, 17);
            this.rdoTriangle.TabIndex = 4;
            this.rdoTriangle.Text = "Triangle";
            this.rdoTriangle.UseVisualStyleBackColor = true;
            this.rdoTriangle.CheckedChanged += new System.EventHandler(this.rdoShape_CheckedChanged);
            // 
            // rdoTrapezoid
            // 
            this.rdoTrapezoid.AutoSize = true;
            this.rdoTrapezoid.Location = new System.Drawing.Point(7, 134);
            this.rdoTrapezoid.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTrapezoid.Name = "rdoTrapezoid";
            this.rdoTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.rdoTrapezoid.TabIndex = 5;
            this.rdoTrapezoid.Text = "Trapezoid";
            this.rdoTrapezoid.UseVisualStyleBackColor = true;
            this.rdoTrapezoid.CheckedChanged += new System.EventHandler(this.rdoShape_CheckedChanged);
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(7, 156);
            this.rdoCircle.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(51, 17);
            this.rdoCircle.TabIndex = 6;
            this.rdoCircle.Text = "Circle";
            this.rdoCircle.UseVisualStyleBackColor = true;
            this.rdoCircle.CheckedChanged += new System.EventHandler(this.rdoShape_CheckedChanged);
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Checked = true;
            this.rdoArea.Location = new System.Drawing.Point(5, 17);
            this.rdoArea.Margin = new System.Windows.Forms.Padding(2);
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Size = new System.Drawing.Size(47, 17);
            this.rdoArea.TabIndex = 0;
            this.rdoArea.TabStop = true;
            this.rdoArea.Text = "Area";
            this.rdoArea.UseVisualStyleBackColor = true;
            this.rdoArea.CheckedChanged += new System.EventHandler(this.rdoArea_CheckedChanged);
            // 
            // rdoPerimeter
            // 
            this.rdoPerimeter.AutoSize = true;
            this.rdoPerimeter.Location = new System.Drawing.Point(74, 17);
            this.rdoPerimeter.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPerimeter.Name = "rdoPerimeter";
            this.rdoPerimeter.Size = new System.Drawing.Size(69, 17);
            this.rdoPerimeter.TabIndex = 1;
            this.rdoPerimeter.Text = "Perimeter";
            this.rdoPerimeter.UseVisualStyleBackColor = true;
            this.rdoPerimeter.CheckedChanged += new System.EventHandler(this.rdoPerimeter_CheckedChanged);
            // 
            // rdoAreaPerimeter
            // 
            this.rdoAreaPerimeter.AutoSize = true;
            this.rdoAreaPerimeter.Location = new System.Drawing.Point(159, 17);
            this.rdoAreaPerimeter.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAreaPerimeter.Name = "rdoAreaPerimeter";
            this.rdoAreaPerimeter.Size = new System.Drawing.Size(115, 17);
            this.rdoAreaPerimeter.TabIndex = 2;
            this.rdoAreaPerimeter.Text = "Area and Perimeter";
            this.rdoAreaPerimeter.UseVisualStyleBackColor = true;
            this.rdoAreaPerimeter.CheckedChanged += new System.EventHandler(this.rdoAreaPerimeter_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 263);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(74, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 263);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(148, 49);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(46, 20);
            this.txt1.TabIndex = 6;
            this.txt1.Leave += new System.EventHandler(this.TextBoxChanged_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(148, 80);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(46, 20);
            this.txt2.TabIndex = 8;
            this.txt2.Leave += new System.EventHandler(this.TextBoxChanged_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(148, 111);
            this.txt3.Margin = new System.Windows.Forms.Padding(2);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(46, 20);
            this.txt3.TabIndex = 10;
            this.txt3.Leave += new System.EventHandler(this.TextBoxChanged_TextChanged);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(148, 142);
            this.txt4.Margin = new System.Windows.Forms.Padding(2);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(46, 20);
            this.txt4.TabIndex = 12;
            this.txt4.Leave += new System.EventHandler(this.TextBoxChanged_TextChanged);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(148, 173);
            this.txt5.Margin = new System.Windows.Forms.Padding(2);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(46, 20);
            this.txt5.TabIndex = 14;
            this.txt5.Leave += new System.EventHandler(this.TextBoxChanged_TextChanged);
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(9, 7);
            this.lblNames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(185, 13);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Anna Dudda, Joe Lee, Timmy Milligan";
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.rdoRectangle);
            this.grpShapes.Controls.Add(this.rdoSquare);
            this.grpShapes.Controls.Add(this.rdoParallelogram);
            this.grpShapes.Controls.Add(this.rdoRhombus);
            this.grpShapes.Controls.Add(this.rdoTriangle);
            this.grpShapes.Controls.Add(this.rdoTrapezoid);
            this.grpShapes.Controls.Add(this.rdoCircle);
            this.grpShapes.Location = new System.Drawing.Point(9, 28);
            this.grpShapes.Margin = new System.Windows.Forms.Padding(2);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Padding = new System.Windows.Forms.Padding(2);
            this.grpShapes.Size = new System.Drawing.Size(122, 181);
            this.grpShapes.TabIndex = 1;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Select a shape";
            // 
            // grpAreaPerimeter
            // 
            this.grpAreaPerimeter.Controls.Add(this.rdoPerimeter);
            this.grpAreaPerimeter.Controls.Add(this.rdoArea);
            this.grpAreaPerimeter.Controls.Add(this.rdoAreaPerimeter);
            this.grpAreaPerimeter.Location = new System.Drawing.Point(9, 213);
            this.grpAreaPerimeter.Margin = new System.Windows.Forms.Padding(2);
            this.grpAreaPerimeter.Name = "grpAreaPerimeter";
            this.grpAreaPerimeter.Padding = new System.Windows.Forms.Padding(2);
            this.grpAreaPerimeter.Size = new System.Drawing.Size(282, 46);
            this.grpAreaPerimeter.TabIndex = 2;
            this.grpAreaPerimeter.TabStop = false;
            this.grpAreaPerimeter.Text = "Select a calculation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // picShape
            // 
            this.picShape.Location = new System.Drawing.Point(298, 49);
            this.picShape.Name = "picShape";
            this.picShape.Size = new System.Drawing.Size(175, 119);
            this.picShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShape.TabIndex = 21;
            this.picShape.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(402, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(295, 171);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAnswer.TabIndex = 23;
            this.lblAnswer.Text = "label6";
            // 
            // lblEquations
            // 
            this.lblEquations.AutoSize = true;
            this.lblEquations.Location = new System.Drawing.Point(296, 213);
            this.lblEquations.Name = "lblEquations";
            this.lblEquations.Size = new System.Drawing.Size(35, 13);
            this.lblEquations.TabIndex = 24;
            this.lblEquations.Text = "label7";
            // 
            // GeoCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(489, 440);
            this.Controls.Add(this.lblEquations);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picShape);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpAreaPerimeter);
            this.Controls.Add(this.grpShapes);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GeoCalculator";
            this.Text = "Common Geometry Formulas Calculator";
            this.Load += new System.EventHandler(this.GeoCalculator_Load);
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.grpAreaPerimeter.ResumeLayout(false);
            this.grpAreaPerimeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.RadioButton rdoParallelogram;
        private System.Windows.Forms.RadioButton rdoRhombus;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.RadioButton rdoTrapezoid;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.RadioButton rdoArea;
        private System.Windows.Forms.RadioButton rdoPerimeter;
        private System.Windows.Forms.RadioButton rdoAreaPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.GroupBox grpAreaPerimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picShape;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblEquations;
    }
}

