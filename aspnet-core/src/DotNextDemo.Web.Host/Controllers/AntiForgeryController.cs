using Microsoft.AspNetCore.Antiforgery;
using DotNextDemo.Controllers;

namespace DotNextDemo.Web.Host.Controllers
{
    public class AntiForgeryController : DotNextDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
