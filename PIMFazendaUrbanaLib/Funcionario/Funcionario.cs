namespace PIMFazendaUrbanaLib
{
    public class Funcionario
    {
        // Atributos/Propriedades
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool StatusAtivo { get; set; }
        public EnderecoFuncionario Endereco { get; set; }
        public TelefoneFuncionario Telefone { get; set; }
    }
}
