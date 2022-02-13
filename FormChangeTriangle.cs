using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class FormChangeTriangle : Form
    {
        public FormChangeTriangle()
        {
            InitializeComponent();
        }
        private int _Side;
        private int _Height;
        private Color? _color;
        public int MySide
        {
            get => _Side;
            set
            {
                _Side = value;
                textBoxSide.Text = _Side.ToString();
            }
        }
        public int MyHeight
        {
            get => _Height;
            set
            {
                _Height = value;
                textBoxHeight.Text = _Height.ToString();
            }
        }
        public Color? MyColor
        {
            get => _color;
            set
            {
                _color = value;
                buttonColor.BackColor = _color ?? BackColor;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            MySide = int.Parse(textBoxSide.Text);
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

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            MyColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : (Color?)null;
        }
    }
}
