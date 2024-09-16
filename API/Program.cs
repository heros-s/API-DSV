//Minimal APIs em C#
//Testar API 
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia

using API.Classes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Produto 1", Valor = 10.0, Quantidade = 100, CriadoEm = DateTime.Now.AddDays(-1) },
            new Produto { Nome = "Produto 2", Valor = 20.0, Quantidade = 200, CriadoEm = DateTime.Now.AddDays(-2) },
            new Produto { Nome = "Produto 3", Valor = 30.0, Quantidade = 300, CriadoEm = DateTime.Now.AddDays(-3) },
            new Produto { Nome = "Produto 4", Valor = 40.0, Quantidade = 400, CriadoEm = DateTime.Now.AddDays(-4) },
            new Produto { Nome = "Produto 5", Valor = 50.0, Quantidade = 500, CriadoEm = DateTime.Now.AddDays(-5) },
            new Produto { Nome = "Produto 6", Valor = 60.0, Quantidade = 600, CriadoEm = DateTime.Now.AddDays(-6) },
            new Produto { Nome = "Produto 7", Valor = 70.0, Quantidade = 700, CriadoEm = DateTime.Now.AddDays(-7) },
            new Produto { Nome = "Produto 8", Valor = 80.0, Quantidade = 800, CriadoEm = DateTime.Now.AddDays(-8) },
            new Produto { Nome = "Produto 9", Valor = 90.0, Quantidade = 900, CriadoEm = DateTime.Now.AddDays(-9) },
            new Produto { Nome = "Produto 10", Valor = 100.0, Quantidade = 1000, CriadoEm = DateTime.Now.AddDays(-10) }
        };

//Endpoints - Funcionalidades
//Requisição - URL e método/verbo HHTP

//GET: /
app.MapGet("/", () => "API de Produtos");

//GET: /api/produto/listar
app.MapGet("/api/produto/listar", () => 
{
     return produtos;
});

//POST: /api/produto/cadastrar/nome_param
app.MapPost("/api/produto/cadastrar/{nome}", (string nome) =>
{
     Produto produto = new Produto();
     produto.Nome = nome;
     produtos.Add(produto);
     return produtos;
});

app.Run();

//Exercicios para a próxima aula
// - Criar um endpoint para receber informação pela URL.
// - Criar um endpoint para receber informação pelo Corpo.

//Java
//Produto produto = new Produto();
//produto.SetValor(10);
//Console.WriteLine("Preço: " + produto.getValor());

//C#
// Produto produto = new Produto();
// produto.Nome = "Notebook";
// Console.WriteLine("Preço: ", produto.Valor);

//Operações  -  Banco  -   HTTP

//Creat    -   Insert  -  Post
//Retrieve -   Select  -  Get
//Update   -   Update  -  Put/Patch
//Delete   -   Delete  -  Delete

