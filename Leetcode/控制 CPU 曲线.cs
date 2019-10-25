using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Leetcode
{
    public class 控制_CPU_曲线
    {
        public void ControlCPU(float percent)
        {
            PerformanceCounter p = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            while(true)
            {
                if(p.NextValue() > percent)
                {
                    Thread.Sleep(10);
                }
            }
        }
    }
}
