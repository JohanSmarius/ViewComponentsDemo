using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Components
{
    public class DemoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new ViewModelCurrentDateTime()
            {
                Message = $"{DateTime.Now:G}"
            });
        }
    }
}
