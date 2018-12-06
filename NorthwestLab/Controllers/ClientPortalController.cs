using NorthwestLab.DAL;
using NorthwestLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLab.Controllers
{
    public class ClientPortalController : Controller
    {
        NorthwestLabContext db = new NorthwestLabContext();
        // GET: ClientPortal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult display()
        {
            NorthwestLabContext dbcontext = new NorthwestLabContext();
            List<sample> GetSample = new List<sample>();
            var GetMultiJoins = (from a in dbcontext.clients
                                 join ta in dbcontext.orders
                                 on a.ClientID equals ta.ClientID
                                 join c in dbcontext.compounds
                                 on ta.LTNumber equals c.LTNumber
                                 join s in dbcontext.samples
                                 on ta.LTNumber equals s.LTNumber
                                 join ts in dbcontext.testSamples
                                 on s.LTNumber equals ts.LTNumber
                                 where a.ClientID == 1
                                 select new
                                 {
                                     a.ClientID,
                                     ta.OrderID,
                                     ta.LTNumber,
                                     ts.TestID,
                                     ts.Result
                                 }).ToList();

            foreach (var item in GetMultiJoins)
            {
                GetSample.Add(new sample { ClientID = item.ClientID, OrderID = item.OrderID, LTNumber = item.LTNumber, TestID = item.TestID, Result = item.Result });
            }

            return View(GetSample);
        }

        public ActionResult Notifications()
        {
            return View();
        }
    }
}