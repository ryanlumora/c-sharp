/*

📦 Controle de Estoque
📌 Descrição: Um sistema para cadastrar produtos e controlar quantidades em estoque.
🛠 Tecnologias sugeridas: ASP.NET Core MVC, Entity Framework, SQL Server.
🎯 Funcionalidades:

Adicionar novos produtos (nome, descrição, preço, quantidade).
Editar informações dos produtos.
Listar todos os produtos do estoque.
Excluir produtos.

*/

List<string> products = new List<string>();

void main()
{
    OpenMenu();
}

void ShowWelcomeMessage()
{
    Console.WriteLine(@"
    Ｃｏｎｔｒｏｌｅ Ｄｅ Ｅｓｔｏｑｕｅ
    ");
}

void ShowMenu()
{
    Console.WriteLine(@"
    Digite 1 para cadastrar um produto
    Digite 2 para consultar todos os produtos
    Digite 3 para consultar detalhes de um produto
    Digite 4 para atualizar um produto
    Digite 5 para excluir um produto
    Digite 6 para sair do programa
    ");
}

void OpenMenu()
{
    int option = 0;

    while (option != 6)
    {
        ShowWelcomeMessage();
        ShowMenu();
        Console.Write("Digite a opção desejada: ");
        try
        {
            option = int.Parse(Console.ReadLine()!);
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine("\nOpção inválida! Por favor, selecione uma opção válida!");
            option = 0;
        }

        switch (option)
        {
            case 1:
                {
                    Console.Clear();
                    Console.WriteLine("\nCadastro de Produto");
                    CreateProduct();
                    WaitInput();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("\nLista de Produtos:\n");
                    ReadAllProducts();
                    WaitInput();
                    break;
                }
            case 3:
                {
                    Console.Clear();
                    Console.WriteLine("\nConsultar um Produto");
                    WaitInput();
                    break;
                }
            case 4:
                {
                    Console.Clear();
                    Console.WriteLine("\nAtualizar um Produto");
                    WaitInput();
                    break;
                }
            case 5:
                {
                    Console.Clear();
                    Console.WriteLine("\nExcluir um Produto");
                    WaitInput();
                    break;
                }
            case 6:
                {
                    Console.WriteLine("\nObrigado por usar nosso sistema!!");
                    break;
                }

        }
    }
    Console.Write("\nDigite qualquer tecla para sair...\n");
    Console.ReadKey();
}

void CreateProduct()
{
    Console.Write("Digite o Nome do Produto: ");
    string name = Console.ReadLine()!;

    Console.Write("Digite o Valor do Produto: ");
    string value = Console.ReadLine()!;

    Console.Write("Digite a Descrição do Produto: ");
    string description = Console.ReadLine()!;

    products.Add(name);
}

void ReadAllProducts(){
    foreach(string product in products){
        Console.WriteLine(product);
    }
}

void WaitInput(){
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
}

main();
