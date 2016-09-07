
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ShapeForm;
using Draw;


namespace Operations
{
   public class RectangleOperation : IRectangleOperation
    {
        public void Draw(ERectangle rectangle)
        {
            Application.Run(new RectangleForm(rectangle));

        }

    }
}
