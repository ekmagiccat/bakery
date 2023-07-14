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

        public int Output(int userBread)
        {
            int breadTotal = UserBread * 5;

            if (UserBread >= 3)
            {
                int freeLoaves = UserBread / 3;
                breadTotal -= (freeLoaves * 5);
            }

            return breadTotal;
        }
    }
}



//         public class Pastry
//         {
//             public int PastryOrder;
//         }
//     }
// }