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
        public ActionResult Index()
        {
            return View();
        }

        // GET: NummerPladerController
        public async Task<ActionResult> Index(string regNr)
        {
            
            if (!String.IsNullOrEmpty(regNr))
            {
                API api = new API();
                NummerPladerModel bilData = await api.GetNummerPladerByRegistreingsNummer(regNr);
                return View(bilData);

            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // GET: NummerPladerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NummerPladerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NummerPladerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NummerPladerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NummerPladerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NummerPladerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NummerPladerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
