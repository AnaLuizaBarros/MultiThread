using System;
using System.Threading;
namespace _3._6
{
    class Program
    {
        static int x;
        static double fibo = 1;
        static double fat = 1;

         static public void Fatorial(object n) {
           
            for (int i = 1; i <= int.Parse(n.ToString()); i++)
            {
                fat *= i;
                Console.WriteLine("\n Fatorial");
                Console.WriteLine("\n " + fat);
            }
            Console.WriteLine("\n Fatorial de " + x + " e " + fat );
        }
        static public void Fibonacci(object n) {

            double n1 = 0, n2 = 1, n3=0;
            Console.WriteLine("\n Fibonacci");
            Console.Write( "\n " + n1);  
            for (int i = 2; i < int.Parse(n.ToString()); ++i) 
            {
                n3 = n1 + n2;
                Console.WriteLine("\n Fibonacci");
                Console.Write("\n " + n3 );
                n1 = n2;
                n2 = n3;    
                
            }
            fibo = n3;
            Console.Write("\n Fibonnaci e de: " + fibo +"\n");
        }
        static void Main()
        {
            Console.WriteLine("\n Programa de multithread " +
                "\n Digite um numero para o programa calcular o fatorial e" +
                "calcular o valor do enésimo termo da sequência de fibonacci \n");
            x = int.Parse(Console.ReadLine());     
            Thread thread1 = new Thread(Fatorial);
            Thread thread2 = new Thread(Fibonacci);          
            thread1.Start(x);
            Thread.Sleep(300);
            thread2.Start(x);
            Thread.Sleep(300);
            Console.WriteLine("\n\n A soma do Fibonacci e do Fatorial e de = " + ( fibo + fat));
        }    
       
    }
}

