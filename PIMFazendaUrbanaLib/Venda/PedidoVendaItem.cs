namespace PIMFazendaUrbanaLib
{
    public class PedidoVendaItem
    {
        public int Id { get; set; }
        public int Qtd { get; set; }
        public string UnidQtd { get; set; }
        public decimal Valor { get; set; }
        public int IdPedidoVenda { get; set; }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime Data { get; set; }
        public string NomeCliente { get; set; }
    }
}

