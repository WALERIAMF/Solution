using System;

namespace RestApi.Domain.Entities
{
    public class Client : Base
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsActive { get; set; }
    }
}
