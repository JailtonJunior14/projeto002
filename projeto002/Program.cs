using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*String nome; ///cria a variavel


             Console.WriteLine("Qual o seu nome?"); ///entrada
               nome = Console.ReadLine(); ///processamento
             Console.WriteLine("Qual seu sobrenome?");
               string sobrenome = Console.ReadLine(); ///variavel declarada na mesma linha

            Console.WriteLine("Seu nome é: " + nome + " " + sobrenome); ///saida
                Novo exemplo
                Console.WriteLine("Digite o primeiro numero: ");
                 int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                  int n2 = int.Parse(Console.ReadLine());
            Criacao da variavel e processamento
            int resultado = n1 + n2;
            Console.WriteLine("O resultado da soma é: " + resultado);

            //gasto de combustivel
            
            Console.WriteLine("Preço  do litro: ");
              double  preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Distancia");
                int distancia = int.Parse(Console.ReadLine());
            Console.WriteLine("Consumo do carro em km por litro: ");
                int consumo = int.Parse(Console.ReadLine());   
            double resultado = (distancia/consumo) * preco;
            Console.WriteLine("Valor gasto: R$: " + resultado); */

            //dias vividos

            //Console.WriteLine("Idade em anos: ");
            //    int ano = int.Parse(Console.ReadLine());

            //Console.WriteLine("Idade em meses: ");
            //    int mes = int.Parse(Console.ReadLine());

            //Console.WriteLine("Idade em dias: ");
            //    int dia = int.Parse(Console.ReadLine());

            //int resultado = ano*365 + mes*30 + dia;

            //Console.WriteLine("Voce viveu um total de: " + resultado + " dias");

            /// valor de A no B e B no A

            Console.WriteLine("Valor de A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de B:");
            int B = int.Parse(Console.ReadLine());
            int C = A;

            Console.WriteLine("Resultado A:" + (A = B));
            Console.WriteLine("Resultado B:" + (B = C));








            Console.ReadKey();
        }
    }
}
