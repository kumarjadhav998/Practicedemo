using System;

namespace _2aug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st subject mark");
            int a =int.Parse( Console.ReadLine());
            Console.WriteLine("enter the 2st subject mark");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 3st subject mark");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 4st subject mark");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 5st subject mark");
            int e = int.Parse(Console.ReadLine());
            double per = (a + b + c + d + e ) / 5.00;
            Console.WriteLine(per);
            
            Console.WriteLine("enter the trangle hight");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the trangle breath");
            int br = int.Parse(Console.ReadLine());
            double tranglearea =(0.5 * h * br);
            Console.WriteLine(tranglearea);

            
            Console.WriteLine("enter the 1st number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("addition-" + (x + y));

           
            Console.WriteLine("enter the number");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("cube-" + z * z * z);

            Console.WriteLine("enter the rectangle width");
            int  hig= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the rectangle length");
            int bre = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Rectangle=" + (hig * bre));

            Console.WriteLine("enter p amount");
                int P = int.Parse(Console.ReadLine());
            Console.WriteLine("enter R amount");
                int R = int.Parse(Console.ReadLine());
            Console.WriteLine("enter T amount");
                int T = int.Parse(Console.ReadLine());
            Console.WriteLine("Simple intrest = " +( P * R * T / 100));

            Console.WriteLine("enter 2 numbers");
            int k = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());
            int n;
            n = k;
            k = O;
            O = n;
            Console.WriteLine(k);
            Console.WriteLine(O);

            Console.WriteLine("enter fahrenheit temperature:");
            double farTemp = double.Parse(Console.ReadLine());
            double celTemp = (farTemp - 32) * 5 / 9;
            Console.WriteLine(" " + celTemp);

            Console.WriteLine("enter buy price");
            double buy = double.Parse(Console.ReadLine());
            Console.WriteLine("enter sell price");
            double sell = double.Parse(Console.ReadLine());
            double gain = (sell - buy) / buy;
            Console.WriteLine("gain in per = " + gain * 100);

            Console.WriteLine("enter the width");
            double W = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the length");
            double L = double.Parse(Console.ReadLine());
            double Perimeter = 2 * (a + b);
            Console.WriteLine("Perimeter =" + Perimeter);

           
             
            Console.ReadLine();



        }
    }
}
