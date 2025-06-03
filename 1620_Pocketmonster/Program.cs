using System;
using System.Text;

namespace _1620_Pocketmonster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nm = Console.ReadLine().Split();
            Int32 n = Int32.Parse(nm[0]);
            Int32 m = Int32.Parse(nm[1]);

            Dictionary<Int32, String> d = new Dictionary<Int32, String>();
            Dictionary<String, Int32> d2 = new Dictionary<String, Int32>();

            for (Int32 i = 1; i <= n; i++)
            {
                String pk = Console.ReadLine();
                d.Add(i, pk);
                d2.Add(pk, i);
            }

            StringBuilder sb = new StringBuilder();

            for(Int32 i = 0; i < m; i++)
            {
                String s = Console.ReadLine();

                if (d2.ContainsKey(s))
                {
                    sb.AppendLine(Convert.ToString(d2[s]));
                }
                else
                {
                    sb.AppendLine(d[Int32.Parse(s)]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
