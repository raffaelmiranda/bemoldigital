namespace Bemol.Domain.Entities
{
    public class Cliente
    {
        public Cliente(int id, string nome, string cpf, string cep, string rua, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Cep = cep;
            Rua = rua;
            Email = email;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Cpf { get; private set; } = string.Empty;
        public string Cep { get; private set; } = string.Empty;
        public string Rua { get; private set; } = string.Empty;
        public string  Email { get; private set; } = string.Empty;
    }
}
