using Autofac;
using AutoMapper;
<<<<<<< HEAD
using ELDOKKAN.Context;
=======
 
>>>>>>> 989473fcd69059107df8ab80ef97ca6f8c55a7b1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContainer = Autofac.IContainer;
<<<<<<< HEAD
using ELDOKKAN.Repositories;
=======
>>>>>>> 989473fcd69059107df8ab80ef97ca6f8c55a7b1
using ELDOKKAN.Application.Services;
using ELDOKKAN.Application.Mapper;

namespace Eldokkan.pl
{
    public class AutoFac
    {
        public static Autofac.IContainer Inject()
        {
            var builder = new ContainerBuilder();

<<<<<<< HEAD
=======
            Builder.RegisterType<ProductService>().As<IProductService>();
>>>>>>> 989473fcd69059107df8ab80ef97ca6f8c55a7b1

            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<AppDbContext>().As<AppDbContext>();

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                // Register AutoMapper profile
                cfg.AddProfile<AutoMapperProfile>();
            }));//.AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();

      
            return builder.Build();
        }
    }

 
}
