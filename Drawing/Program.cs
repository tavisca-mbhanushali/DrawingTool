using Entities;
using EntityFactory;
using OperationFactory;
using Operations;
using System;
using log4net;
namespace DrawingDemo
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            int ChoiceOfShape = 0;

            do
            {
                Console.WriteLine("Enter Your Choice to Draw Shape");
                Console.WriteLine("1.Line");
                Console.WriteLine("2.Circle");
                Console.WriteLine("3.Rectangle");
                Console.WriteLine("4.Exit");

                 ChoiceOfShape = int.Parse(Console.ReadLine());

                switch (ChoiceOfShape)
                {
                    case 1:

                        Console.WriteLine("1.Line");
                        Line line = LineFactory.GetLine();

                        Console.WriteLine("Enter X Co-ordinate of First point");
                        int XLineFirst = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Y Co-ordinate of First point");
                        int YLineFirst = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter X Co-ordinate of Second point");
                        int XLineSecond = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Y Co-ordinate of Second point");
                        int YLineSecond = int.Parse(Console.ReadLine());

                        line.FirstpointXCoordinate = XLineFirst; //100
                        line.FirstpointYCoordinate = YLineFirst; //200
                        line.SecondpointXCoordinate = XLineSecond; //400 
                        line.SecondpointYCoordinate = YLineSecond; //300

                        ILineOperation lineOperation = LineOperationFactory.GetLineOperation();

                        //IShapeOperation lineOperation = ShapeOperationFactory.GetLineOperation();

                        lineOperation.Draw(line);
                        log.InfoFormat("Line Created");


                        break;

                    case 2:

                        Console.WriteLine("2.Circle");

                        Circle circle = CircleFactory.GetCircle();

                        Console.WriteLine("Enter X & Y Co-ordinate of Centre point");
                        int XCircleFirst = int.Parse(Console.ReadLine());
                        int YCircleFirst = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter X & Y Equidistance Points of Radius");
                        int XCircleSecond = int.Parse(Console.ReadLine());
                        int YCircleSecond = int.Parse(Console.ReadLine());

                        circle.FirstpointXCoordinate = XCircleFirst;   //10
                        circle.FirstpointYCoordinate = YCircleFirst;   //10
                        circle.SecondpointXCoordinate = XCircleSecond; //50
                        circle.SecondpointYCoordinate = YCircleSecond; //50

                        ICircleOperation circleOperation = CircleOperationalFactory.GetCircleOperation();
                        circleOperation.Draw(circle);

                        log.InfoFormat("Circle Created");

                        break;

                    case 3:

                        Console.WriteLine("3.Rectangle");

                        ERectangle rectangle = RectangleFactory.GetRectangle();

                        Console.WriteLine("Enter X & Y Co-ordinate of First point of Rectangle");
                        int XRectFirst = int.Parse(Console.ReadLine());
                        int YRectFirst = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter X & Y Co-ordinate of Second Point of Rectangle");
                        int XRectSecond = int.Parse(Console.ReadLine());
                        int YRectSecond = int.Parse(Console.ReadLine());

                        rectangle.FirstpointXCoordinate = XRectFirst;
                        rectangle.FirstpointYCoordinate = YRectFirst;
                        rectangle.SecondpointXCoordinate = XRectSecond;
                        rectangle.SecondpointYCoordinate = YRectSecond;

                        IRectangleOperation rectangleOperation = RectangleOperationFactory.GetRectangleOperation();
                        rectangleOperation.Draw(rectangle);

                        log.InfoFormat("Rectangle Created");

                        break;

                    case 4:


                        Console.WriteLine("4.Exit");
                        Console.WriteLine("Welcome Again!!");

                        System.Environment.Exit(0);

                        break;

                    default:

                        Console.WriteLine("Wrong Choice ! ");
                        break;

                }
            } while (ChoiceOfShape != 3);

        }
    }
}
