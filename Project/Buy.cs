using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Buy
    {
        double total = 0;
        public void Bill(double restaurant, double getmoney)
        {
            this.total = getmoney - restaurant;
            total += getmoney;
            total += restaurant;
        }

        public double restaurantBill()
        {
            return total;
        }
    }
}
