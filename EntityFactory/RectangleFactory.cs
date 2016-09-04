using Entities;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
