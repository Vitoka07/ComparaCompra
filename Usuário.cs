namespace Code_Compara
{
    public class Usuário
    {
        public Usuário(string nome_cliente, int id_cliente)
        {
            Nome_cliente = nome_cliente;
            Id_cliente = id_cliente;
        }

        public Usuário(){}
        public string Nome_cliente { get; set; }
        public int Id_cliente { get; set; }

    }
}