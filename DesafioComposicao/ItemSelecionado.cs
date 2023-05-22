namespace DesafioComposicao
{
    public class ItemSelecionado
    {
        private int _quantidade;
        public int Quantidade
        {
            get
            { return _quantidade; }
            set
            {
                if (value > 3)
                    Console.WriteLine("O número de itens selecionados não pode ser maior que 3!");
                else
                    _quantidade = value;
            }
        }
        public int numeroPedido;
        public Produto? produto1;
        public Produto? produto2;
        public Produto? produto3;

    }
}
