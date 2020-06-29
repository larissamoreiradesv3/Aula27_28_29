using System.IO;

namespace Aula27_28_29
{
    public class Produto
    {
        public int Codigo { get; set; }
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
        //Mostrar linha
        private string Preparar(Produto produto){
            //exemplo será 1, AIR MAX 90, 350,00 
            //AH ta bom, um AIR MAX por 90 conto?
            return $"codigo={produto.Codigo};nome:={produto.Nome};preço={produto.Preco}";
        }
    }
}