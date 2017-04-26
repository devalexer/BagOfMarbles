using BagOfMarbles.DataContext;
using BagOfMarbles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BagOfMarbles.Controllers
{
    public class MarbleController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new MarbleContext().Marbles.ToList());
        }

        [HttpPost]
        public IHttpActionResult AddMarble(Marble marble)
        {

            var db = new MarbleContext();
            db.Marbles.Add(marble);
            db.SaveChanges();
            return Ok(marble);
        }
    }
}
