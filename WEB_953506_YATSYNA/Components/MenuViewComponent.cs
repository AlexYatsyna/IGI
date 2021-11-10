using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_YATSYNA.Models;

namespace WEB_953506_YATSYNA.Views.Shared.Components
{
    public class MenuViewComponent : ViewComponent
    {

        private List<MenuItem> _menuItems = new List<MenuItem>
        {
        new MenuItem{ Controller="Home", Action="Index", Text="Lab 7"},
        new MenuItem{ Controller="Product", Action="Index", Text="Каталог"},
        new MenuItem{IsPage = true, Area = "Admin", Page = "/Index", Text = "Администрирование"}
        };

        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];

            foreach (var item in _menuItems)
            {
                var _matchController = false;
                var _matchArea = false;

                if (controller != null && (string)controller == item.Controller)
                    _matchController = true;

                if (area != null && (string)area == item.Area)
                    _matchArea = true;

                if (_matchController || _matchArea)
                    item.Active = "active";

            }

            return View(_menuItems);
        }
    }
}   