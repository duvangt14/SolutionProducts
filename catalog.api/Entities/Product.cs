using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace catalog.api.Entities
{
  public class Product
  {
    [Key]
    public int IdProducto { get; set; }

    public int CodProducto { get; set; }

    public string Marca { get; set; }

    public string Modelo { get; set; }

    public Decimal PrecioUnitario { get; set; }

    public Decimal PorcentajeDescuento { get; set; }

    public bool Estado { get; set; }


  }
}
