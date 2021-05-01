using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace UruguayBus.Controllers
{

    public class Prueba : Controller
    {
        public IActionResult datos()
        {
            return View();
        }
        public IActionResult Comprar()
        {
      
            return View();
        }

        [HttpPost]
        public IActionResult process_payment(String token, int installments, String payment_method_id, String issuer_id)
            {
            System.Diagnostics.Debug.WriteLine("datos");
            System.Diagnostics.Debug.WriteLine(token);
            System.Diagnostics.Debug.WriteLine(installments);
            System.Diagnostics.Debug.WriteLine(payment_method_id);
            System.Diagnostics.Debug.WriteLine(issuer_id);
            System.Diagnostics.Debug.WriteLine("fin");
            return RedirectToAction("datos");
            }
      }  
}
