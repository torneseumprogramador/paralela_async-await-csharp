using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncAwaitDotnet5.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public static async Task<List<Cliente>> AllAsync()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Id = 1, Nome = "Danilo" });
            await Task.Delay(10000);
            return clientes;
        }

        public static List<Cliente> All()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Id = 1, Nome = "Danilo" });
            for(var i=0;i< 1000000; i++)
            {
                Console.WriteLine(i);
            }
            return clientes;
        }
    }
}
