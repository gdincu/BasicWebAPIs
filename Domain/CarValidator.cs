using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicWebAPI.Domain
{
    class CarValidator
    {
        public void validate(Car car)
        {
            double price = car.Price;
            String errors = "";

            if (price < 0)
                errors += "The price needs to be positive\n";

            if (!errors.Equals(""))
            {
                throw new Exception(errors);
            }
        }

    }
}
