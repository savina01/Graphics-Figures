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
    public partial class FormChangeTriangle : Form
    {
        public FormChangeTriangle()
        {
            InitializeComponent();
        }
        private Color? _color;
        public Color? MyColor
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                buttonColor.BackColor = _color ?? BackColor;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
