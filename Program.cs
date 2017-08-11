using Quartz调度.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Quartz调度
{
    class Program
    {
        static void Main(string[] args)
        {
            //配置Log4日志
            //log4net.Config.XmlConfigurator.Configure();

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            HostFactory.Run(x =>
            {
                x.UseLog4Net();
                x.Service<ServiceRunner>();
                x.SetDescription("Quartz调度服务描述");
                x.SetDisplayName("Quartz服务显示名称");
                x.SetServiceName("Quartz服务名称");
                x.RunAsLocalSystem();
                x.EnablePauseAndContinue();
            });
        }
    }
}
