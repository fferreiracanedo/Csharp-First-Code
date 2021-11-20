using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)


        {

            /*===========Tipos============*/
            // Int - Numeros Inteiros (Negativos e Positivos)
            // Float - Numeros com viruglas , tanto positivos quanto negativos ===> (Double|Decimal)
            // Bool - Dados boleanos (True or False)
            // String - Tipo de dado identificado com ("")


            //Regras variavel //
            // Não pode haver variaveis com o mesmo nome no mesmo lugar
            // Caracteres de A-Z
            // Numeros de 0-9
            // Sem caracteres especiais
            // Pode haver _ (UnderLine)
            // Não pode haver palavras reservadas (if, init, using, etcc)



            int segunda_Guerra_Mundial = 1942;
            string corFavorita = "Azul";
            float velocidadeF1 = 233.5f;
            bool segundaGuerraMundialaconteceu = true;







            Console.WriteLine(segunda_Guerra_Mundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialaconteceu);


            velocidadeF1 = 348.29f;
            corFavorita = "Rosa";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);

            Console.ReadLine();


        }
    }
}
