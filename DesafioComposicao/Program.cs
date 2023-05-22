using DesafioComposicao;

Endereco endereco = new Endereco();
endereco.rua = "Rua x";
endereco.numero = 123;
endereco.cidade = "Cidade y";
endereco.cep = "1234234";
endereco.bairro = "Bairro z";
endereco.uf = "sp".ToUpper();


Cliente cliente = new Cliente();
cliente.cpf = "32840274842";
cliente.nome = "Fulano";
cliente.email = "fulano@email.com";
cliente.endereco = endereco;

Produto produto1 = new Produto();
produto1.codigoProduto = 01;
produto1.valorUnitario = 12.00;
produto1.quantidade = 1;
produto1.descricao = "É um produto";

Produto produto2 = new Produto();
produto2.valorUnitario = 15.00;

Produto produto3 = new Produto();
produto3.valorUnitario = 10.00;

ItemSelecionado item = new ItemSelecionado();
item.produto1 = produto1;
item.produto2 = produto2;
item.produto3 = produto3;
item.numeroPedido = 1;
item.Quantidade = 1;

Pedido pedido = new Pedido();
pedido.cliente = cliente;
pedido.ItemSelecionado = item;
pedido.numeroPedido = 1;

Console.WriteLine($"Nome do cliente: {cliente.nome}");
Console.WriteLine($"Endereço do cliente: {cliente.endereco.rua}");


Console.WriteLine($"\nDescrição do produto: {produto1.descricao}");
Console.WriteLine($"Valor unitário do primeiro produto, R$: {item.produto1.valorUnitario}");
Console.WriteLine($"Valor unitário do segundo produto, R$: {item.produto2.valorUnitario}");
Console.WriteLine($"Valor unitário do terceiro produto, R$: {item.produto3.valorUnitario}");

Console.WriteLine($"\nNúmero do pedido: {pedido.numeroPedido}");
Console.WriteLine($"\nNome do cliente relacionado ao pedido: {pedido.cliente.nome}");


Console.WriteLine($"\nValor total de todos os produtos: R${pedido.GetValorTotal(produto1, produto2, produto3)}");
