using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
  public class Cliente
  {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public List<Cliente> GetClientes()
    {
      List<Cliente> lista = new List<Cliente>();
      lista.Add(new Cliente()
      {
        Id = 1,
        Nombre = "Jhonatan",
        Direccion = "Calle 2 Norte 100",
        Telefono = "23455033"
      });
      lista.Add(new Cliente() {
        Id=2,
        Nombre="Maria",
        Direccion="Av las flores 2222",
        Telefono="32445334345"
      });

      return lista;

    }
  }
}