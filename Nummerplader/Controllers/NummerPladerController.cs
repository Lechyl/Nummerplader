using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nummerplader.Models;
using Nummerplader.Services;

namespace Nummerplader.Controllers
{
    public class NummerPladerController : Controller
    {
       // GET: NummerPladerController
      /*  public ActionResult Index()
        {
            return View();
        }*/

        // GET: NummerPladerController?regNr=
        public async Task<ActionResult> Index(string regNr)
        {
            if (!String.IsNullOrEmpty(regNr))
            {
                API api = new API();
                NummerPladerModel bilData = await api.GetNummerPladerByRegistreingsNummer(regNr);
                if(bilData == null)
                {
                    ViewData["Alert"] = "true";
                }
                

                return View(bilData);

            }
            else
            {
                return View();
            }
        }

    }
}
