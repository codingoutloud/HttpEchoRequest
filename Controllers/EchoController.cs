using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpEchoRequest.Controllers
{
    public class EchoController : Controller
    {
        //
        // GET: /Echo/
        public string Index()
        {
           return Request.Url.AbsoluteUri;
        }

        //
        // GET: /Echo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Echo/Create
        public ActionResult Post()
        {
            return View();
        }

        //
        // POST: /Echo/Create
        [HttpPost]
        public string Post(FormCollection collection)
        {
           var response = String.Empty;
           response += "<ul>";
           for (int i=0; i<collection.Count; i++)
           {
              response += "<li>";
              response += collection.Keys[i];
              response += "=";
              response += String.Format("\"<b>{0}</b>\"", collection[i].Normalize());
              //response += collection[i].Normalize();
              response += "</li>";
           }
           response += "</ul>";
           return response;
        }

        //
        // GET: /Echo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Echo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Echo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Echo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
