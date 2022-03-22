using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            

            string str = Console.ReadLine();
            string[] nm_str = str.Split(' ',';',',','.');
            //Console.WriteLine(nm_str[1]);
            int[] nm_int = Array.ConvertAll(nm_str, s => int.Parse(s));
            int n = nm_int[0] * nm_int[1];
            int nrow = nm_int[0];
            int ncolumn = nm_int[1];
            int[] mass = new int[n];
            int[,] mass_t = new int[nrow,ncolumn];
            Console.WriteLine("\nОдномерный массив");
            for (int i = 0; i < n; i++)
            {
                mass[i] = ran.Next(20);
                Console.Write(mass[i] + ",");
            }

            Console.Write("\n<-------------------------------------->\n\n");
            Console.Write("Двумерный  массив");
            for (int i = 0; i < nm_int[0];i++)
            {
                Console.Write("\n");
                for (int j = 0; j < nm_int[1]; j++)
                {
                    mass_t[i, j] = ran.Next(20);
                    Console.Write(mass_t[i, j] + "\t");

                }
                
            }


            Console.Write("\n<-------------------------------------->\n\n");
            Console.WriteLine("Двумерный ступенчитый массив");
            int nm_int_len = nm_int.Length;
            int max = 0;
            for (int i = 0;i< nm_int_len; i++)
            {
                if(max< nm_int[i])
                {
                    
                    max = nm_int[i];
                }
            }

            int[,] arr_step = new int[nm_int_len,max];
            for(int i = 0;i< nm_int_len; i++)
            {
                int b = nm_int[i];
                for (int j = 0; j <b; j++)
                {
                    arr_step[i, j] = ran.Next(20);
                    Console.Write(arr_step[i, j] + "\t");
                }
                Console.WriteLine("");
            }








            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
