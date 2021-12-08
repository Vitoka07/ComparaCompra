using System.Collections.Generic;

namespace Code_Compara
{
    public class SupermercadoExtra : Produto
    {
        private int id_produto;

        public int GetId_produto()
        {
            return id_produto;
        }

        public void SetId_produto(int value)
        {
            id_produto = value;
        }

        private int id_mercardo;

        public int GetId_mercardo()
        {
            return id_mercardo;
        }

        public void SetId_mercardo(int value)
        {
            id_mercardo = value;
        }

        public SupermercadoExtra(int id_produto, int id_mercardo)
        {
            SetId_produto(id_produto);
            SetId_mercardo(id_mercardo);
        }

        public SupermercadoExtra(int id_mercardo)
        {
            SetId_mercardo(id_mercardo);
        }

        /* static void Main(string[] args)
        {
             List<Produto> itens_supermercadoExtra = new List<Produto>();

               itens_supermercadoExtra.Add(new Produto("Feijão", 10.99, "Feijão Turquesa 1KG Nova embalagem"));
               itens_supermercadoExtra.Add(new Produto("Macarrão", 7.99, "Macarrão Vitarella 1KG"));
               itens_supermercadoExtra.Add(new Produto("Café", 5.99, "Café Santa Clara pacote 1KG Tradicional"));
               itens_supermercadoExtra.Add(new Produto("Leite", 5.99, "Leite Itambé pacote 1l "));
               itens_supermercadoExtra.Add(new Produto("Requeijão", 8.99, "Requeijão Polenguinho Tradicional"));
               itens_supermercadoExtra.Add(new Produto("Sal", 2.50, "Sal pacote 1KG Tradicional"));
        } */

    }
}