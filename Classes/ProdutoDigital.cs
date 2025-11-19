using SistemaEcommere.Enum;

namespace SistemaEcommere.Classe;

public class ProdutoDigital : Produto
{
    public ProdutoDigital(string nome, decimal precoBase, int estoque, CategoriaEnum categoria) : base(nome, precoBase, estoque, categoria){}
    
    public override decimal AplicarDesconto(decimal desconto)
    {
        return PrecoBase - (PrecoBase * desconto);
    }

    public override decimal CalcularPrecoFinal()
    {
        return PrecoBase;
    }
}