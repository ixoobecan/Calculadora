using System;

namespace Calculadora
{
     class Program
    {
        public static void Main(string[] args)
        {
            int n1, n2, resultado = 0, s, n;

            Console.WriteLine("Olá Mallu, vamos calcular,");

            string operacao;
            Console.WriteLine(" Diga um numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação: ");
            operacao = Console.ReadLine();

            Console.WriteLine("por:");
            n2 = int.Parse(Console.ReadLine());

            switch(operacao) 
            {
                case "+": resultado= n1 +n2;
                    break;
                case "-": resultado= n1 -n2;
                    break;
                case "/": resultado = n1/n2;
                    break;
                case "*": resultado = n1 * n2;
                    break;
                default :
                    Console.WriteLine("operação inválida!");
                    break;
            }
            Console.WriteLine("{0} {1} {2}= {3}", n1, operacao, n2, resultado);
            
                Console.ReadKey(true);
        }  
    }
}
