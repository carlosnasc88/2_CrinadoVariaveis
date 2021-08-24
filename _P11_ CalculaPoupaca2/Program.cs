using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P11__CalculaPoupaca2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Excutando projeto 11 - Calcula Poupaça 2");
            double valroInvestido = 1000;



            for(int contadorMes = 1; contadorMes <= 12; contadorMes = contadorMes +1)
            {

                valroInvestido =  valroInvestido * 1.0036;

                Console.WriteLine(
                    "Após  "  +  contadorMes +  
                    " meses, vocÊ terá R$" + valroInvestido);






            }




            Console.ReadLine();




        }
    }
}
