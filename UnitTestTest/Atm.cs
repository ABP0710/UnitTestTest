using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTest
{
    public class Atm
    {
        public static int Pinnumber(int pressedPinnumber)
        {

            return pressedPinnumber;
        }
        public static decimal Withdraw(decimal amountWithdraw, decimal amountTotal)
        {
            return amountWithdraw - amountTotal;
        }
    }
}
