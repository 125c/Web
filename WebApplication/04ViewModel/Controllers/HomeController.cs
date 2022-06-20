using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _04ViewModel.Models;
using _04ViewModel.ViewModels;

namespace _04ViewModel.Controllers
{
    public class HomeController : Controller
    {

        dbEmployeeEntities db = new dbEmployeeEntities();

        public ActionResult Index(int depId=1)
        {
            VMEmp vme = new VMEmp()
            {
                department = db.tDepartment.ToList(),
                employee=db.tEmployee.Where(m=>m.fDepId== depId).ToList()
            };


         

            return View(vme);
        }
    }
}