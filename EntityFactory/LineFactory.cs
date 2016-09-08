
using Microsoft.Practices.Unity;
using Entities;

namespace EntityFactory
{
    public class LineFactory
    {
        public static Line GetLine()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Line>();
            Line line = container.Resolve<Line>();
            return line;
        }
    }
}
