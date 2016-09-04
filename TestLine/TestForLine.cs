using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using EntityFactory;
using Operations;
using OperationFactory;

namespace TestLine
{
    [TestClass]
    public class TestForLine
    { 
    
        [TestMethod]
        public void TestDrawLine()
        {
            Line line = LineFactory.GetLine();
            line.FirstpointXCoordinate = 100;
            line.FirstpointYCoordinate = 200;
            line.SecondpointXCoordinate = 400;
            line.SecondpointYCoordinate = 300;
            ILineOperation lineOperation = LineOperationFactory.GetLineOperation();
            lineOperation.Draw(line);


        }
    }
}
