using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Windows.Forms;
using ShapeForm;
using Draw;

namespace Operations
{
   public class CircleOperation : ICircleOperation
    {
        public void Draw(Circle circle)
        {
            Application.Run(new CircleForms(circle));
        }

      
    }
}
