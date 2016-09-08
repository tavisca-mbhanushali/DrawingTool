
using Entities;
using System.Windows.Forms;
using ShapeForm;

namespace Operations
{
    public class LineOperation : ILineOperation

    {
        public void Draw(Line shape)
        {
            Application.Run(new LineForms(shape));
        }
    }
}
