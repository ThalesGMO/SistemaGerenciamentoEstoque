using System.ComponentModel;
using SistemaEcommere.Classe;
using SistemaEcommere.Interface;

namespace SistemaEcommere.Repository;

public class ProdutoRepository
{
    List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        if (produtos.Any(x => x.Nome == produto.Nome))
            throw new ArgumentException("Produto já existente no banco, cadastro cancelado");
        produtos.Add(produto);
    }

    public void ListarProduto()
    {
        if (produtos.Count == 0)
            throw new ArgumentException("Lista de produtos não contém nenhum produto, adicione um produto para listar");

        foreach (Produto produto in produtos)
        {
            Console.WriteLine("====================================");
            produto.ToString();
        }
    }
}
