using System.Collections.Generic;
using System;

namespace BakeryOrder.Models
{

    public class Bread
    {
        public int UserBread;

        public int BreadTotal;

        public int Output(int UserBread)
        {
            for (int index = 1; index <= UserBread; index++)
            {
                if (index % 3 == 0 && index <= 3)
                {
                    return BreadTotal - 5;
                }
                else (index % 3 != 0);
                {
                    return BreadTotal;

                }
            }
        }

        public class Pastry
        {
            public int PastryOrder;
        }
    }
}