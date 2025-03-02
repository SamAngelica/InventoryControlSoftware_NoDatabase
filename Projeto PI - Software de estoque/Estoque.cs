class Estoque {
    Produto[] produtos = new Produto[0];

    public void Adicionar(Produto produto)
    {
        Produto[] novo = new Produto[produtos.Length + 1];

        for (int pos = 0; pos < produtos.Length; pos++)
        {
            novo[pos] = produtos[pos];
        }
        novo[produtos.Length] = produto;

        produtos = novo; 

    }

    public void ListarEstoque()
    {
        foreach (Produto item in produtos)
        {
            Console.WriteLine($"({item.Licença}) {item.NomeItem} - {item.SKU} - {item.Preço} - {item.Fornecedor}::: Estoque: {item.Estoque}");
        }
    }

    public void EntradaEstoque(string nome, int qtd)
    {
        Produto produto = null;
        foreach (Produto item in produtos)
        {
            if (item.NomeItem == nome)
            {produto = item;
            break;
            }
        }

        if (produto != null)
        {
            produto.Estoque += qtd;
        }
    }


}