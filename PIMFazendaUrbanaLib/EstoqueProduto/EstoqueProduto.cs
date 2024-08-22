namespace PIMFazendaUrbanaLib
{
    public class EstoqueProduto
    {
        // Atributos/Propriedades
        public int Id { get; set; }
        public int Qtd { get; set; }
        public string Unidqtd { get; set; }
        public DateTime DataEntrada { get; set; }
        public bool StatusAtivo { get; set; }
        public string NomeCultivo { get; set; }
        public string VariedadeCultivo { get; set; }
        public string CategoriaCultivo { get; set; }
        public int IdProducao { get; set; }
        public DateTime DataProducao { get; set; }
        public DateTime DataColheita { get; set; }

    }
}
