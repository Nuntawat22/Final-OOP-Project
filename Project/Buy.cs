using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Buy
    {
        double totalPrice = 0;
        public void Bill(double pay, double getmoney)
        {

            this.totalPrice = getmoney - pay;

        }

        public double restaurantBill()
        {
            return totalPrice;
        }
    }
}
