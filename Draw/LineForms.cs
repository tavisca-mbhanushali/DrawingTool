using Entities;
using EntityFactory;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeForm

{
    public partial class LineForms : Form
    {
        Line line = LineFactory.GetLine();

        public LineForms()
        {
            InitializeComponent();
        }
        public LineForms(Line newLine)
        {
            InitializeComponent();
            line.FirstpointXCoordinate = newLine.FirstpointXCoordinate;
            line.FirstpointYCoordinate = newLine.FirstpointYCoordinate;

            line.SecondpointXCoordinate = newLine.SecondpointXCoordinate;
            line.SecondpointYCoordinate = newLine.SecondpointYCoordinate;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = linepanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawLine(pen, line.FirstpointXCoordinate, line.FirstpointYCoordinate, line.SecondpointXCoordinate, line.SecondpointYCoordinate);
        }


        private void linepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
