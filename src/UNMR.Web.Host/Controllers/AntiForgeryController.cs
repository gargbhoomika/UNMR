using System.Threading.Tasks;
using Abp.Web.Security.AntiForgery;
using Microsoft.AspNetCore.Antiforgery;
using UNMR.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UNMR.Web.Host.Controllers
{
    public class AntiForgeryController : UNMRControllerBase
    {
        private readonly IAntiforgery _antiforgery;
        private readonly IAbpAntiForgeryManager _antiForgeryManager;

        public AntiForgeryController(IAntiforgery antiforgery, IAbpAntiForgeryManager antiForgeryManager)
        {
            _antiforgery = antiforgery;
            _antiForgeryManager = antiForgeryManager;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }

        public void SetCookie()
        {
            _antiForgeryManager.SetCookie(HttpContext);
        }
    }
}
