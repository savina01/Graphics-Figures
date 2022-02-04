using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.Figures;

namespace CourseProject
{
    public partial class FormChange : Form
    {
        // само за FormChangeRectangle
        //  а не като цяло за всички фигури

        public FormChange()
        {
            InitializeComponent();
        }
        private int _Width;
        private int _Height;
        private Color? _color;
        public int MyWidth
        {
            get
            {
                return _Width;
            }
            set
            {
                _Width = value;
                textBoxWidth.Text = _Width.ToString();
            }
        }
        public int MyHeight
        {
            get
            {
                return _Height;
            }
            set
            {
                _Height = value;
                textBoxHeight.Text = _Height.ToString();
            }
        }
        public Color? MyColor
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                buttonColorR.BackColor = _color ?? BackColor;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            MyWidth = int.Parse(textBoxWidth.Text);
            MyHeight = int.Parse(textBoxHeight.Text);

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void ColorChange()
        {
            var cd = new ColorDialog();
            MyColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : (Color?)null;
        }
        private void buttonColorR_Click(object sender, EventArgs e)
        {
            ColorChange();
        }
    }
}
