using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Operations;

namespace OperationFactory
{
   public class CircleOperationalFactory
    {

        public static CircleOperation GetCircleOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICircleOperation, CircleOperation>();
            CircleOperation circleOperation = container.Resolve<CircleOperation>();
            return circleOperation;
        }

    }
}
