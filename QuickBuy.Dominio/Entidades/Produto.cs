namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Validação: Nome precisa ser informado.");
            }
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Validação: Descricao precisa ser informado.");
            }
            if (Preco == 0)
            {
                AdicionarCritica("Validação: Preço precisa ser informado.");
            }
        }
    }
}
