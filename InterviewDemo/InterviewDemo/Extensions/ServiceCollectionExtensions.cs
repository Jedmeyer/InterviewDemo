using InterviewDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDemo.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterContainers(this IServiceCollection services)
        {
            services.AddTransient<OrderService>();

            return services;
        }

    }
}
