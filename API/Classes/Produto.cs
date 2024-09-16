namespace API.Classes;

public class Produto
{
     //C# - Construtor
     public Produto()
     {
          Id = Guid.NewGuid().ToString();
          CriadoEm = DateTime.Now;
     }
        

     public string? Id { get; set; }
     public string? Nome { get; set; }
     public double Valor { get; set; }
     public int Quantidade { get; set; }
     public DateTime CriadoEm { get; set; }
     


     //JAVA - Atributos/Propriedades - Características.

     // private double valor;
     //GETTERS e SETTERS
     //public void SetValor(double valor)
     //{
     //     this.valor = valor * 3;
     //}

     //public double getValor()
     //{
     //      return this.valor;
     //}


}
