class Tela {

        public void Apresentação()
        {
                Console.WriteLine("::: CONTROLE DE ESTOQUE DE LICENCIADOS :::");
        }
        public int Menu()
        {
            Console.WriteLine(@"
[1] Novo Item
[2] Lista de Produtos
[3] Remover Produtos
[4] Entrada de Estoque
[5] Saída de Estoque
[0] Sair");

int menu = Convert.ToInt32(Console.ReadLine());
return menu; 

        }

        public Produto PedirProduto()
        {
                Produto produtos = new Produto();

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

                produtos.Estoque = 0;

                return produtos;

        }

        public string PedirNome()
        {
                Console.WriteLine("Informe o nome do item: ");
                return Console.ReadLine();
                }

        public int PedirQtd()
        {
                Console.WriteLine("Informe a quamtidade de itens: ");
                return Convert.ToInt32 (Console.ReadLine());
        }

        }
  