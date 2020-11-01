using System;
using System.Windows.Forms;

namespace UM_Monitor
{
    public class FilterConfig
    {
        public FcMode mode = FcMode.all;

        public int seconds = 1;

        public DateTimePicker dtmin;
        public DateTimePicker dtmax;


        public FilterConfig(DateTimePicker dt1, DateTimePicker dt2)
        {
            this.dtmin = dt1;
            this.dtmin.MinDate = DateTime.Now;
            this.dtmin.MaxDate = DateTime.Now;

            this.dtmax = dt2;
            this.dtmax.MinDate = DateTime.Now;
            this.dtmax.MaxDate = DateTime.Now;
        }


        public enum FcMode
        {
            all,
            lastxseconds,
            fromto
        }
    }
}
