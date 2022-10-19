using InterviewDemo.Models;
using InterviewDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDemo.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;
        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public OrderModel GetOrderById(int id)
        {
            return _orderRepository.GetOrderById(id);
        }

    }
}
