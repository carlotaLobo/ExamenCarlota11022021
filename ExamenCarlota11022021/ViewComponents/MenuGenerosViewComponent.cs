using ExamenCarlota11022021.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenCarlota11022021.ViewComponents
{
    public class MenuGenerosViewComponent:ViewComponent
    {
        IRepository repository;
        public MenuGenerosViewComponent(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(this.repository.FindAllGeneros());
        }
    }
}
