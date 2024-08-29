using Autofac;
using AutoMapper;
using Eldokkan.Application.Service;
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
        public static IContainer Inject()
        {
            var Builder = new ContainerBuilder();

            Builder.RegisterType<ProductService>().As<IProductServices>();

            Builder.Register(c => new MapperConfiguration(cfg =>
            {
                // Register AutoMapper profile
                cfg.AddProfile<AutoMapperProfile>();
            }));//.AsSelf().SingleInstance();

            Builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<Mapper>().InstancePerLifetimeScope();

            return Builder.Build();

        }
    }

 
}
