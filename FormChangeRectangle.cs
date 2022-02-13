using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class FormChange : Form
    {
        public FormChange()         //  FormChangeRectangle
        {
            InitializeComponent();
        }
        private int _Width;
        private int _Height;
        private Color? _color;
        public int MyWidth
        {
            get => _Width;
            set
            {
                _Width = value;
                textBoxWidth.Text = _Width.ToString();
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
