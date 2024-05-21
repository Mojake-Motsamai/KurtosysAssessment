using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_WebServices.Utilities
{
    class HelperClass
    {
        public void ResponseTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
          //  Thread.Sleep(1000);
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{2:00}.{3:00}", ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
