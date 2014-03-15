using System;
using System.Collections.Generic;
using System.Text;

namespace PiHexScreensaver
{
    class Computation
    {

        public string digitComputed = "X";
        private int digit = -1;

        public Computation(int digit)
        {
            this.digit = digit;
        }

        public void compute()
        {
            digitComputed = PiHex.nthHexDigitOfPi(digit);
        }


    }
}
