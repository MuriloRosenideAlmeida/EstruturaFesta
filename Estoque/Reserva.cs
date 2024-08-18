using EstruturaFesta.Estoque;

public class Reserva {
    public Produto Produto { get; private set; }
    public DateTime DataEntrada { get; private set; }
    public DateTime DataSaida { get; private set; }
    public int QuantidadeReservada { get; private set; }

    public Reserva(Produto produto, int quantidade, DateTime dataEntrada, DateTime dataSaida) {
        Produto = produto;
        QuantidadeReservada = quantidade;
        DataEntrada = dataEntrada;
        DataSaida = dataSaida;

        ReservarProduto();
    }

    // Método para reservar o produto
    private void ReservarProduto() {
        if (Produto.Quantidade >= QuantidadeReservada) {
            Produto.Quantidade -= QuantidadeReservada;
        } else {
            throw new InvalidOperationException("Quantidade insuficiente para reserva.");
        }
    }

    // Método para retornar o produto ao estoque
    public void RetornarProdutoAoEstoque() {
        Produto.Quantidade += QuantidadeReservada;
    }
}

