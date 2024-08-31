using Autofac;
using AutoMapper;
using Eldokkan.Application.Contract;
using Eldokkan.Application.Mapper;
using Eldokkan.Application.Service;

using Eldokkan.Infrastructure;
using ELDOKKAN.Context;
using Eldokkan.Application.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContainer = Autofac.IContainer;

namespace Eldokkan.pl
{
    public class AutoFac
    {
        public static Autofac.IContainer Inject()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<ProductService>().As<IProductServices>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<AppDbContext>().As<AppDbContext>();

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                // Register AutoMapper profile
                cfg.AddProfile<AutoMapperPro>();
            }));//.AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();

      
            return builder.Build();
        }
    }

 
}
