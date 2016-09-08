using Microsoft.Practices.Unity;
using Operations;

namespace OperationFactory
{
   public class RectangleOperationFactory
    {
        public static RectangleOperation GetRectangleOperation()
       {
        IUnityContainer container = new UnityContainer();
        container.RegisterType<IRectangleOperation, RectangleOperation>();
        RectangleOperation rectangleOperation = container.Resolve<RectangleOperation>();
        return rectangleOperation;
       }

    }
}
