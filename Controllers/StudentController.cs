using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppAzure.Models;

namespace WebAppAzure.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {
            List<Student> obj = new List<Student>
            {
                new Student{SId=101,SName="Priya Singhal",SDob=DateTime.Parse("12/09/1998"),SContact="9898989898" },
                new Student{SId=102,SName="Rishabh Batra",SDob=DateTime.Parse("12/09/1997"),SContact="9856489878" },
                new Student{SId=103,SName="Mohit Sehgal",SDob=DateTime.Parse("28/07/1998"),SContact="9897654374" },
                new Student{SId=104,SName="Sneha Malhotra",SDob=DateTime.Parse("02/06/1998"),SContact="989887655" },
                new Student{SId=105,SName="Raj Aaryan",SDob=DateTime.Parse("27/11/1998"),SContact="9768954356" }
            };
            ViewBag.noc = obj.Count;
            return View(obj);
        }
    }
}
