using System.Collections.Generic;

namespace Code_Compara
{
    public class SupermercadoBIGBomPreço : Produto
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

        public SupermercadoBIGBomPreço(int id_produto, int id_mercardo)
        {
            SetId_produto(id_produto);
            SetId_mercardo(id_mercardo);
        }
        /* static void Main(string[] args)
        {
            List<Produto> itens_supermercadoBig = new List<Produto>();

                itens_supermercadoBig.Add(new Produto("Feijão", 8.99, "Feijão Turquesa 1KG Nova embalagem"));
                itens_supermercadoBig.Add(new Produto("Macarrão", 7.99, "Macarrão Vitarella 1KG"));
                itens_supermercadoBig.Add(new Produto("Café", 5.99, "Café Santa Clara pacote 1KG Tradicional"));
                itens_supermercadoBig.Add(new Produto("Leite", 4.99, "Leite Itambé pacote 1l "));
                itens_supermercadoBig.Add(new Produto("Requeijão", 7.99, "Requeijão Polenguinho Tradicional"));
                itens_supermercadoBig.Add(new Produto("Sal", 3.00, "Sal pacote 1KG Tradicional"));
        } */
                
    }
}