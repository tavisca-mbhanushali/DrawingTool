using Entities;
using Microsoft.Practices.Unity;

namespace EntityFactory
{
   public class CircleFactory
    {
        public static Circle GetCircle()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Circle>();
            Circle circle = container.Resolve<Circle>();
            return circle;

        }
    }
}
