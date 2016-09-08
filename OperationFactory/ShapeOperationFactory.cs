/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.Practices.Unity;
using Operations;

namespace OperationFactory
{
    class ShapeOperationFactory
    {
        public static ShapeOperation GetCircleOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IShapeOperation, ShapeOperation>();
            ShapeOperation circleOperation = container.Resolve<ShapeOperation>();
            return circleOperation;
        }

        public static ShapeOperation GetRectangleOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IShapeOperation, ShapeOperation>();
            ShapeOperation rectangleOperation = container.Resolve<ShapeOperation>();
            return rectangleOperation;
        }

        public static ShapeOperation GetLineOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IShapeOperation, ShapeOperation>();
            ShapeOperation lineOperation = container.Resolve<ShapeOperation>();
            return lineOperation;

        }
    }
}
*/







