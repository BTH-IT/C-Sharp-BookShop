using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach
{
    public class CustomTimer
    {
        private static CustomTimer instance;

        public static CustomTimer Instance {
            get { 
                if (instance == null)
                {
                    instance = new CustomTimer();
                } 
                return instance;
            }
        }

        public System.Timers.Timer SetInterval(Action action, int interval)
        {
            var timer = new System.Timers.Timer(interval);
            timer.Elapsed += (s, e) => {
                timer.Enabled = false;
                action();
                timer.Enabled = true;
            };
            timer.Enabled = true;
            return timer;
        }

        public void ClearInterval(System.Timers.Timer timer)
        {
            timer.Stop();
            timer.Dispose();
        }

        public void SetTimeout(Action action, int timeout)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = timeout;
            timer.Tick += (s, e) =>
            {
                action();
                timer.Stop();
            };
            timer.Start();
        }
    }
}
