using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Http.Controllers;
using PinCodeREST.Controllers;
using PincodeREST.Common.Contracts;
using PincodeREST.Common.Implementations;
using PincodeREST.DAL.Contracts;
using PincodeREST.DAL.Implementations;
using PincodeREST.Repository;
using PincodeREST.Service.Contracts;
using PincodeREST.Service.Implementations;
using Castle.MicroKernel.Registration;


namespace PinCodeREST.CastleDI
{
    public class DependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                        Component.For<ILogService>()
                            .ImplementedBy<LogService>()
                            .LifeStyle.PerWebRequest,

                        Component.For<IDatabaseFactory>()
                            .ImplementedBy<DatabaseFactory>()
                            .LifeStyle.PerWebRequest,

                        Component.For<IUnitOfWork>()
                            .ImplementedBy<UnitOfWork>()
                            .LifeStyle.PerWebRequest,

                        AllTypes.FromThisAssembly().BasedOn<IHttpController>().LifestyleTransient(),

                        AllTypes.FromAssemblyNamed("PincodeREST.Service")
                            .Where(type => type.Name.EndsWith("Service")).WithServiceAllInterfaces().LifestylePerWebRequest(),

                        AllTypes.FromAssemblyNamed("PincodeREST.Repository")
                            .Where(type => type.Name.EndsWith("Repository")).WithServiceAllInterfaces().LifestylePerWebRequest()
                        );
        }
    }
}