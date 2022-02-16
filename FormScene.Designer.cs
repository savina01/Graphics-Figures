
namespace CourseProject
{
    partial class FormScene
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
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelShape = new System.Windows.Forms.Label();
            this.panelSelectShape = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonCalculateAllShapes = new System.Windows.Forms.Button();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.panelSelectShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Enabled = false;
            this.textBoxPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPerimeter.Location = new System.Drawing.Point(130, 42);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.ReadOnly = true;
            this.textBoxPerimeter.Size = new System.Drawing.Size(289, 24);
            this.textBoxPerimeter.TabIndex = 2;
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerimeter.Location = new System.Drawing.Point(38, 42);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(76, 18);
            this.labelPerimeter.TabIndex = 3;
            this.labelPerimeter.Text = "Perimeter:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(72, 72);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(42, 18);
            this.labelArea.TabIndex = 4;
            this.labelArea.Text = "Area:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Enabled = false;
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArea.Location = new System.Drawing.Point(130, 72);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(289, 24);
            this.textBoxArea.TabIndex = 5;
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShape.Location = new System.Drawing.Point(60, 12);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(54, 18);
            this.labelShape.TabIndex = 6;
            this.labelShape.Text = "Shape:";
            // 
            // panelSelectShape
            // 
            this.panelSelectShape.BackColor = System.Drawing.Color.White;
            this.panelSelectShape.Controls.Add(this.buttonCalculate);
            this.panelSelectShape.Controls.Add(this.textBoxArea);
            this.panelSelectShape.Controls.Add(this.textBoxPerimeter);
            this.panelSelectShape.Controls.Add(this.buttonCalculateAllShapes);
            this.panelSelectShape.Controls.Add(this.labelArea);
            this.panelSelectShape.Controls.Add(this.labelPerimeter);
            this.panelSelectShape.Controls.Add(this.labelShape);
            this.panelSelectShape.Controls.Add(this.radioButtonCircle);
            this.panelSelectShape.Controls.Add(this.radioButtonTriangle);
            this.panelSelectShape.Controls.Add(this.radioButtonRectangle);
            this.panelSelectShape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSelectShape.Location = new System.Drawing.Point(0, 636);
            this.panelSelectShape.Name = "panelSelectShape";
            this.panelSelectShape.Size = new System.Drawing.Size(970, 114);
            this.panelSelectShape.TabIndex = 8;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(553, 23);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(366, 33);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Calculate shape:";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonCalculateAllShapes
            // 
            this.buttonCalculateAllShapes.Location = new System.Drawing.Point(553, 61);
            this.buttonCalculateAllShapes.Name = "buttonCalculateAllShapes";
            this.buttonCalculateAllShapes.Size = new System.Drawing.Size(366, 33);
            this.buttonCalculateAllShapes.TabIndex = 11;
            this.buttonCalculateAllShapes.Text = "Calculate all shapes:";
            this.buttonCalculateAllShapes.UseVisualStyleBackColor = true;
            this.buttonCalculateAllShapes.Click += new System.EventHandler(this.buttonCalculateAllShapes_Click);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(130, 12);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(62, 20);
            this.radioButtonCircle.TabIndex = 8;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(341, 12);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(78, 20);
            this.radioButtonTriangle.TabIndex = 10;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "Triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(222, 12);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(90, 20);
            this.radioButtonRectangle.TabIndex = 9;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 750);
            this.Controls.Add(this.panelSelectShape);
            this.Name = "FormScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.Load += new System.EventHandler(this.FormScene_Load);
            this.DoubleClick += new System.EventHandler(this.FormScene_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScene_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.panelSelectShape.ResumeLayout(false);
            this.panelSelectShape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.Panel panelSelectShape;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonCalculateAllShapes;
    }
}

