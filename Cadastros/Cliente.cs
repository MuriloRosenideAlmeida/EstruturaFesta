namespace EstruturaFesta.Cadastros
{
    abstract class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int ID { get; set; }

        public Cliente(string nome, string telefone, string endereco, int id)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            ID = id;
        }
    }
}
