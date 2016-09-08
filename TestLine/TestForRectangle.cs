using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using EntityFactory;
using Operations;
using OperationFactory;

namespace TestLine
{
    [TestClass]
    public class TestForRectangle
    {
        [TestMethod]
        public void TestDrawRectangle()
        {
            ERectangle rectangle = RectangleFactory.GetRectangle();
            rectangle.FirstpointXCoordinate = 40;
            rectangle.FirstpointYCoordinate = 40;
            rectangle.SecondpointXCoordinate = 60;
            rectangle.SecondpointYCoordinate = 60;

            IRectangleOperation rectangleOperation = RectangleOperationFactory.GetRectangleOperation();
            rectangleOperation.Draw(rectangle);


        }
    }
}
