using events.tac.local.Models;
using Glass.Mapper.Sc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
    public class GlassMapperController : Controller
    {
        // GET: GlassMapper
        public ActionResult Index()
        {
            var context = new SitecoreContext();
            var model = context.GetItem<IGlassMapper>("{ 3DF0C766 - ACE7 - 4EA0 - 8AD8 - 9EB6941D1885}");

            return View(model);
        }
    }
}