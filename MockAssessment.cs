using System;

namespace MockAssessment1
{
    class Program
    {
        static void Main(string[] args)

        {


            int a = FindBuildingType(5);

            IsTheSame(5, 6);
            IsTheSame(5, 5);
            IsTheSame(0, 8);


            double num1 = Subtract(4, 6);
            double num2 = Subtract(8, 4);
        }


        private static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {

                return true;
            }
            else
            {
                return false;
            }

        }


        static double Subtract(double num1, double num2)
        {

            double total = num2 - num1;
            return total;

        }

        static int FindBuildingType(int a)
        {

            if (a > 3 && a < 11)
            {
                Console.WriteLine("This is an office building");
            }

           else if (a > 49)
            {
                Console.WriteLine("This is a SUPER skyscraper!");
            }


            else if (a > 10 && a < 50)
            {
                Console.WriteLine("This is a SUPER skyscraper!");
            }

            else if (a < 4)
            {
                Console.WriteLine("This is a house!!");
            }

            return a;

        }

    }

}



    
