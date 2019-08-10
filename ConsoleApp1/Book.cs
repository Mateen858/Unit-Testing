using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Book
    {
        public int SeatNumber { get; set; }

        public bool CheckReserved(int num)
        {
            if (num == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
