//Minimal APIs em C#
//Testar API 
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia

using API.Classes;
using Microsoft.AspNetCore.Mvc;

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
//Resposta - Dados (json/xml) e 

//GET: /
app.MapGet("/", () => "API de Produtos");

//GET: /api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
     if(produtos.Count > 0)
     {
          return Results.Ok(produtos);
     }
     return Results.NotFound();
});

//POST: /api/produto/cadastrar/
app.MapPost("/api/produto/cadastrar", ([FromBody] Produto produto) =>
{
     produtos.Add(produto);
     return Results.Created("", produto);
});

//POST: /api/produto/remover
app.MapDelete("/api/produto/remover", ([FromBody] Produto produto) =>
{
    var produtoParaRemover = produtos.FirstOrDefault(p => p.Nome == produto.Nome);
    if (produtoParaRemover != null)
    {
        produtos.Remove(produtoParaRemover);
        return Results.NoContent();
    }
    return Results.NotFound();
});

// PUT: /api/produto/alterar/{nome}
app.MapPut("/api/produto/alterar/{nome}", ([FromRoute] string nome, [FromBody] Produto produtoAtualizado) =>
{
    var produto = produtos.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    if (produto == null)
    {
        return Results.NotFound();
    }

    produto.Valor = produtoAtualizado.Valor;
    produto.Quantidade = produtoAtualizado.Quantidade;
    produto.CriadoEm = produtoAtualizado.CriadoEm;

    return Results.Ok(produto);
});

//POST: /api/produto/buscar/{nome}
app.MapGet("/api/produto/buscar/{nome}", (string nome) =>
{
    var produto = produtos.FirstOrDefault(p => p.Nome == nome);
    if (produto != null)
    {
        return Results.Ok(produto);
    }
    return Results.NotFound();
});

app.Run();

//Exercícios para aula de hoje 
// - Buscar um produto pelo nome
// - Remover um produto
// - Alterar um produto


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


