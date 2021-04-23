using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AddressManager>().As<IAddressService>().SingleInstance();
            builder.RegisterType<EfAddressDal>().As<IAddressDal>().SingleInstance();

            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<EfContactDal>().As<IContactDal>().SingleInstance();

            builder.RegisterType<EducationManager>().As<IEducationService>();
            builder.RegisterType<EfEducationDal>().As<IEducationDal>();

            builder.RegisterType<HeadingManager>().As<IHeadingService>();
            builder.RegisterType<EfHeadingDal>().As<IHeadingDal>();

            builder.RegisterType<HomeManager>().As<IHomeService>();
            builder.RegisterType<EfHomeDal>().As<IHomeDal>();

            builder.RegisterType<JobManager>().As<IJobService>();
            builder.RegisterType<EfJobDal>().As<IJobDal>();

            builder.RegisterType<IdentityManager>().As<IIdentityService>();
            builder.RegisterType<EfIdentityDal>().As<IIdentityDal>();

            builder.RegisterType<ReferenceManager>().As<IReferenceService>();
            builder.RegisterType<EfReferenceDal>().As<IReferenceDal>();

            builder.RegisterType<RelationManager>().As<IRelationService>();
            builder.RegisterType<EfRelationDal>().As<IRelationDal>();

            builder.RegisterType<TcCardManager>().As<ITcCardService>();
            builder.RegisterType<EfTcCardDal>().As<ITcCardDal>();




            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

