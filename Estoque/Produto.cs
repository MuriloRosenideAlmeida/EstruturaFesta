namespace EstruturaFesta.Estoque
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Material { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, float preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public float ValorTotal()
        {
            return Preco * Quantidade;
        }

    }
}
