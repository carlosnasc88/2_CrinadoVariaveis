using System;

namespace _3_CriandoVariaveisPotoflutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultado projeto3 criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 /3 = " + idade);


            Console.WriteLine("A execução acabou. Tecle Enter para sair");
            Console.ReadLine();
        }
    }
}
