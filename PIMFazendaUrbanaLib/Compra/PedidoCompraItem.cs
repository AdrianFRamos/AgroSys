namespace PIMFazendaUrbanaLib
{
    public class PedidoCompraItem
    {
        public int Id { get; set; }
        public int Qtd { get; set; }
        public string UnidQtd { get; set; }
        public decimal Valor { get; set; }
        public int IdPedidoCompra { get; set; }
        public int IdInsumo { get; set; }
        public string NomeInsumo { get; set; }
        public DateTime Data { get; set; }
        public string NomeFornecedor { get; set; }
    }
}

