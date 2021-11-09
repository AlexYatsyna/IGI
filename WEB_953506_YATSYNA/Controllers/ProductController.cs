using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_YATSYNA.Data;
using WEB_953506_YATSYNA.Entities;
using WEB_953506_YATSYNA.Extensions;
using WEB_953506_YATSYNA.Models;

namespace WEB_953506_YATSYNA.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;
        int _pageSize;

        public ProductController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;
        }

       
        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group ,int pageNo=1)
        {
            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            ViewData["Groups"] = _context.DishGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }
    }
}
