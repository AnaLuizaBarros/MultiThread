using System;
using System.Threading;
namespace _3._6
{
    class Program
    {
          /*
        Integrantes: 
        Alex Barros Vasconcelos - 663877
        Ana Luiza Gonçalves Lourenço Barros - 650193
        Daniel de Pinho Matos - 287404
        Douglas Barbosa da Silva - 539301   
        Lucas Gomes Oliveira - 667357
        Lucas Alves Costa de Souza Araujo - 641119
        Matheus Vinícius Nascimento - 685670
        Patryck Kenny Pereira de Paiva - 645684
        Victor Henrique de Souza Oliveira 643287
        Vinicius de Castro - 643297
        Wernen Rodrigues - 597704 
        */
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
            Console.Write(" Integrantes:  \n"+
                         " Alex Barros Vasconcelos - 663877  \n"+
                         " Ana Luiza Gonçalves Lourenço Barros - 650193  \n"+
                         " Daniel de Pinho Matos - 287404  \n"+
                         " Douglas Barbosa da Silva - 539301  \n"+
                         " Lucas Gomes Oliveira - 667357  \n"+
                         " Lucas Alves Costa de Souza Araujo - 641119  \n"+
                         " Matheus Vinícius Nascimento - 685670  \n"+
                         " Patryck Kenny Pereira de Paiva - 645684  \n"+
                         " Victor Henrique de Souza Oliveira 643287  \n"+
                         " Vinicius de Castro - 643297  \n"+
                         " Wernen Rodrigues - 597704 \n");
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

