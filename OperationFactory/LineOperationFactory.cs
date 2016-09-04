using Microsoft.Practices.Unity;
using Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationFactory
{
    public class LineOperationFactory
    {

        public static LineOperation GetLineOperation()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILineOperation, LineOperation>();
            LineOperation lineOperation = container.Resolve<LineOperation>();
            return lineOperation;

        }

    }
}
