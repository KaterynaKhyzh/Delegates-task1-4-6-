using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    internal class Timer
    {
        private Action action;

        public Timer(Action action, int t)
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    action.Invoke();
                    Thread.Sleep(TimeSpan.FromSeconds(t));
                }
            });
            thread.Start();
        }

    }
}
