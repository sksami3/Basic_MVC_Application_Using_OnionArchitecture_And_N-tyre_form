
using ClassLibrary1.Project123.Infructructure.Interfaces;
using ClassLibrary1.Project123.Infructructure.Repository.Base;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project123.Dependency
{
    public class DependenyResolver
    {
        public static IKernel Kernel { get; set; }
        public void Resolve()
        {
            Kernel = new StandardKernel();
            var serviceRegister = new DependencyServiceRegister();
            serviceRegister.Register(Kernel);
        }
    }

    public class DependencyServiceRegister
    {
        public void Register(IKernel kernel)
        {
            kernel.Bind<IUserAccountRepository>().To<UserRepository>();
        }
    }
}
