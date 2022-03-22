using System;

namespace _2._2
{
    class Program
    {
        public static void arr(int[] a,int[] b) {
            int k,t=0;
            bool flag = false;
            k = a.Length - b.Length;
            int[] mas = new int[k];
            int[] arr_result = new int[a.Length];
            arr_result = a;
            for (int i=0;i<a.Length;i++) {
                for (int j = 0; j < b.Length; j++) {
                    if (a[i] == b[j]) {
                        flag = true; 
                    }
                }
                if (flag)
                {
                    mas[i]
                }
            }
            for (int u = 0; u < k; u++) {
                Console.Write($" {mas[u]}");
            }
        }
        static void Main(string[] args)
        {
            int n,c;
            n = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[c];
            for (int i=0; i < n; i++){ 
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < c; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());
            }
            Program.arr(a,b);
        }
    }
}
