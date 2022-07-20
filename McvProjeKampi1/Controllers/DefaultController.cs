using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McvProjeKampi1.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Headings()
        {
            var headinglist=hm.GetList();
            return View(headinglist);
        }
        public PartialViewResult Index(int id=0)
        {
            var contentlist=cm.GetListHeadingByID(id);
            return PartialView(contentlist);
        }
    }
}