using System;

namespace Aula27_28_29
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto p1 = new Produto();
           p1.Codigo = 1;
           p1.Nome = "Air Max 90";
           p1.Preco = "350,00";

           p1.Inserir(p1);
        }
    }
}
