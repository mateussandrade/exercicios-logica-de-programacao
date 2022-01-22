using System;
;
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
                    double a, b, c, d, e, f, soma, soma2, soma3;
                    a = 10; b = 30; c = -30; d = 10; e = 0; f = 0;
                    soma = a + b; soma2 = c + d; soma3 = e + f;
                    Console.WriteLine("Atividade 1 - Soma");
                    Console.WriteLine("A soma de " + a + "+" + b + " é igual a " + soma);
                    Console.WriteLine("A soma de " + c + "+" + d + " é igual a " + soma2);
                    Console.WriteLine("A soma de " + e + "+" + f + " é igual a " + soma3);
                    
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
           
