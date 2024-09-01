using Autofac;
using AutoMapper;
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContainer = Autofac.IContainer;
using ELDOKKAN.Application.Services;
using ELDOKKAN.Application.Mapper;
using ELDOKKAN.Context;
using ELDOKKAN.Repositories;

namespace Eldokkan.pl
{
    public class AutoFac
    {
        public static IContainer Inject()
        {
            var Builder = new ContainerBuilder();

            Builder.RegisterType<ProductService>().As<IProductService>();
            Builder.RegisterType<ProductRepository>().As<IProductRepository>();
            Builder.RegisterType<AdminService>().As<IAdminService>();
            Builder.RegisterType<AdminRepository>().As<IAdminRepository>();
             Builder.RegisterType<CustomerService>().As<ICustomerService>();
             Builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            Builder.RegisterType<CategoryService>().As<ICategoryService>();
            Builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            Builder.RegisterType<OrderDetailsService>().As<IOrderDetailsService>();
            Builder.RegisterType<OrderDetailsRepository>().As<IOrderDetailsRepository>();
            Builder.RegisterType<OrderService>().As<IOrderService>();
            Builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            Builder.RegisterType<AppDbContext>().As<AppDbContext>();

            Builder.Register(c => new MapperConfiguration(cfg =>
            {
                // Register AutoMapper profile
                cfg.AddProfile<AutoMapperProfile>();
            }));//.AsSelf().SingleInstance();

            Builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>();//.InstancePerLifetimeScope();

            return Builder.Build();

        }
    }

 
}
