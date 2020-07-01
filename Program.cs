using System;
using System.Collections.Generic;
namespace Aula27_28_29
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto p1 = new Produto();
           p1.Codigo = "1";
           p1.Nome = "Air Max 90";
           p1.Preco = "R$ 350,00";
          
           p1.Inserir(p1);
           
           List<Produto> lista = p1.Ler();
           Console.WriteLine("Lista de Produtos Solicitados:");
           foreach (Produto item in lista){
               Console.WriteLine($"{item.Preco} - {item.Nome}");
           } 
        }
    }
}
