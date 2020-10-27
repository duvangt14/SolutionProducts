using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.webapp.Models
{
  public class Product
  {

    public int IdProducto { get; set; }

    [Required(ErrorMessage = "This Field is Required")]
    public int CodProducto { get; set; }
   
    [Required(ErrorMessage = "This Field is Required")]
    public string Marca { get; set; }

    [Required(ErrorMessage = "This Field is Required")]
    public string Modelo { get; set; }

    [Required(ErrorMessage = "This Field is Required")]
    public Decimal PrecioUnitario { get; set; }

    [Required(ErrorMessage = "This Field is Required")]
    public Decimal PorcentajeDescuento { get; set; }

    [Required(ErrorMessage = "This Field is Required")]
    public bool Estado { get; set; }

  }
}
