namespace RestApi.Domain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool IsDisponible { get; set; }
    }
}
