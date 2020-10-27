using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace eshop.webapp.Helper
{
  public class GlobalVariable
  {

    public static HttpClient WebApiClient = new HttpClient();
   
    static GlobalVariable()
    {
      WebApiClient.BaseAddress = new Uri("http://localhost:7524/api/");
      WebApiClient.DefaultRequestHeaders.Clear();
      WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
  }
}
