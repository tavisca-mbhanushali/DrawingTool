using Entities;
using EntityFactory;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    public partial class CircleForms : Form
    {
        Circle circle = CircleFactory.GetCircle();

        public CircleForms()
        {
            InitializeComponent();
        }

        public CircleForms(Circle circle)
        {
            InitializeComponent();
            this.circle.FirstpointXCoordinate = circle.FirstpointXCoordinate;
            this.circle.FirstpointYCoordinate = circle.FirstpointYCoordinate;
            this.circle.SecondpointXCoordinate = circle.SecondpointXCoordinate;
            this.circle.SecondpointYCoordinate = circle.SecondpointYCoordinate;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = Circlepanel.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.DrawEllipse(pen, circle.FirstpointXCoordinate, circle.FirstpointYCoordinate, circle.SecondpointXCoordinate, circle.SecondpointYCoordinate);
        }

        private void Circlepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
