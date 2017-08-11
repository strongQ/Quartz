using Common.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz调度.Job
{
    public class TestJob : IJob
    {
        private readonly log4net.ILog _logger = log4net.LogManager.GetLogger("LogCustomEx");
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("ok");
            _logger.InfoFormat("TestJob测试");
            _logger.Error("错大师傅大师傅但是");

        }
    }
}
