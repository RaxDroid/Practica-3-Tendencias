using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor");
            Console.WriteLine("-----------------------------");
            Range rangeA = new Range("(4,9]");
            Console.WriteLine("Range Initialized: Range from 4 to 9 semi open");
            Range rangeB = new Range("(3,10)");
            Console.WriteLine("Range Initialized: Range from 3 to 10 open");
            try
            {
                Range rangeE = new Range("Dsads");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Thrown: " + e.Message);
            }
            try
            {
                Range rangeF = new Range("(1,1)");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Thrown: " + e.Message);
            }
            Console.WriteLine();


            Console.WriteLine("Contains Function");
            Console.WriteLine("-----------------------------");
            bool booltestA = rangeA.Contains(5);
            if (booltestA)
                Console.WriteLine("Range A contains 5");
            bool booltestB = rangeA.Contains(4);
            if (!booltestB)
                Console.WriteLine("Range A doesn't contain 4");
            bool booltestC = rangeA.Contains(9);
            if (booltestC)
                Console.WriteLine("Range A contains 9");
            bool booltestD = rangeA.Contains(2);
            if (!booltestD)
                Console.WriteLine("Range A doesn't contain 2");
            Console.WriteLine();


            Console.WriteLine("DoesNotContains Function");
            Console.WriteLine("-----------------------------");
             booltestA = rangeB.DoesNotContain(5);
            if (!booltestA)
                Console.WriteLine("Range B contains 5");
             booltestB = rangeB.DoesNotContain(2);
            if (booltestB)
                Console.WriteLine("Range B doesn't contain 2");
             booltestC = rangeB.DoesNotContain(9);
            if (!booltestC)
                Console.WriteLine("Range B contains 9");
             booltestD = rangeB.DoesNotContain(3);
            if (booltestD)
                Console.WriteLine("Range B doesn't contain 3");
            Console.WriteLine();

            Console.WriteLine("GetAllPoints Function");
            Console.WriteLine("-----------------------------");
            Range rangeC = new Range("[0,10)");
            Range rangeD = new Range("[6,10]");

            Console.WriteLine("RangeA: ");
            foreach (var item in rangeA.GetAllPoints())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("RangeB: ");
            foreach (var item in rangeB.GetAllPoints())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("RangeC: ");
            foreach (var item in rangeC.GetAllPoints())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("RangeD: ");
            foreach (var item in rangeD.GetAllPoints())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ContainsRange Function");
            Console.WriteLine("-----------------------------");
            booltestA = rangeA.ContainsRange(new Range("(5,7)"));
            if (booltestA)
                Console.WriteLine("Range A contains the range from 5 to 7, open");
            booltestB = rangeA.ContainsRange(new Range("[5,9)"));
            if (booltestB)
                Console.WriteLine("Range A contains the range from 5 to 9 semi open");
            booltestC = rangeA.ContainsRange(new Range("[3,5)"));
            if (!booltestC)
                Console.WriteLine("Range A doesn't contain the range from 3 to 5 semi open");
            booltestD = rangeA.ContainsRange(new Range("[4,9]"));
            if (!booltestD)
                Console.WriteLine("Range A doesn't contain the range from 4 to 9 closed");
            Console.WriteLine();

            Console.WriteLine("DoesNotContainsRange Function");
            Console.WriteLine("-----------------------------");
            booltestA = rangeA.DoesNotContainRange(new Range("(5,7)"));
            if (!booltestA)
                Console.WriteLine("Range A contains the range from 5 to 7, open");
            booltestB = rangeA.DoesNotContainRange(new Range("[5,9)"));
            if (!booltestB)
                Console.WriteLine("Range A contains the range from 5 to 9 semi open");
            booltestC = rangeA.DoesNotContainRange(new Range("[3,5)"));
            if (booltestC)
                Console.WriteLine("Range A doesn't contain the range from 3 to 5 semi open");
            booltestD = rangeA.DoesNotContainRange(new Range("[4,9]"));
            if (booltestD)
                Console.WriteLine("Range A doesn't contain the range from 4 to 9 closed");
            Console.WriteLine();

            Console.WriteLine("EndPoints Function");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("RangeA: ");
            foreach (var item in rangeA.EndPoints())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("RangeB: ");
            foreach (var item in rangeB.EndPoints())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("RangeC: ");
            foreach (var item in rangeC.EndPoints())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("RangeD: ");
            foreach (var item in rangeD.EndPoints())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("OverlapsRange Function");
            Console.WriteLine("-----------------------------");
            booltestA = rangeA.OverlapsRange(new Range("[4,7)"));
            if (booltestA)
                Console.WriteLine("Range A overlaps the range from 4 to 7, semi open");
            booltestB = rangeA.OverlapsRange(new Range("[5,12]"));
            if (booltestB)
                Console.WriteLine("Range A overlaps the range from 5 to 12 closed");
            booltestC = rangeA.OverlapsRange(new Range("[1,4)"));
            if (!booltestC)
                Console.WriteLine("Range A doesn't overlap the range from 1 to 4 semi open");
            booltestD = rangeA.OverlapsRange(new Range("[12,15]"));
            if (!booltestD)
                Console.WriteLine("Range A doesn't overlap the range from 12 to 15 closed");
            Console.WriteLine();

            Console.WriteLine("DoesNotOverlapRange Function");
            Console.WriteLine("-----------------------------");
            booltestA = rangeA.DoesNotOverlapRange(new Range("[4,7)"));
            if (!booltestA)
                Console.WriteLine("Range A overlaps the range from 4 to 7, semi open");
            booltestB = rangeA.DoesNotOverlapRange(new Range("[5,12]"));
            if (!booltestB)
                Console.WriteLine("Range A overlaps the range from 5 to 12 closed");
            booltestC = rangeA.DoesNotOverlapRange(new Range("[1,4)"));
            if (booltestC)
                Console.WriteLine("Range A doesn't overlap the range from 1 to 4 semi open");
            booltestD = rangeA.DoesNotOverlapRange(new Range("[12,15]"));
            if (booltestD)
                Console.WriteLine("Range A doesn't overlap the range from 12 to 15 closed");
            Console.WriteLine();

            Console.WriteLine("Equals Function");
            Console.WriteLine("-----------------------------");
            booltestA = rangeA.Equals(new Range("(4,9]"));
            if (booltestA)
                Console.WriteLine("Range A equals the range from 4 to 9, semi open");
            booltestB = rangeB.Equals(new Range("[4,9]"));
            if (booltestB)
                Console.WriteLine("Range B equals the range from 4 to 9 closed");
            booltestC = rangeA.Equals(new Range("(1,9]"));
            if (!booltestC)
                Console.WriteLine("Range A doesn't equal the range from 1 to 9 semi open");
            booltestD = rangeB.Equals(new Range("[12,15]"));
            if (!booltestD)
                Console.WriteLine("Range B doesn't equal the range from 12 to 15 closed");
            Console.WriteLine();

            Console.WriteLine("NotEquals Function");
            Console.WriteLine("-----------------------------");
            booltestA = rangeA.NotEquals(new Range("(4,9]"));
            if (!booltestA)
                Console.WriteLine("Range A equals the range from 4 to 9, semi open");
            booltestB = rangeB.NotEquals(new Range("[4,9]"));
            if (!booltestB)
                Console.WriteLine("Range B equals the range from 4 to 9 closed");
            booltestC = rangeA.NotEquals(new Range("(1,9]"));
            if (booltestC)
                Console.WriteLine("Range A doesn't equal the range from 1 to 9 semi open");
            booltestD = rangeB.NotEquals(new Range("[12,15]"));
            if (booltestD)
                Console.WriteLine("Range B doesn't equal the range from 12 to 15 closed");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
