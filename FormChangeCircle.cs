using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class FormChangeCircle : Form
    {
        public FormChangeCircle()
        {
            InitializeComponent();
        }
        private int _Radius;
        private Color? _color;
        public Color? MyColor
        {
            get => _color;
            set
            {
                _color = value;
                buttonColor.BackColor = _color ?? BackColor;
            }
        }
        public int MyRadius
        {
            get => _Radius;
            set
            {
                _Radius = value;
                textBoxRadius.Text = _Radius.ToString();
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            MyRadius = int.Parse(textBoxRadius.Text);

            DialogResult = DialogResult.OK;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorChange();
        }
        public void ColorChange()
        {
            var cd = new ColorDialog();
            MyColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : (Color?)null;
        }
    }
}
