using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_002_18_11
{
    public class Program
    {
        static void Main(string[] args)
        {
         
 
            {
                Console.Write("Digite a altura da pessoa: ");
                decimal altura = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o sexo (1 para feminino, 2 para masculino): ");
                int sexo = Convert.ToInt32(Console.ReadLine());

                decimal pesoIdeal;

                if (sexo == 1)
                {
                    pesoIdeal = (62.1m * altura) - 44.7m;
                    Console.WriteLine($"O peso ideal para uma mulher com altura {altura} é {pesoIdeal:F2} kg.");
                }
                else if (sexo == 2)
                {
                    pesoIdeal = (72.7m * altura) - 58m;
                    Console.WriteLine($"O peso ideal para um homem com altura {altura} é {pesoIdeal:F2} kg.");
                }
                else
                {
                    Console.WriteLine("Opção de sexo inválida. Digite 1 para feminino ou 2 para masculino.");

                    {
                       Console.ReadLine();
                    }
                }
            }
        }

    }
}
   
       
