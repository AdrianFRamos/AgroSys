namespace PIMFazendaUrbanaLib

{
    public class Cliente
    {
        // Atributos/Propriedades
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public bool StatusAtivo { get; set; }
        public EnderecoCliente Endereco { get; set; }
        public TelefoneCliente Telefone { get; set; }
    }
}
