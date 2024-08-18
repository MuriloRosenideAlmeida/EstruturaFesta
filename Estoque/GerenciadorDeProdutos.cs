using EstruturaFesta.Estoque;

public class GerenciadorDeProdutos {
    private List<Produto> listaDeProdutos;
    private List<Reserva> listaDeReservas;

    public GerenciadorDeProdutos() {
        listaDeProdutos = new List<Produto>();
        listaDeReservas = new List<Reserva>();
    }

    // Método para adicionar um produto
    public void AdicionarProduto(string nome, float preco, int quantidade) {
        Produto produto = new Produto(nome, preco, quantidade);
        listaDeProdutos.Add(produto);
    }

    // Método para remover um produto pelo nome
    public void RemoverProduto(string nome) {
        listaDeProdutos.RemoveAll(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }

    // Método para listar todos os produtos
    public void ListarProdutos() {
        foreach (var produto in listaDeProdutos) {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}");
        }
    }

    // Método para encontrar um produto pelo nome
    public Produto BuscarProduto(string nome) {
        return listaDeProdutos.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }
    public void CriarReserva(string nomeProduto, int quantidade, DateTime dataEntrada, DateTime dataSaida) {
        Produto produto = BuscarProduto(nomeProduto);
        if (produto != null) {
            try {
                var reserva = new Reserva(produto, quantidade, dataEntrada, dataSaida);
                listaDeReservas.Add(reserva);
                Console.WriteLine($"Reserva criada para {produto.Nome}: {quantidade} unidades reservadas de {dataEntrada.ToShortDateString()} até {dataSaida.ToShortDateString()}.");
            } 
            catch (InvalidOperationException ex) {
                Console.WriteLine(ex.Message); // Captura e exibe o erro de reserva
            }
        } 
        else {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}
