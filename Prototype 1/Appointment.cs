using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Appointment
    {
        private int appointID;
        private DateTime time;

        public int AppointID
        {
            get { return appointID; }
            set { appointID = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public Appointment() { }

        public Appointment(int appointID, DateTime ti)
        {
            AppointID = appointID;
            Time = ti;
        }
    }
}
