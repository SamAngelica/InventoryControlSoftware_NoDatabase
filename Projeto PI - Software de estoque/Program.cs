// ESSE ESTOQUE É PARA O SEGMENTO DE PRODUTOS LICENCIADOS.

ControleEstoque estoque = new ControleEstoque();

Tela tela = new Tela();
tela.Apresentação();

int menu = tela.Menu();
while (menu != 0)
{
    if (menu == 1) // Adicionar Produto
    {
        ControleProduto produtos = tela.PedirProduto();
        estoque.Adicionar(produtos);
        Console.WriteLine(@"
Produto adicionado!");
    }

    else if (menu == 2) // Lista de Produtos cadastrados
    {
        estoque.ListarEstoque();
    }
    else if (menu == 3) // Remover Produtos
    {
        int SKU = tela.PedirSKU();
        estoque.Excluir(SKU);
        Console.WriteLine(@"
Produto excluído.");
    }
    else if (menu == 4) // Entrada de Estoque
    {
        int SKU = tela.PedirSKU();
        int qtd = tela.PedirQtd();
        estoque.EntradaEstoque(SKU, qtd);
        Console.WriteLine(@"
Estoque atualizado.");
    }
    else if (menu == 5) // Saída de Estoque
    {
        int SKU = tela.PedirSKU();
        int qtd = tela.PedirQtd();
        estoque.SaídaEstoque(SKU, qtd);
        Console.WriteLine(@"
Estoque atualizado.");
    }

    menu = tela.Menu();

}
