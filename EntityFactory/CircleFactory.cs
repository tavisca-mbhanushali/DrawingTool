using Entities;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
