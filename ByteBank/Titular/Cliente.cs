namespace ByteBank.Titular
{
    public class Cliente
    {
        public static int TotalClientes { get; private set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Profissao { get; set; }

        public Cliente()
        {
            TotalClientes++;
        }
    }
}
