using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 3, 5 };
            int[] array2 = { 2, 4, 6 };
            int[] arrayResult = Merge(array1, array2);
            Console.WriteLine(string.Join(",", arrayResult));
        }

        public static T[] Merge<T>(T[] array1, T[] array2) where T : IComparable<T>
        {
            List<T> list = new List<T>(array1);
            list.AddRange(array2);
            list.Sort();
            return list.ToArray();
        }
    }
}
