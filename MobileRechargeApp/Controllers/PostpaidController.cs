using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MobileRechargeApp.Controllers
{
    public class PostpaidController : Controller
    {
        // GET: Postpaid/Create
        public ActionResult GetAllPostpaidRechargeDetails()
        {
            return View();
        }

        // POST: Postpaid/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RechargePostpaidPlane(IFormCollection collection)
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

        // GET: Postpaid/Delete/5
        public ActionResult RemovepreviousRechargePlane(int id)
        {
            return View();
        }

        // POST: Postpaid/Delete/5
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