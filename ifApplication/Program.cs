using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor1;
            double valor2;
            double resultado;
            double quantidade;
            string qualEscolheu;
            string operaçõesBasicas;
            string operaçõesComplexas;



            Console.Write(" Que tipo de operações deseja seguir (digite as abreviações) : " + "\n" + "Operações Basicas(ob) ou Operações complexas(oc) : ");
            qualEscolheu = Console.ReadLine();

            if (qualEscolheu == "ob" || qualEscolheu == "OB") 

            {

                Console.Write("\n " + "- Qual operação deseja efetuar : +, -, x, / : ");
                operaçõesBasicas = Console.ReadLine();

                Console.Write("\n" + "- quantos valores irá usar (Ex : valor + valor = 2 valores) : ");
                quantidade = Convert.ToDouble(Console.ReadLine());

                Console.Write(" \n"+ "- Primeiro valor : ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.Write(" \n "+ "- Segundo valor : ");
                valor2 = Convert.ToDouble(Console.ReadLine());

                if (operaçõesBasicas == "+")
                {
                    resultado = valor1 + valor2;
                    Console.WriteLine("\n " + "O resultado é :" + " " + resultado);
                }

                if (operaçõesBasicas == "-")
                {
                    resultado = valor1 - valor2;
                    Console.WriteLine("\n " + "O resultado é :" + " " + resultado);
                }

                if (operaçõesBasicas == "x")
                {
                    resultado = valor1 * valor2;
                    Console.WriteLine("\n " + "O resultado é :" + " " + resultado);
                }


                if (operaçõesBasicas == "/")
                {
                    resultado = valor1 / valor2;
                    Console.WriteLine("\n " + "O resultado é :" + " " + resultado);
                }

            }
            
           

           
        
            Console.ReadKey();

        }
    }
}
