using AutoBogus;
using InterviewDemo.Models;
using InterviewDemo.Pages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDemo.Controllers
{
    public class OrderController : Controller
    {
        public OrderController()
        {

        }

        [HttpGet]
        [Route("Order/Index")]
        public IActionResult Index([FromQuery] int page)
        {
            var orders = AutoFaker.Generate<OrderModel>(10);

            return Ok(orders);
        }
    }
}
