using System.Threading.Channels;
using EstruturaFesta.Cadastros;
using EstruturaFesta.Estoque;

namespace EstruturaFesta
{
    internal class Contrato {
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public float ValorTotal { get; set; }
        public float Pagamento { get; set; }

        public Contrato() {
        }

    }
}
