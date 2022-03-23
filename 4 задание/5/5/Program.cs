using System;
using System.Collections.Generic;

namespace _5
{
    abstract class Transfer
    {
        public abstract void trans();
    }
    class Currency_exchange : Transfer
    {
        public override void trans()
        {
            Console.WriteLine("Обмен волют");
        }
        public void printStatus()
        {
            Console.WriteLine("Выполнено");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
}
