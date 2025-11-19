namespace SistemaEcommere.Ui;

public class MenuUsuario
{
    MenuAdicaoProduto menuAdicaoProduto = new MenuAdicaoProduto();
    public void Menu()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine(@$"
            1 - Adicionar Produto
            2 - Listar Produtos
            3 - Atualizar Produto
            4 - Remover Produto
            5 - Sair");
            
            string escolha = Console.ReadLine();
            switch(escolha)
            {
                case "1": menuAdicaoProduto.Menu(); break;
                // "2" =>  ,
                // "3" =>  ,
                // "4" =>  ,
                // "5" => loop = false,
                // _ => "Escolha inválida",  
            };
        }   
    }
}