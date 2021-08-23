using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excutaldno projeto 8 - Condicionais2");

            int indadeJoao = 16;
            int quandtidadedePessoas = 2;


            if (indadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 nos de idade pode entrara");
            }
            else
            {
                if (quandtidadedePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos mais está acompanhado");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
                }
            }


            Console.ReadLine();


        }
    }
}
