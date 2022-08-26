using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConventinalRouting.Models;

namespace ConventinalRouting.Controllers
{
    public class DemoController : Controller
    {
        List<Student> list = new List<Student>()
        {
            new Student(){Id=1, Name="Neha", Address="Nagur"},
            new Student(){Id=2, Name="Himansh", Address="Nagur"},
            new Student(){Id=1, Name="Pranu", Address="Nagur"}
        };
        // GET: Demo
        public ActionResult GetData()
        {
            var stud = list.ToList();
            return View(stud);
        }
        public ActionResult GetDataStud(int id)
        {

            if (id == null)
            {
                var data = "No data found";

                return View(data);
            }
            else
            {
                var data = list.FirstOrDefault(x=>x.Id == id);

                return View(data);
            }
            

        }
       
    }
}