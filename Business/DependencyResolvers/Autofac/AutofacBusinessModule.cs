using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserHomeManager>().As<IUserHomeService>().SingleInstance();
            builder.RegisterType<EfUserHomeDal>().As<IUserHomeDal>().SingleInstance();

            builder.RegisterType<HomeManager>().As<IHomeService>().SingleInstance();
            builder.RegisterType<EfHomeDal>().As<IHomeDal>().SingleInstance();
            //builder.RegisterType<FileLogger>().As<ILogger>().SingleInstance();
            builder.RegisterType<MainDeviceManager>().As<IMainDeviceService>().SingleInstance();
            builder.RegisterType<EfMainDeviceDal>().As<IMainDeviceDal>().SingleInstance();

            builder.RegisterType<NormalUserManager>().As<INormalUserService>().SingleInstance();
            builder.RegisterType<EfNormalUserDal>().As<INormalUserDal>().SingleInstance();
            //2
            builder.RegisterType<SensorDeviceManager>().As<ISensorDeviceService>().SingleInstance();
            builder.RegisterType<EfSensorDeviceDal>().As<ISensorDeviceDal>().SingleInstance();

            builder.RegisterType<UserSensorDeviceManager>().As<IUserSensorDeviceService>().SingleInstance();
            builder.RegisterType<EfUserSensorDeviceDal>().As<IUserSensorDeviceDal>().SingleInstance();
            //3
            
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
