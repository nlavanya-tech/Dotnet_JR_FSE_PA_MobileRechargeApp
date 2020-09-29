using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MobileRechargeApp.Controllers
{
    public class PrepaidController : Controller
    {
        // GET: Prepaid/Create
        public ActionResult GetAllPrepaidRechargeDetails()
        {
            return View();
        }

        // POST: Prepaid/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RechargePrepaidPlane(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }

        // GET: Prepaid/Delete/5
        public ActionResult RemovepreviousRechargePlane(int id)
        {
            return View();
        }

        // POST: Prepaid/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RechargePreviousPlane(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }
    }
}