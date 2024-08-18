namespace EstruturaFesta.Cadastros
{
    internal class Cliente_PF : Cliente
    {
        public string RG { get; set; }
        public string CPF { get; set; }

        public Cliente_PF(string nome, string telefone, string endereco, int id, string rg, string cpf) : base(nome, telefone, endereco, id)
        {
            RG = rg;
            CPF = cpf;
        }
    }
}
