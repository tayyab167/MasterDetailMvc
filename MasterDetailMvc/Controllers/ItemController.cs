using MasterDetail.Domain;
using MasterDetail.Infrastructure.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailMvc.Controllers
{
    public class ItemController : BaseController
    {
        private readonly IRepository<tblItem> ItemRepository;
        private readonly IRepository<tblOrder> orderRepository;

        public ItemController(IRepository<tblItem> ItemRepository,IRepository<tblOrder> orderRepository)
        {
            this.ItemRepository = ItemRepository;
            this.orderRepository = orderRepository;
        }

        // GET: Item
        public ActionResult Item()
        {
            return View();
        }
        [HttpGet]
        public ActionResult getItem()
        {
            var result = ItemRepository.All();
            return Ok(result);
        }
        [HttpPost]
        public ActionResult Create(tblItem data)
        {
            //try
            //{
                data.dtCreationDate = DateTime.Now;
                ItemRepository.Add(data);
                ItemRepository.SaveChanges();
                return Ok();
            //}
            //catch (Exception ex)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.NotFound); 

            //}


        }
        [HttpPost]
        public ActionResult CreateMasterDetail(tblOrder data)
        {
            //try
            //{
                
                orderRepository.Add(data);
            orderRepository.SaveChanges();
                return Ok();
            //}
            //catch (Exception ex)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.NotFound); 

            //}


        }


        


    }
}