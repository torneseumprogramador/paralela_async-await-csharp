using System;

namespace AsyncAwaitDotnet5.Models
{
    public record Humano(string Nome, string Telefone);
    // public record Usuario(string Nome, string Telefone, string Endereco) : Humano(Nome, Telefone);
    public record Usuario
    {
      public string Nome {get;init;}
      public string Telefone {get;init;}
      public string Endereco {get;init;}
    }
    public record Carro 
    {
      public string Nome {get;set;}
      public string Marca {get;init;}
    }
}