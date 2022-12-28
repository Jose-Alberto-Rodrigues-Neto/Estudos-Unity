using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1___testes
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] professor = { "Carlos", "Romário", "Cristiano"};
            foreach(string nome in professor)
            {
                Console.WriteLine("{0}", nome);
            }

            String linha;
            int contador = 0;
            Console.WriteLine("Entre com alguma tecla 3 vezes: ");
            while ((linha=Console.ReadLine()) != null)
            {
                contador++;

                if (contador >= 3)
                {
                    Console.WriteLine("Escolha um texto a ser repetido: ");
                    linha = linha.Replace(",", "b:"); //caso o "," seja colocado no console, ele troca por "b:"

                    linha = "O texto escolhido foi: " + linha;

                    Console.WriteLine(linha);
                }
            }
        }

    }
}
