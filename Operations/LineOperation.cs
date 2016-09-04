
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
