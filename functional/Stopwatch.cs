using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class Stopwatch
    {
        public double startTimer = 0;
        public double stopTimer = 0;
        public double elapsed;
        Utility utility = new Utility();
        public void Start()
        {
            startTimer = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine("Start Time is: " + startTimer);
        }
        public void Stop()
        {
            stopTimer = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine("Stop Time is: " + stopTimer);
        }
        public double GetElapsedTime()
        {
            elapsed = stopTimer - startTimer;
            return elapsed;
        }

        public void Watch() 
        {
            Stopwatch s = new Stopwatch();
       
            Console.Write("Press '1' to Start Time: ");
            int st = utility.Number();
   	        s.Start();

            Console.WriteLine("");
            Console.Write("Press '2' to Stop Time: ");
            int op = utility.Number();
   	        s.Stop();

   	        double l = s.GetElapsedTime();
            Console.WriteLine("");

            Console.WriteLine("Total Time Elapsed(in millisec) is:"+l);
            Console.WriteLine("");

            Console.WriteLine("Converting millisec to seconds: "+(l/1000)+" sec");
            Console.ReadKey();
        }
    }
}
