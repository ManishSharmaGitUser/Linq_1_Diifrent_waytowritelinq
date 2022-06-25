using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffrentWaysOfWritingQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lstint = new List<int> { 1, 2, 3, 4, 5, 7, 6, 8 };
            var query_syntax = from obj in lstint
                               where obj > 2
                               select obj;

            //foreach (var (item, index) in query_syntax.WithIndex())
            //{
            //    Console.WriteLine(item);
            //}

            query_syntax.ForEachWithIndex((item, idx) => Console.WriteLine("{0}: {1}", idx, item));

            Console.ReadLine();
        }


        
        //public static class EnumExtension
        //{
        //    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
        //       => self.Select((item, index) => (item, index));
        //}
    }


    public static class ForEachExtensions
    {
        public static void ForEachWithIndex<T>(this IEnumerable<T> enumerable, Action<T, int> handler)
        {
            int idx = 0;
            foreach (T item in enumerable)
                handler(item, idx++);
        }
    }

}
