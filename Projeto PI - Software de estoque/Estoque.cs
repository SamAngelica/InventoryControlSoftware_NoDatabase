using System;
class ControleEstoque 

{
    ControleProduto[] produtos = new ControleProduto[0];

    public void Adicionar(ControleProduto produto)
    {
        ControleProduto[] novo = new ControleProduto[produtos.Length + 1];

        for (int pos = 0; pos < produtos.Length; pos++)
        {
            novo[pos] = produtos[pos];
        }
        novo[produtos.Length] = produto;

        produtos = novo; 

    }

    public void ListarEstoque()
    {
        foreach (ControleProduto item in produtos)
        {
            Console.WriteLine("");
            Console.WriteLine($"[SKU: {item.SKU}] ({item.Licença}) {item.NomeItem} - R${item.Preço} - {item.Fornecedor} ::: Estoque: {item.EstoqueProduto}");
        }
    }

    public void Excluir(int SKU)  
    {
        int indexToRemove = -1;
        
        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i].SKU == SKU)
            {
                indexToRemove = i;
                break;
            }
        }
        if (indexToRemove >= 0)
        {
            ControleProduto[] delete = new ControleProduto[produtos.Length - 1];
            int newIndex = 0;
            for (int i = 0; i < produtos.Length; i++)
            {
                if (i != indexToRemove)
                {
                    delete[newIndex] = produtos[i];
                    newIndex++;
                }
            }
            produtos = delete;
    }
    }
    public void EntradaEstoque(int SKU, int qtd)
    {
        ControleProduto produto = null;
        foreach (ControleProduto item in produtos)
        {
            if (item.SKU == SKU)
            {produto = item;
            break;
            }
        }

        if (produto != null)
        {
            produto.EstoqueProduto += qtd;
        }
    }

    public void SaídaEstoque(int SKU, int qtd)
    {
                ControleProduto produto = null;
        foreach (ControleProduto item in produtos)
        {
            if (item.SKU == SKU)
            {produto = item;
            break;
            }
        }

        if (produto != null)
        {
            produto.EstoqueProduto -= qtd;
        }
    }

}
