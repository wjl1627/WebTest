using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DapperDao
{
    public class AutoFacHelper
    {
        public void Test() {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).
                Where(t => t.Name.EndsWith("ServiceImpl")).
                AsImplementedInterfaces();

            IContainer container = builder.Build();
            var repository = container.Resolve<IDependency>();

           

        }
    }
}
