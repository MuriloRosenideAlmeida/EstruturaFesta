namespace EstruturaFesta.Cadastros
{
    internal class Cliente_PJ : Cliente
    {
        public string CNPJ { get; set; }

        public Cliente_PJ(string nome, string telefone, string endereco, int id, string cnpj) : base(nome, telefone, endereco, id)
        {
            CNPJ = cnpj;
        }
    }
}
