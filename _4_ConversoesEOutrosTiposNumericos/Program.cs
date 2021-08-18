using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excutando o projeto 4");

            double salario;
            salario = 1200.5;

            //O inet é variavel que suporta valores de até 32nt
            int salarioEminteiro;
            salarioEminteiro = (int) salario;

            Console.WriteLine(salarioEminteiro);
            //O long é variavel que suporta valores de até 64bt
            long idade;
            idade = 13000000000;
            Console.WriteLine(idade);

            //O short é variavel que suporta valores de até 32nt
            short quantidadeProduto;
            quantidadeProduto = 150;
            Console.WriteLine(quantidadeProduto);

            float altuta;
            altuta = 1.85f;
            Console.WriteLine(altuta);

            Console.ReadLine();





        }
    }
}
