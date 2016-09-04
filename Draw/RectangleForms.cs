using EntityFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
namespace Draw
{
    public partial class RectangleForm : Form
    {
        ERectangle rectangle = RectangleFactory.GetRectangle();

        public RectangleForm()
        {
            InitializeComponent();
        }

        public RectangleForm(ERectangle rectangle)
        {
                       InitializeComponent();
            this.rectangle.FirstpointXCoordinate = rectangle.FirstpointXCoordinate;
            this.rectangle.FirstpointYCoordinate = rectangle.FirstpointYCoordinate;
            this.rectangle.SecondpointXCoordinate = rectangle.SecondpointXCoordinate;
            this.rectangle.SecondpointYCoordinate = rectangle.SecondpointYCoordinate;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = Rectanglepanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawRectangle(pen, rectangle.FirstpointXCoordinate, rectangle.FirstpointYCoordinate, rectangle.SecondpointXCoordinate, rectangle.SecondpointYCoordinate);

        }
    }
}
