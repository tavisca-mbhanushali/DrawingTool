
using Entities;
using Microsoft.Practices.Unity;

namespace EntityFactory
{
    public class RectangleFactory
    {

        public static ERectangle GetRectangle()
        {

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ERectangle>();
            ERectangle rectangle = container.Resolve<ERectangle>();
            return rectangle;
        }
    }
}