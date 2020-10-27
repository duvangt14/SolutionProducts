using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eshop.webapp.Models;
using System.Net.Http;
using eshop.webapp.Helper;

namespace eshop.webapp.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
      IEnumerable<Product> productlist;
      HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("Product").Result;
      productlist = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
      return View(productlist);
    }

    public ActionResult AddOrEdit(int id = 0)
    {
      if (id == 0)
        return View(new Product());
      else
      {
        HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("Product/" + id.ToString()).Result;
        return View(response.Content.ReadAsAsync<Product>().Result);
      }
    }
    [HttpPost]
    public ActionResult AddOrEdit(Product pro)
    {
      if (pro.IdProducto == 0)
      {
        HttpResponseMessage response = GlobalVariable.WebApiClient.PostAsJsonAsync("Product", pro).Result;
        TempData["SuccessMessage"] = "Saved Successfully";
      }
      else
      {
        HttpResponseMessage response = GlobalVariable.WebApiClient.PutAsJsonAsync("Product/" + pro.IdProducto, pro).Result;
        TempData["SuccessMessage"] = "Updated Successfully";
      }
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      HttpResponseMessage response = GlobalVariable.WebApiClient.DeleteAsync("Product/" + id.ToString()).Result;
      TempData["SuccessMessage"] = "Deleted Successfully";
      return RedirectToAction("Index");
    }


  }
}