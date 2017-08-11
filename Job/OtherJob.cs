using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz调度.Job
{
    public class OtherJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("就这样");
        }
    }
}
