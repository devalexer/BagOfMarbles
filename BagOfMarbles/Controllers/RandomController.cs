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
    public class RandomController : ApiController
    {
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

        //    var rand = new Random().Next(0, Marble.Count);
        //    var randomizedMarble = Marble[randomNum];

        //    return Ok(randomizedMarble);

        //}
    }
}
