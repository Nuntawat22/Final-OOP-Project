using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Checkpay
    {
        private string discountCode = string.Empty;
        private double minimunPrice;

        public void open(double min)
        {
            this.minimunPrice = min;
            if (min > 0)
            {

                this.minimunPrice = min - (this.minimunPrice * 0.15);

            }


        }

        public double getDiscount()
        {
            return this.minimunPrice;
        }
    }
}
