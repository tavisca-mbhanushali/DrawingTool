
using Entities;
using System.Windows.Forms;
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
