    using System;

namespace ProjetoPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido p1 = new Pedido();
            p1.numero = 1;
            p1.dataHora = DateTime.Now;
            p1.situacao = (int)Situacao.Faturado;
            Console.WriteLine("Número do pedido: " + p1.numero.ToString());
        Console.WriteLine("Data do pedido: " + p1.dataHora.ToString());
            Console.WriteLine("Situação do pedido: " + p1.situacao.ToString());

            Console.ReadKey();
        }
    }
}
