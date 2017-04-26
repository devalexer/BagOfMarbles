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

        //[HttpGet]
        //public IHttpActionResult Random()
        //{

        //    var random = new Random();
        //    var marbles = new MarbleContext();
        //    int randomizedMarble = random.Next(marbles.Count);
        //    return Ok(marbles(randomizedMarble));


        //    int index = Marble.Color.Next(names.Count);
        //    var randomizedMarble = names[index];
        //    return randomizedMarble;

        //    var randomIndex = Math.floor(Math.random() * marble.Color.length);
        //    var randomMarble = textArray[randomIndex];

        //    var randomNum = new Random().Next(0, Marble.Length - 1);
        //    var randomizedMarble = Marble[randomNum];

        //    return Ok(randomizedMarble);

        //}
    }
}
