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
        int rate { get; set; }
        public override void trans()
        {
            Console.WriteLine("Обмен волют");
        }
        public void printStatus()
        {
            Console.WriteLine("Выполнено");
        }
    }
    sealed class operatione : Transfer
    {
        int balance { get; set; }
        public void debit()
        {
            Console.WriteLine("Списание средств");
        }
        public override void trans()
        {
            Console.WriteLine("Списание средств");
        }
    }

    class pay : Transfer
    {
        int duty { get; set; }
        public void printStatus()
        {
            Console.WriteLine("Выполнено");
        }
        public override void trans()
        {
            Console.WriteLine("Платеж");
        }
    }

    class garbage_payment : Transfer
    {
        int pay { get; set; }
        public void printStatus()
        {
            Console.WriteLine("Выполнено");
        }
        public override void trans()
        {
            Console.WriteLine("Платеж за мусор");
        }
    }
    internal class Program
        {
            static void Main(string[] args)
            {
        
            }
        }
}
