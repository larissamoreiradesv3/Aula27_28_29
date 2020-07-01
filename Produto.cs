using System.IO;
using System.Collections.Generic;

namespace Aula27_28_29
{
    public class Produto
    {
        public Produto(string codigo, string nome, string preco) 
        {
                this.Codigo = codigo;
                this.Nome = nome;
                this.Preco = preco;
               
        }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }

        //Const = Constante
        //Comando para dar o caminho que irá seguir, para isso é necessário criar uma pasta seguindo o caminho
        private const string PATH = "Datebase/Produto.csv";

        public Produto(){
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }
        //para inserir a linha
        public void Inserir(Produto p){
            string[] linha = new string[] { Preparar(p) };
            File.AppendAllLines(PATH, linha); // e ai
        }
    public List<Produto> Ler(){
        //Criar uma lista dos Produtos
        List<Produto> produtos = new List<Produto>();
        //Transformaremos as linhas enconstradas em um array string 
        string[] linhas = File.ReadAllLines(PATH);
       
         //Varrer as linhas
        foreach (string linha in linhas){
            string[] dado = linha.Split(";");
            Produto p = new Produto();
            p.Codigo  = Separar(dado[0]);
            p.Nome    = Separar(dado[1]);
            p.Preco   = Separar(dado[2]);
            
            produtos.Add(p);
        }
        return produtos;
    }
        
        //Metodo para eparar os dados
        public string Separar(string dado){
            return dado.Split("=")[1];
        }

        //Preparar linha
        private string Preparar(Produto produto){
            //exemplo será 1, AIR MAX 90, 350,00 
            return $"codigo={produto.Codigo};nome:={produto.Nome};preço={produto.Preco}";
        }
    }
}