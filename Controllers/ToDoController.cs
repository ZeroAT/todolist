using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreToDo.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            //Get to do items from db

            //put items into a model

            //render view using the model

            return View();
        }
    }
}