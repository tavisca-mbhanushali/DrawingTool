using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClassLibrary1
{
    public partial class Canvas : Form
    {
        public Canvas()
        {
            InitializeComponent();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gObject = this.CreateGraphics();

            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

            gObject.DrawLine(redPen, 100, 100, 400, 376);
        }
    }
}
