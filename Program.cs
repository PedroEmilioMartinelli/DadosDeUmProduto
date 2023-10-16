using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produtos p = new Produtos();

            Console.WriteLine("ENTRE OS DADOS DO PRODUTO");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Qual a quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados do produto: " + p);



        }
    }
}
