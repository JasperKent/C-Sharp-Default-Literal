using System;
using System.Collections.Generic;
using System.Linq;

namespace Default
{
    public static class Extensions
    {
        public static T MaxOrDefault<T>(this IEnumerable<T> list)
        {
            if (list.Count() > 0)
                return list.Max();
            else
            {
                var val = default(T);
                return val;
            }
        }
    }

    class Program
    { 
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        static void Main()
        {
            //Days day;

            //if (Console.ReadLine() == "Thursday")
            //    day = Days.Thursday;
            //else
            //    day = Days.Friday;

            //switch (day)
            //{
            //    case Days.Saturday:
            //    case Days.Sunday:
            //        Console.WriteLine("It's a weekend");
            //        break;
            //    default:
            //        Console.WriteLine("It's a weekday");
            //        break;
            //}

            //Tuple<string, string, int> rt = default;
            //ValueTuple<string, string, int> vt = default;

            //Console.WriteLine(rt);
            //Console.WriteLine(vt);

            //var sc = new SomeClass();

            //Console.WriteLine(sc);

            //var ss = new SomeStruct();

            //Console.WriteLine(ss);

            var ints = new List<int>();// { 1, 2, 3, 4 };
            var strings = new List<string>();// { "Thomas", "Richard", "Harriet", "Charlotte" };

            Console.WriteLine(ints.MaxOrDefault());
            Console.WriteLine(strings.MaxOrDefault());
        }
    }
}
