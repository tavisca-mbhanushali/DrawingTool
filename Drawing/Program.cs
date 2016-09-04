using Entities;
using EntityFactory;
using OperationFactory;
using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DrawingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice to Draw Shape");
            Console.WriteLine("1.Line");
            Console.WriteLine("2.Circle");
            Console.WriteLine("3.Rectangle");
            Console.WriteLine("4.Exit");

            int ChoiceOfShape = int.Parse(Console.ReadLine());

             
               
                switch (ChoiceOfShape)
                {
                    case 1:

                        Console.WriteLine("1.Line");
                        Line line = LineFactory.GetLine();
                        line.FirstpointXCoordinate = 100;
                        line.FirstpointYCoordinate = 200;
                        line.SecondpointXCoordinate = 400;
                        line.SecondpointYCoordinate = 300;
                        ILineOperation lineOperation = LineOperationFactory.GetLineOperation();
                        lineOperation.Draw(line);



                        break;

                    case 2:

                        Console.WriteLine("2.Circle");

                    Circle circle = CircleFactory.GetCircle();
                    circle.FirstpointXCoordinate = 10;
                    circle.FirstpointYCoordinate = 10;
                    circle.SecondpointXCoordinate = 50;
                    circle.SecondpointYCoordinate = 50;
                    ICircleOperation circleOperation = CircleOperationalFactory.GetCircleOperation();
                    circleOperation.Draw(circle);

                    break;

                    case 3:

                        Console.WriteLine("3.Rectangle");

                    ERectangle rectangle = RectangleFactory.GetRectangle();
                    rectangle.FirstpointXCoordinate = 40;
                    rectangle.FirstpointYCoordinate = 40;
                    rectangle.SecondpointXCoordinate = 60;
                    rectangle.SecondpointYCoordinate = 60;

                    IRectangleOperation rectangleOperation = RectangleOperationFactory.GetRectangleOperation();
                    rectangleOperation.Draw(rectangle);



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


            

        }
    }
}
