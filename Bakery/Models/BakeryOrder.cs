using System.Collections.Generic;
using System;

namespace BakeryOrder.Models
{
    public class Bread
    {
        public int UserBread { get; set; }

        public Bread(int userBread)
        {
            UserBread = userBread;
        }

        public int Output(int UserBread)
        {
            int BreadTotal = UserBread * 5;

            for (int index = 1; index <= UserBread; index++)
            {
                if (index % 3 == 0 && index <= 3)
                {
                    return BreadTotal - 5;
                }
                else if (index % 3 != 0)
                {
                    return BreadTotal;
                }
            }

            return BreadTotal;
        }
    }
}


//         public class Pastry
//         {
//             public int PastryOrder;
//         }
//     }
// }