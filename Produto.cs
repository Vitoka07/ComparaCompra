namespace Code_Compara
{
    public class Produto
    {
        public Produto(){}

        public Produto(string nome, double preco, string descricao)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public string Id_produto { get; internal set; }
        public string Id_mercardo { get; internal set; }

        public override string ToString()
        {
            return $"{Nome} | {Preco} | {Descricao}";
        }
    }
}