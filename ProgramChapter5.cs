using System;
using System.Collections.Generic;
using System.Text;

namespace CStart
{
    class DaysTemp
    {
        public int High, Low;
        public int Average()
        {
            return (High + Low) / 2;
        }
    }
    class ProgramChapter5
    {
        static void Main()
        {

            ShowTemperateDetails();
            DisplayRadii();
            BooleanMethod();
            ProgramChapter5 prog = new ProgramChapter5();
            prog.PrintDateAndTime();
        }

        static void ShowTemperateDetails()
        {
            DaysTemp t1 = new DaysTemp();
            DaysTemp t2 = new DaysTemp();
            var t3 = new DaysTemp();

            t1.High = 76;   t1.Low = 57;
            t2.High = 75;   t2.Low = 53;
            t3.High = 77;   t3.Low = 54;
            Console.WriteLine("t1: {0}, {1}, {2}", t1.High, t1.Low, t1.Average());
            Console.WriteLine("t2: {0}, {1}, {2}", t2.High, t2.Low, t2.Average());
            Console.WriteLine("t3: {0}, {1}, {2}", t3.High, t3.Low, t3.Average());
            //alternate implementation
            List <DaysTemp> tempList = new List<DaysTemp>();
            tempList.Add(t1);
            tempList.Add(t2);
            tempList.Add(t3);
            int i = 0;
            foreach (DaysTemp aTemp in tempList)
            {
                Console.WriteLine($"t{i+1}: {aTemp.High}, {aTemp.Low}, {aTemp.Average()}");
                i++; 
            }
        }

        static void BooleanMethod()
        {
            int intVal = 3;
            if (intVal == 3)
                Console.WriteLine("Value is 3.");
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"Value of i: { i }");
        }
        static void DisplayRadii()
        {
            const double PI = 3.1416;
            for (int radius = 1; radius <= 5; radius++)
            {
                double area = radius * radius * PI;
                Console.WriteLine($"Radius: {radius}, Area: {area}");
            }
        }
        void PrintDateAndTime()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine($"{dt}");
        }
    }
}
