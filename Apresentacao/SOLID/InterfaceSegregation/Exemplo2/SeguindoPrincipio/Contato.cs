
namespace InterfaceSegregation.Exemplo2.SeguindoPrincipio
{
    class Contato : IDiscavel, IEmail
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
