using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Excutando o projeto  - Cararacteres e texto");

            //character - char uma varivel de 16bt
            char primeiraLeta = 'a';
            Console.WriteLine(primeiraLeta);

            primeiraLeta = (char)65;
            Console.WriteLine(primeiraLeta);



            primeiraLeta = (char) (primeiraLeta + 1);
            Console.WriteLine(primeiraLeta);



            string titulo = " Alura Curso de tecnologia" +2021;
            Console.WriteLine(titulo);

            string cursosProgramação =
 @"
 - .NET
 -  Jawa
 -  Jawascript";

            Console.WriteLine(cursosProgramação);





            //Exercicio:
            string saudacao = "Ola meu nome é ";
            string nome = "Romulo";
            string continuacao = "e minah idade é ";
            int idade = 100;

            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.ReadLine();
        }
    }
}
