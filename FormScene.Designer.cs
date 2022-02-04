
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
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.panelPerimeter = new System.Windows.Forms.Panel();
            this.panelArea = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonCalculateAllShapes = new System.Windows.Forms.Button();
            this.panelSelectShape.SuspendLayout();
            this.panelPerimeter.SuspendLayout();
            this.panelArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPerimeter.Location = new System.Drawing.Point(0, 21);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.ReadOnly = true;
            this.textBoxPerimeter.Size = new System.Drawing.Size(158, 24);
            this.textBoxPerimeter.TabIndex = 2;
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerimeter.Location = new System.Drawing.Point(0, 0);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(76, 18);
            this.labelPerimeter.TabIndex = 3;
            this.labelPerimeter.Text = "Perimeter:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(0, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(42, 18);
            this.labelArea.TabIndex = 4;
            this.labelArea.Text = "Area:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArea.Location = new System.Drawing.Point(0, 21);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(158, 24);
            this.textBoxArea.TabIndex = 5;
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShape.Location = new System.Drawing.Point(0, 0);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(97, 18);
            this.labelShape.TabIndex = 6;
            this.labelShape.Text = "Select shape:";
            // 
            // panelSelectShape
            // 
            this.panelSelectShape.Controls.Add(this.labelShape);
            this.panelSelectShape.Controls.Add(this.radioButtonCircle);
            this.panelSelectShape.Controls.Add(this.radioButtonTriangle);
            this.panelSelectShape.Controls.Add(this.radioButtonRectangle);
            this.panelSelectShape.Location = new System.Drawing.Point(12, 9);
            this.panelSelectShape.Name = "panelSelectShape";
            this.panelSelectShape.Size = new System.Drawing.Size(301, 56);
            this.panelSelectShape.TabIndex = 8;
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(0, 30);
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
            this.radioButtonTriangle.Location = new System.Drawing.Point(211, 30);
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
            this.radioButtonRectangle.Location = new System.Drawing.Point(95, 30);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(90, 20);
            this.radioButtonRectangle.TabIndex = 9;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // panelPerimeter
            // 
            this.panelPerimeter.Controls.Add(this.labelPerimeter);
            this.panelPerimeter.Controls.Add(this.textBoxPerimeter);
            this.panelPerimeter.Location = new System.Drawing.Point(12, 680);
            this.panelPerimeter.Name = "panelPerimeter";
            this.panelPerimeter.Size = new System.Drawing.Size(158, 45);
            this.panelPerimeter.TabIndex = 8;
            // 
            // panelArea
            // 
            this.panelArea.Controls.Add(this.labelArea);
            this.panelArea.Controls.Add(this.textBoxArea);
            this.panelArea.Location = new System.Drawing.Point(176, 680);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(158, 45);
            this.panelArea.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 646);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(158, 31);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Calculate shape:";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonCalculateAllShapes
            // 
            this.buttonCalculateAllShapes.Location = new System.Drawing.Point(179, 646);
            this.buttonCalculateAllShapes.Name = "buttonCalculateAllShapes";
            this.buttonCalculateAllShapes.Size = new System.Drawing.Size(155, 31);
            this.buttonCalculateAllShapes.TabIndex = 11;
            this.buttonCalculateAllShapes.Text = "Calculate all shapes:";
            this.buttonCalculateAllShapes.UseVisualStyleBackColor = true;
            this.buttonCalculateAllShapes.Click += new System.EventHandler(this.buttonCalculateAllShapes_Click);
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 737);
            this.Controls.Add(this.buttonCalculateAllShapes);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.panelArea);
            this.Controls.Add(this.panelPerimeter);
            this.Controls.Add(this.panelSelectShape);
            this.Name = "FormScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.Load += new System.EventHandler(this.FormScene_Load);
            this.DoubleClick += new System.EventHandler(this.FormScene_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScene_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.panelSelectShape.ResumeLayout(false);
            this.panelSelectShape.PerformLayout();
            this.panelPerimeter.ResumeLayout(false);
            this.panelPerimeter.PerformLayout();
            this.panelArea.ResumeLayout(false);
            this.panelArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.Panel panelSelectShape;
        private System.Windows.Forms.Panel panelPerimeter;
        private System.Windows.Forms.Panel panelArea;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonCalculateAllShapes;
    }
}

