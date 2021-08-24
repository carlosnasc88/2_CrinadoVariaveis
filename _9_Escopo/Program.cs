using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excutaldno projeto 9 - Escopo");

            int indadeJoao = 16;            
            bool  acompanhado = false;
            string mensagemAdicional;



          
            if (acompanhado == true)

            {
                 mensagemAdicional = "João está acompnhado";

                Console.WriteLine(mensagemAdicional);




            }
            else
            {
               mensagemAdicional = "João não está acompnahdo";
            }
            if (indadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João  pode entrara");
                Console.WriteLine(mensagemAdicional);

            }
            else
            {

                {
                    Console.WriteLine("João não  pode entrar");
                }
            }


            Console.ReadLine();


        }
    }
}


//Nessa aula, aprendemos:

//como usar o if;
//como usar as operações lógicas AND (&&) e OR(||);
//trabalhar com o escopo de variáveis.