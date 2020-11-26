namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
            {
                AdicionarCritica("Validação: Produto não informado ou identificado.");
            }
            if (Quantidade == 0)
            {
                AdicionarCritica("Validação: Quantidade não informada.");
            }
        }
    }
}
