
using Entities;
using System.Windows.Forms;
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
