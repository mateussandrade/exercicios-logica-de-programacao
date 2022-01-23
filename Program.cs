using System;

namespace Atividades
{
    class Program
    {
         static void Main(string[] args)
        {
            int escolha;

            Console.WriteLine("Escolha sua atividade opções de 1-5");
            escolha = Convert.ToInt32((Console.ReadLine()));
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você Escolheu Atividade 1 - SOMA");
                    double a, b, soma;
                    Console.WriteLine("Digite o primeiro valor:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor:");
                    b = Convert.ToDouble(Console.ReadLine());                    
                    soma = a + b;
                    Console.WriteLine("Total:" + "\n" + a + "+" + b + "=" + soma);                                   
                    break;

                case 2:                    
                    Console.WriteLine("Atividade 2 - Ler o raio do circulo");
                    Console.WriteLine("Digite o valor da área:");
                    double areaCirculo, raioCirculo;
                    areaCirculo = 0; raioCirculo = 0;
                    raioCirculo = Convert.ToDouble(Console.ReadLine());
                    areaCirculo = Math.PI * Math.Pow(raioCirculo, 2);
                    Console.WriteLine("A área do círculo é: " + areaCirculo.ToString("N4"));
                    Console.ReadKey();
                    break;
               

            }
        }
    }
}
           
