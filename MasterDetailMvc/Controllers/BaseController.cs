using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailMvc.Controllers
{
    public class BaseController:Controller
    {
        public ActionResult Ok()
            => new HttpStatusCodeResult(HttpStatusCode.OK);
        public ActionResult Ok(object any)
            =>  Content(JsonConvert.SerializeObject(any), "application/json");
    }
}