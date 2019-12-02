using System;

namespace Guara
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int tam = n;

            int inv = d;

            int[] aux = new int[tam];
            int k = 0;
            int pos = inv;

            for (int i = 0; i < tam; i++)
            {
                if (i < inv)
                {
                    aux[tam - pos] = (i + 1);
                    pos--;
                }
                else
                {
                    aux[k] = a[i];
                    k++;
                }                
            }

            Console.WriteLine("{0}", string.Join(" ", aux));     
        }
    }
}
