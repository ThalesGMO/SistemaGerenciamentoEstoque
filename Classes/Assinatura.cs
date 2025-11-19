using SistemaEcommere.Classe;
using SistemaEcommere.Enum;

namespace SistemaEcommere.Clase;

public class Assinatura : Produto
{
    public decimal Mensalidade { get; private set; }
    public Assinatura(string nome, decimal precoBase, int estoque, CategoriaEnum categoria, decimal mensalidade) : base(nome, precoBase, estoque, categoria)
    {
        SetMensalidade(mensalidade);
    }

    public void SetMensalidade(decimal mensalidade)
    {
        if (mensalidade < 0 || string.IsNullOrEmpty(mensalidade.ToString()))
            throw new ArgumentException ("Valor de mensalidade inválido");
    }
    public override decimal AplicarDesconto(decimal desconto)
    {
        return PrecoBase - (PrecoBase * desconto);
    }

    public override decimal CalcularPrecoFinal()
    {
        return  Mensalidade * 12;
    }
}
