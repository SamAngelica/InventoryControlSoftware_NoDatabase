class Tela {

        public void Apresentação()
        {
                Console.WriteLine("::: CONTROLE DE ESTOQUE DE LICENCIADOS :::");
        }
        public int Menu()
        {
            Console.WriteLine(@"
:::MENU:::
[1] Novo Item
[2] Lista de Produtos
[3] Remover Produtos
[4] Entrada de Estoque
[5] Saída de Estoque
[0] Sair");

int menu = Convert.ToInt32(Console.ReadLine());
return menu; 

        }
        public ControleProduto PedirProduto()
        {
                ControleProduto produtos = new ControleProduto();

                Console.WriteLine("Informe a licença: ");
                produtos.Licença = Console.ReadLine();

                Console.WriteLine("Informe o nome do item: ");
                produtos.NomeItem = Console.ReadLine();

                Console.WriteLine("Informe o preço do item: ");
                produtos.Preço = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o fornecedor: ");
                produtos.Fornecedor = Console.ReadLine();

                Console.WriteLine("Informe o SKU: ");
                produtos.SKU = Convert.ToInt32 (Console.ReadLine());

                produtos.EstoqueProduto = 0;

                return produtos;

        }

        public int PedirSKU()
        {
                Console.WriteLine("Informe o SKU do item: ");
                return Convert.ToInt32 (Console.ReadLine());
                }

        public int PedirQtd()
        {
                Console.WriteLine("Informe a quantidade de itens: ");
                return Convert.ToInt32 (Console.ReadLine());
        }

        }
  
