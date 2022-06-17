using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT.CSCourse.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String InAndOutLine;

            while ((InAndOutLine = Console.ReadLine()) != null) {

                InAndOutLine = InAndOutLine.Replace(",", " y:");
                InAndOutLine = "x:" + InAndOutLine;

                Console.WriteLine(InAndOutLine);
            }

            //Console.ReadKey(true);
        }
    }
}
