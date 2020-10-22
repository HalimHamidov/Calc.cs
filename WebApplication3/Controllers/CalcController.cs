using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index(CalcM c)
        {
            switch(c.Op)
            {
                case '+': c.Result = c.Number1 + c.Number2;
                    break;
                case '-':
                    c.Result = c.Number1 - c.Number2;
                    break;
                case '*':
                    c.Result = c.Number1 * c.Number2;
                    break;
                case '/':
                    c.Result = c.Number1 / c.Number2;
                    break;
            }
            return View(c);
        }


    }
}
