using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Information
    {
        private string name, customernumber, mail, day, seat;
        private int time = 0;

        public Information(string Name, string cutomerNumber, string Mail, string Day, int Time, string Seat)
        {
            this.name = Name;
            this.customernumber = cutomerNumber;
            this.mail = Mail;
            this.day = Day;
            this.time = Time;
            this.seat = Seat;
           
        }
    }
}
