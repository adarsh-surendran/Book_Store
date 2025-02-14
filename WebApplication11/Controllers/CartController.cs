﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class CartController : ApiController
    {
        ICart CartRep;
        public CartController()
        {
            CartRep = new CartService();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = CartRep.ViewCart();
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Post(Cart cart)
        {
            var data = CartRep.AddtoCart(cart);
            return Ok(data);

        }
        [HttpDelete]
        public IHttpActionResult Delete(string uname,int bid)
        {
            CartRep.DeletefromCart(uname,bid);
            return Ok();
        }
       
    }
}