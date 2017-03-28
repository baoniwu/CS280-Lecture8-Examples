using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vectors[] vectors = new Vectors[10];
            Random random = new Random();
            for (int index = 0; index < vectors.Length; index++)
                vectors[index] = new Vectors(random);

            Console.WriteLine("排序前:");
            foreach (Vectors v in vectors)
                Console.WriteLine(v);

            Console.WriteLine("請選擇排序欄位: 1.X, 2.Y, 3.Length");
            int selection = int.Parse(Console.ReadLine());
            Vectors.Selection = selection;

            Array.Sort(vectors);
            Console.WriteLine("排序後:");
            foreach (Vectors v in vectors)
                Console.WriteLine(v);
        }
    }
}