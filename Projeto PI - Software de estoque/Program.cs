namespace Projeto_PI___Software_de_estoque;

// ESSE ESTOQUE É PARA O SEGMENTO DE PRODUTOS LICENCIADOS.
class Program
{
    static void Main(string[] args)
    {
        Estoque estoque = new Estoque();

        Tela tela = new Tela();
        tela.Apresentação();

        int Menu = tela.Menu();
        while (Menu != 0)
        {
            if (Menu == 1)
            {
                Produto produtos = tela.PedirProduto();
                estoque.Adicionar(produtos);
                tela.Menu();
            }
            else if (Menu == 2)
            {
                estoque.ListarEstoque();
                tela.Menu();
            }
            else if (Menu == 3)
            {
                // [3] Remover Produtos
            }
            else if (Menu == 4)
            {
                string nome = tela.PedirNome();
                int qtd = tela.PedirQtd();
                estoque.EntradaEstoque(nome,qtd);
            }
            else if (Menu == 5)
            {
                // [5] Saída de Estoque
            }

            else
            {
                break;
            }

        }

    }
}
