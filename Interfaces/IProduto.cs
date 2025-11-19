namespace SistemaEcommere.Interface; 

public interface IProduto
{
  public decimal CalcularPrecoFinal();
  public decimal AplicarDesconto(decimal desconto);
}
