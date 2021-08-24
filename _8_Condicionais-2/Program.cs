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
            Console.WriteLine("Excutaldno projeto 8 - Condicionais 2");

            int indadeJoao = 16;
            int quandtidadedePessoas = 2;


            bool acompanhado = quandtidadedePessoas >= 2;


            if (indadeJoao >= 18 && acompanhado== true)
            {
                Console.WriteLine("João  pode entrara");
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
