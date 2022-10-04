using Microsoft.VisualBasic.FileIO;
using System;
using System.Transactions;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            int length;
            int width1;
            int perimeter;
            int area;
            int i = 0;
            int changeL = 0;
            int changeW = 0;
            
            while ((i < 2) && (changeL <= 1 && changeW <= 1)){ 
                
            Console.WriteLine("Please select one of the following options:");
            
            Console.WriteLine("1 Get Rectangle Length");
            Console.WriteLine("2 Change Rectangle Length");
            Console.WriteLine("3 Get Rectangle Width");
            Console.WriteLine("4 Change Rectangle Width");
            Console.WriteLine("5 Get Rectangle Perimeter");
            Console.WriteLine("6 Get Rectangle Area");
            Console.WriteLine("7 Exit");

            option = Console.ReadLine();
            
            if (option == "1")
            {
                Console.WriteLine("Length: ");
                Rectangle rect = new Rectangle();
                Console.WriteLine(rect.GetCurrentLength());
            }
            else if (option == "2")
            {
                Console.WriteLine("Please introduce a new Length: ");
                Rectangle rect = new Rectangle();
                length = int.Parse(Console.ReadLine());
                length = rect.SetNewLength(length);
                Console.WriteLine("New Length: " + length);
                changeL ++;
                }
            else if (option == "3")
            {
                Console.WriteLine("Width: ");
                Rectangle rect = new Rectangle();
                Console.WriteLine(rect.GetCurrentWidth());
            }
            else if (option == "4")
            {
                Console.WriteLine("Please introduce a new Width: ");
                Rectangle rect = new Rectangle();
                width1 = int.Parse(Console.ReadLine());
                width1 = rect.SetNewWidth(width1);
                Console.WriteLine("New Width: " + width1);
                changeW ++;
                }
            else if (option == "5")
            {
                Rectangle rect = new Rectangle();
                perimeter = rect.GetPerimeter();
                Console.WriteLine("Perimeter: " + perimeter);
            }
            else if (option == "6")
            {
                Rectangle rect = new Rectangle();
                area = rect.GetArea();
                Console.WriteLine("Area: " + area);
            }
            else if (option == "7")
            {
                    break;
            }
                i=0;
            } 

        }
    }
}
