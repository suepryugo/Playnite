﻿using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite
{
    public class ExecutionTimer : IDisposable
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string name;
        private Stopwatch watch = new Stopwatch();

        public ExecutionTimer(string name)
        {
            this.name = name;
            watch.Start();
        }

        public void Dispose()
        {
            watch.Stop();
            logger.Debug($"--- Timer '{name}', {watch.ElapsedMilliseconds} ms to complete.");
        }
    }

    public class Timer
    {
        public static IDisposable TimeExecution(string name)
        {
            return new ExecutionTimer(name);
        }
    }
}
