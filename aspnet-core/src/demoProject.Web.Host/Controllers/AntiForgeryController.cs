using Microsoft.AspNetCore.Antiforgery;
using demoProject.Controllers;

namespace demoProject.Web.Host.Controllers
{
    public class AntiForgeryController : demoProjectControllerBase
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
