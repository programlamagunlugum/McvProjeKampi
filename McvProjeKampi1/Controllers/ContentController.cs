using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McvProjeKampi1.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllContent(string p)
        {
            var values =cm.GetList(p);
            //var values = c.Contents.ToList();
            return View(values);
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues=cm.GetListHeadingByID(id);
            return View(contentvalues);
        }
        
    }
}