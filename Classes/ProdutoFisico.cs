using SistemaEcommere.Enum;

namespace SistemaEcommere.Classe;

public class ProdutoFisico : Produto
{
    public decimal Frete {get; private set;}
    public ProdutoFisico(string nome, decimal precoBase, int estoque, CategoriaEnum categoria, decimal frete) : base(nome, precoBase, estoque, categoria)
    {
        SetFrete(frete);
    }

    public void SetFrete(decimal frete)
    {
        if (Frete < 0 || string.IsNullOrEmpty(Frete.ToString()))
            throw new ArgumentException ("Valor de frete inválido");
        Frete = frete;
    }
    
    public override decimal AplicarDesconto(decimal desconto)
    {
        return PrecoBase - (PrecoBase * desconto);
    }

    public override decimal CalcularPrecoFinal()
    {
        return PrecoBase + Frete;
    }
}
