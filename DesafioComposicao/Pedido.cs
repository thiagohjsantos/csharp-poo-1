namespace DesafioComposicao
{
    public class Pedido
    {
        public int numeroPedido;
        public double valorTotal;
        public Cliente? cliente;
        public ItemSelecionado? ItemSelecionado;

        public double GetValorTotal(Produto produto1, Produto produto2, Produto produto3)
        {
            return valorTotal = produto1.valorUnitario + produto2.valorUnitario + produto3.valorUnitario;
        }

        public double GetValorTotal(Produto produto1, Produto produto2)
        {
            return valorTotal = produto1.valorUnitario + produto2.valorUnitario;
        }

        public double GetValorTotal(Produto produto1)
        {
            return valorTotal += produto1.valorUnitario;
        }


    }
}
