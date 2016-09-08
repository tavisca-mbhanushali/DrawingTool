/*
using Entities;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFactory
{
    class ShapeFactory
    {
        public static Circle GetCircle()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Circle>();
            Circle circle = container.Resolve<Circle>();
            return circle;

        }

        public static Line GetLine()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Line>();
            Line line = container.Resolve<Line>();
            return line;
        }

        public static ERectangle GetRectangle()
        {

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ERectangle>();
            ERectangle rectangle = container.Resolve<ERectangle>();
            return rectangle;
        }

    }
}
*/