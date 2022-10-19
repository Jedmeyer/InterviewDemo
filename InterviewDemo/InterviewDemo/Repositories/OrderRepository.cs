using AutoBogus;
using InterviewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDemo.Repositories
{
    public class OrderRepository
    {
        public OrderRepository()
        {

        }
        public OrderModel GetOrderById(int Id)
        {
            var faker = new AutoFaker<OrderModel>()
                .RuleFor(fake => fake.OrderId, fake => Id);

            return faker.Generate();

        }
        public List<OrderModel> GetOrders(int numOrders)
        {
            var orders = AutoFaker.Generate<OrderModel>(numOrders);
            return orders;
        }


    }
}
