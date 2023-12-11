using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_V1
{
    class Program
    {
        static void Main(string[] args)
        {//inicio

            int op;
            double Resultado = 0, A, B, C;

            Console.WriteLine("Calculadora V1\n\n");
            Console.WriteLine("intrudoza uma das opções\n");
            Console.WriteLine("1- Somar");
            Console.WriteLine("2- subtrair");
            Console.WriteLine("3- multiplicar");
            Console.WriteLine("4- dividir");
            Console.WriteLine("5- calculo da raiz quadrada");
            Console.WriteLine("6- calculo de uma esquação de 2º grau");
            Console.WriteLine("7- calculo do factorial");
            Console.WriteLine("8- calculo da area de um triangulo");
            Console.WriteLine("9- calculo do volume de uma priramide");
            Console.WriteLine("10- calculo da area de um retangulo");
            Console.WriteLine("11- calculo do volume de um paralelipipedo");
            Console.WriteLine("12- calculo da area de um circulo");
            Console.WriteLine("13- calculo de volume de uma esfera");


            Console.Write("A opção que escolheu foi:  ");

            op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introduza um valor para A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduza um valor para B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduza um valor para C");
            C = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Console.WriteLine("Escolheu Somar");
                        Console.WriteLine("introduza um valor para A");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("introduza um valor para B");
                        B = Convert.ToInt32(Console.ReadLine());
                        Resultado = A + B;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Escolheu Subtrair");
                        Console.WriteLine("introduza um valor para A");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("introduza um valor para B");
                        B = Convert.ToInt32(Console.ReadLine());
                        Resultado = A - B;
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Escolheu Multiplicar");
                        Resultado = A * B;
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Escolheu Dividir");
                        Resultado = A / B;
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Escolheu Calculo da raiz quadrada");
                        Resultado = Math.Sqrt(A); // calculo da raiz quadrada, não á raizes de numero negativos
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Escolheu Calculo da equação de 2º grau");
                        Math.Sqrt(Resultado);
                        Resultado = -B + Math.Sqrt((B * B) - 4 * (A * C)) / (2 * A);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Escolheu Calculo do fatorial");
                        while (A!= 1)
                        {
                            Resultado = Resultado * A;
                            Resultado = Resultado - 1;
                        }

                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Voce escolheu calculo da area de um triangulo, escreva de acordo com a altura e vertice da base (A = altura, B = vertice)");
                        Resultado = (B * B / 2) * A;
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Voce escolheu calculo do volume de uma piramide, escreva de acordo com a altura e vertice da base (A = altura, B = vertice)");
                        Resultado = ((B * B) * A) / 3;
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Voce escolheu calculo da area de um retangulo , escreva de acordo com a altura e comprimento (A = altura, B = comprimento)");
                        Resultado = B * A;
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Voce escolheu calculo da volume  de um paralelipipedo, escreva de acordo com a altura e vertice da base (A = altura, B = vertice)");
                        Resultado = B * B * A;
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Voce escolheu calculo da area de um circulo, escreva de acordo com o PI e Raio do circulo (A = PI, B = Raio)");
                        Resultado = A * (B * B);
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("Voce escolheu calculo do volume da esfera, escreva de acordo com o PI e Raio da esfera (A = PI, B = Raio)");
                        Resultado = 4 * A * (B * B * B) ;
                        break;
                    }
                default:
                    Console.WriteLine("Não existe esta opção");
                    break;
            }
            Console.WriteLine("O Resultado da operação é:    ");
            Console.WriteLine(Resultado);

            Console.ReadKey();

        }//fim
    }
}
