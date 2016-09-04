using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFactory;
using Entities;
using Operations;
using OperationFactory;

namespace TestLine
{
    [TestClass]
    public class TestForCircle
    {
        [TestMethod]
        public void TestDrawCircle()
        {
            Circle circle = CircleFactory.GetCircle();
            circle.FirstpointXCoordinate = 15;
            circle.FirstpointYCoordinate = 15;
            circle.SecondpointXCoordinate = 40;
            circle.SecondpointYCoordinate = 40;
            ICircleOperation circleOperation = CircleOperationalFactory.GetCircleOperation();
            circleOperation.Draw(circle);
        }
    }
}
