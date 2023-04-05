using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Class
    {
        private string name, customerNumber, mail,
            day, seat;
        private int time = 0;

        public Class(string name, string cutomerNumber, string mail,
            string day, int time, string seat)
        {
            this.name = name;
            this.customerNumber = customerNumber;
            this.mail = mail;
            this.day = day;
            this.time = time;
            this.seat = seat;
           
        }

        public string Name { get => name; }

        public string CustomerNumber { get => customerNumber; }

        public string Mail { get => mail; }

        public string Day { get => day; }

        public int Time { get => time; }

        public string Seat { get => seat; }

    }
}
