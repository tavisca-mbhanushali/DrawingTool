using Entities;
namespace Operations
{
  public interface IShapeOperation
    {

        void Draw(Circle circle);

        void Draw(Line shape);

        void Draw(ERectangle rectangle);

    }
}
