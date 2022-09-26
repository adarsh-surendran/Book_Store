using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class CategoryController : ApiController
    {
        private ICategory category;
        public CategoryController()
        {
            category = new BookService();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = category.GetAllCategory();
            return Ok(data);
        }
        [HttpPost]
        public IHttpActionResult Post(Category cat)
        {
            var data = category.AddCategory(cat);
            return Ok(data);

        }
    }   
}
