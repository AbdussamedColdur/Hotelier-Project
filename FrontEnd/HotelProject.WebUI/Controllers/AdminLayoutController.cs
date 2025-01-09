using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult TopBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult SideBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult LogoutPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptsPartial()
        {
            return PartialView();
        }
    }
}
