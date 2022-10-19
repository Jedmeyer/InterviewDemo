using AutoBogus;
using InterviewDemo.Models;
using InterviewDemo.Pages;
using InterviewDemo.Services;
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
        private readonly OrderService _orderService;
        public OrderController(OrderService _service)
        {
            _orderService = _service;
        }

        [HttpGet]
        [Route("Order/Index")]
        public IActionResult Index([FromQuery] int orderId)
        {
            return Ok(_orderService.GetOrderById(orderId));
        }
    }
}
