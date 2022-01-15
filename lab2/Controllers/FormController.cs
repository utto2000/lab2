
using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{

    public class FormController : Controller
    {
        public IActionResult Forms()
        {
            return View();
        }

        public IActionResult Display_Values(FormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Display_Values",model);
            }

            return View(model);
        }

    }


}