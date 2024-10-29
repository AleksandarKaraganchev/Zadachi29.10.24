using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad1
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread threadA = new Thread(PrintFromA);
            Thread threadY = new Thread(PrintFromY);
            Thread threadChild = new Thread(PrintChild);
            threadA.Start();
            threadY.Start();
            threadA.Join();
            threadY.Join();
            threadChild.Start();
            threadChild.Join();
        }
        static void PrintFromA()
        {
            char start = 'А';
            char end = 'Й';
            for (char c = start; c <= end; c++)
            {
                Console.Write(c + " ");
                Thread.Sleep(1000);
            }
        }
        static void PrintFromY()
        {
            char start = 'Я';
            for (char c = start; c >= 'А'; c--)
            {
                Console.Write(c + " ");
                Thread.Sleep(1500);
            }
        }
        static void PrintChild()
        {
            char start = 'А';
            char end = 'Я';
            for (char c = start; c <= end; c++)
            {
                Console.Write(c + " ");
                Thread.Sleep(2000);
            }
        }
    }
}
