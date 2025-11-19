using SistemaEcommere.Classe;
using SistemaEcommere.Enum;
using SistemaEcommere.Repository;
namespace SistemaEcommere.Ui;

public class MenuProdutovirtual
{
    public void CadastrarProdutoFisico()
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string? nome = Console.ReadLine();

            Console.Write("Digite o Preço Base do produto: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal precoBase))
            {
                Console.WriteLine("Valor inválido, coloque outro valor");
                return;
            }

            Console.Write("Digite a quantidade inicial de estoque para esse produto: ");
            if (!int.TryParse(Console.ReadLine(), out int estoque))
            {
                Console.WriteLine("Valor inválido para estoque, coloque outro valor");
                return;
            }

            CategoriaEnum categoria = CategoriaEnum.Eletronico;

            ProdutoDigital produtoDigital = new ProdutoDigital(nome, precoBase, estoque, categoria);
            ProdutoRepository produtoRepository = new ProdutoRepository();
            produtoRepository.AdicionarProduto(produtoDigital);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Cadastro de produto inválido: {ex.Message}");
            return;
        }
        Console.WriteLine("Produto inserido com sucesso");
    }
}

