namespace SistemaEcommere.Ui;

public class MenuAdicaoProduto
{
    MenuProdutoFisico menuProdutoFisico = new MenuProdutoFisico();
    public void Menu()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine(@$"
            1 - Produto Físico
            2 - Produto Virtual
            3 - Assinatura
            4 - Sair");
            
            string escolha = Console.ReadLine();
            switch (escolha)
            {
               case "1": menuProdutoFisico.CadastrarProdutoFisico(); break;
                // "2" =>  ,
                // "3" =>  ,
               case "4": loop = false; break;
                // "5" => loop = false,
                // _ => "Escolha inválida",  
            };
        }   
    }
}