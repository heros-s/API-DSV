// Minimal APIs em C#

// 1. Testar a API
// - Rest Client - Extensão VSCode
// - Postman - Mais robusto
// - Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoint - Funcionalidade
// Requisição - URL e método/verbo(?) HTTP 
app.MapGet("/frase", () => "Você não saberá o tamanho da sua força até que ser forte seja a única opção!");

app.MapGet("/explorando", () => "Opção 2");

app.Run();

// Exercícios para a próxima aula.
// - Criar um endpoint para receber informação pela URL.
// - Criar um endpoint para receber informação pelo corpo.