using SistemaEcommere.Enum;
using SistemaEcommere.Interface;

namespace SistemaEcommere.Classe;

public abstract class Produto : IProduto
{
    public string? Nome { get; private set; }
    public decimal PrecoBase { get; private set; }
    public int Estoque { get; private set; }
    public CategoriaEnum Categoria { get; private set; }

    public Produto(string nome, decimal precoBase, int estoque, CategoriaEnum categoria)
    {
        setName(nome);
        PrecoBase = precoBase;
        Estoque = estoque;
        Categoria = categoria;
    }

    public void setName(string nome)
    {
        if (string.IsNullOrEmpty(nome) || nome.Length < 3)
            throw new ArgumentException("Nome adicionado inválido");
        Nome = nome;
    }

    public void setPrice(decimal preco)
    {
        if (preco <= 0 || string.IsNullOrEmpty(preco.ToString()))
            throw new ArgumentException("Valor adicionado inválido");
        PrecoBase = preco;
    }

    public void SetEstoque(int estoque)
    {
        if (estoque <= 0 || string.IsNullOrEmpty(estoque.ToString()))
            throw new ArgumentException("Valor adicionado inválido");
        Estoque = estoque;
    }

    public override string ToString()
    {
        return @$"
        Nome: {Nome}
        Preço base {PrecoBase:C}
        Categoria {Categoria}
        Preço final {CalcularPrecoFinal():C}";
    }
    public abstract decimal CalcularPrecoFinal();
    public abstract decimal AplicarDesconto(decimal desconto);
}
