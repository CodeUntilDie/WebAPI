using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ProductsController : ApiController
    {
        NewStore db = new NewStore();
        // GET: api/Products
        
        public IHttpActionResult Get()
        {         
            return Ok(db.SanPhams.Where(x=>x.TrangThai == true));
        }

        // GET: api/Products/5
        public IHttpActionResult Get(int id)
        {
            SanPham sp = db.SanPhams.Find(id);
            return Ok(sp);
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
