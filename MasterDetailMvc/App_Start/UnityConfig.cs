using MasterDetail.Domain;
using MasterDetail.Infrastructure.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MasterDetailMvc
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IRepository<tblItem>, ItemRepository>();
            container.RegisterType<IRepository<tblCustomer>, CustomerRepository>();
            container.RegisterType<IRepository<tblOrder>, OrderRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}