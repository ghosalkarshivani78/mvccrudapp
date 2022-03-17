using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;
using MvcApplication4.Service;

namespace MvcApplication4.Controllers
{
    public class HomeController : Controller
    {
         
        public ActionResult Index()
        {
            Taskservice service = new Taskservice();
            List<Models.Event> person = service.getpersonList();
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View(person);
        }

   
   
        public ActionResult About()
        {
            return View();
        }
        public ActionResult adduser(Event events) 
        {
            Taskservice service = new Taskservice();
            int status = service.insertperson(events);
            return Redirect("/Home/index");
        }
        public ActionResult updateuser(Event events) 
        {
            Taskservice service = new Taskservice();
            int status = service.update(events);
            return Redirect("/Home/index");
        }
        public ActionResult edit(string id)
        {
            Taskservice service = new Taskservice();
            Event person = service.getpersonListByid(id);
            return View(person);
            
        }
        public ActionResult Delete(string id) 
        {
            Taskservice service = new Taskservice();
            int status = service.deleteperson(id);
            return Redirect("/Home/index");
        }
      
       
    }
}
