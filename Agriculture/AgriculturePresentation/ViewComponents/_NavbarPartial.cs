using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        private readonly IAnnouncementService _announcementService;

        public _NavbarPartial(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _announcementService.GetListAll();
            return View(values);
        }
    }
}
