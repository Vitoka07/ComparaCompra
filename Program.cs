using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Code_Compara
{
    class Program
    {     
        //String de conexão BD
        static string stringConexao = "Server=127.0.0.1;Database=comparacompra;Uid=root;Pwd=tristanaismymain11769;";       
            static void Main(string[] args)
        {
                //Criação das Listas
                List<Produto> itens_supermercadoExtra = new List<Produto>();

                itens_supermercadoExtra.Add(new Produto("Arroz Branco", 21.00, "100% Grãos Nobres Tio João Pacote 1kg"));
                itens_supermercadoExtra.Add(new Produto("Refrigerante Coca-Cola", 11.82, "Coca 2L Pet"));
                itens_supermercadoExtra.Add(new Produto("Chocolate Preto", 24.90, "Sustagen Kids Chocolate 380g"));
                itens_supermercadoExtra.Add(new Produto("Feijão Carioca", 7.59, "Feijão Carioca Camil Pacote 1kg "));
                itens_supermercadoExtra.Add(new Produto("Carne Moida", 9.90, "Carne Moída de Tilápia Congelada Netuno Pacote 500g"));
                itens_supermercadoExtra.Add(new Produto("Pizza Congelada", 17.29, "Pizza Congelada Calabresa Sadia Caixa 460g "));
                itens_supermercadoExtra.Add(new Produto("Biscoito Recheado", 5.69, "Biscoito recheado Oreo original multipack 144g "));
                itens_supermercadoExtra.Add(new Produto("Leite", 4.99, "Leite Semidesnatado Piracanjuba Zero Lactose 1L"));
                itens_supermercadoExtra.Add(new Produto("Picanha argentina", 70.99, "Picanha argentina 2Kg"));
                itens_supermercadoExtra.Add(new Produto("Margarina", 3.50, "Margarina Deline 300g"));

                List<Produto> itens_supermercadoBig = new List<Produto>();               

                itens_supermercadoBig.Add(new Produto("Arroz Branco", 5.49, "100% Grãos Nobres Tio João Pacote 1kg"));
                itens_supermercadoBig.Add(new Produto("Refrigerante Coca-Cola", 7.29, "Coca 2L Pet"));
                itens_supermercadoBig.Add(new Produto("Chocolate Preto", 27.97, "Sustagen Kids Chocolate 380g"));
                itens_supermercadoBig.Add(new Produto("Feijão Carioca", 8.09, "Feijão Carioca Camil Pacote 1kg "));
                itens_supermercadoBig.Add(new Produto("Carne Moida", 11.99, "Carne Moída de Tilápia Congelada Netuno Pacote 500g"));
                itens_supermercadoBig.Add(new Produto("Pizza Congelada", 18.99, "Pizza Congelada Calabresa Sadia Caixa 460g "));
                itens_supermercadoBig.Add(new Produto("Biscoito Recheado", 4.39, "Biscoito recheado Oreo original multipack 144g"));
                itens_supermercadoBig.Add(new Produto("Leite", 4.29, "Leite Semidesnatado Piracanjuba Zero Lactose 1L"));
                itens_supermercadoBig.Add(new Produto("Picanha argentina", 100, "Picanha argentina 2Kg"));
                itens_supermercadoBig.Add(new Produto("Margarina", 5, "Margarina Deline 300g"));

                
                int P;
                do
                {
                    Console.WriteLine("1 - Cadastrar Produtos, 2 - Mostrar lista de Produtos, 3 - Buscar Produto, 4 - Mostrar comparação entres os preços, 5 - Fechar aplicação");
                    P = int.Parse(Console.ReadLine());

                    switch (P)
                    {
                    //Primeiro caso:
                        case 1:
                        Console.WriteLine("Cadastro para o supermercado Extra:");
                        CadastrarInfo(itens_supermercadoExtra);
                        Console.WriteLine("\nCadastro para o supermercado Big Bom Preço");
                        CadastrarInfo(itens_supermercadoBig);
                        

                        break;

                    //Segundo caso:
                        case 2:
                        Console.WriteLine("Supermercado Extra:");
                        MostrarInfo(itens_supermercadoExtra);

                        Console.WriteLine("\n--------------------------\n");

                        Console.WriteLine("Supermercado Big Bom Preço;");
                        MostrarInfo1(itens_supermercadoBig);
                        break;

                    //Terceiro caso:
                        case 3:
                        Console.WriteLine("Supermercado Extra: ");
                        BuscarProduto(itens_supermercadoExtra);
                        Console.WriteLine("\nVerifique se o produto existe em outro supermercado \n");
                        Console.WriteLine("Supermercado Big Bom Preço");
                        BuscarProduto(itens_supermercadoBig);
                        break;

                    //Quarto caso:
                        case 4:
                        CompararProduto(itens_supermercadoExtra, itens_supermercadoBig);
                        CompararProduto(itens_supermercadoBig, itens_supermercadoBig);
                        break;
                    }
                
                }
                while (P != 5);

                
                static void CadastrarInfo(List<Produto> itens_supermercadoExtra)
                {                    
                    Produto prod = new Produto();
                    Console.WriteLine("Id produto:");
                    prod.Id_produto = Console.ReadLine();
                    Console.WriteLine("Id mercado:");
                    prod.Id_mercardo = Console.ReadLine();
                    Console.Write("Nome do produto: ");
                    prod.Nome = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    prod.Preco = float.Parse(Console.ReadLine());
                    Console.Write("Descrição do produto: ");
                    prod.Descricao = Console.ReadLine();
                    itens_supermercadoExtra.Add(prod);      

                    InserirDados(prod);               
                }
    

                static void InserirDados(Produto produto) //Extra = 1 Big bompreco = 2
                {
                     ExecutarComando("INSERT INTO produtos (id_produto ,nome_produto, descricao_produto, id_mercado, preco_produto) VALUES (@Id_produto, @Nome, @Descricao, @Id_mercado, @Preco)", 
                     new MySqlParameter("Id_produto", produto.Id_produto), new MySqlParameter("Nome", produto.Nome), new MySqlParameter("Descricao", produto.Descricao), new MySqlParameter("Id_mercado", produto.Id_mercardo), new MySqlParameter("Preco", produto.Preco));
                }
               
               
                static void ExecutarComando(string sql, params MySqlParameter[] parametros)
               {
                   MySqlConnection conexao = new MySqlConnection(stringConexao);
            try
            {
                conexao.Open();
                 MySqlCommand comando = new MySqlCommand(sql, conexao);
                foreach (MySqlParameter param in parametros)
                {
                    comando.Parameters.Add(param);
                }
                comando.ExecuteNonQuery();
                Console.WriteLine("Comando executado com sucesso!");
            }
             catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message} ... Tente novamente mais tarde.");
            }
            finally
            {
                conexao.Close();
            }
               }


                //Metodo para Mostrar listas
                static void MostrarInfo(List<Produto> itens_supermercadoExtra)
                {
                    foreach (Produto c in itens_supermercadoExtra)
                    {
                        Console.WriteLine(c.ToString());
                    }
                }
                //Metodo para Mostrar listas
                static void MostrarInfo1(List<Produto> itens_supermercadoBig)
                {
                    foreach (Produto c in itens_supermercadoBig)
                    {
                        Console.WriteLine(c.ToString());
                    }
                }

                //Metodo para Buscar produto nas listas
                static void BuscarProduto(List<Produto> itens_supermercadoExtra)
                {
                    Console.WriteLine($"Digite o Nome do produto (Buscar):");
                    string Buscar_nome = Console.ReadLine();
                    bool encontrado = false;
                    
                    foreach(Produto produtoDaVez in itens_supermercadoExtra)
                    {
                        if(produtoDaVez !=null && produtoDaVez.Nome.ToUpper().Contains(Buscar_nome.ToUpper()))
                        {
                            Console.WriteLine(produtoDaVez.ToString());
                            encontrado = true;
                            Console.WriteLine("Produto encontrado!");
                        }
                    }

                if(!encontrado)
                    {
                        Console.WriteLine("Não encontrado, Por favor verifique se o produto foi digitado corretamente!");
                    }                             
                }

                //Metodo para Comparar produtos entre as listas
                static void CompararProduto(List<Produto> itens_supermercadoExtra, List<Produto> itens_supermercadoBig)
                {
                    Console.WriteLine($"Digite o Nome do produto (Comparar):");
                    string Buscar_nome = Console.ReadLine();
                    bool comparar = false;
                    
                    foreach(Produto produtoDaVez in (itens_supermercadoExtra))
                    {
                        if(produtoDaVez !=null && produtoDaVez.Nome.ToUpper().Contains(Buscar_nome.ToUpper()))
                        {
                            Console.WriteLine(produtoDaVez.ToString());
                            Console.WriteLine(produtoDaVez.ToString());
                            comparar = true;
                            Console.WriteLine("Produto encontrado!");
                        }
                    }

                if(!comparar)
                    {
                        Console.WriteLine("Desculpe, o produto não foi encontrado!");
                    }
                    
                }
            }
        }
    }


