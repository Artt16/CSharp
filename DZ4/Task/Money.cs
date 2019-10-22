using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Money
    {
        public double Grivna { get; set; }
        public Money(double grivna)
        {
            Grivna = grivna;
        }

        public Money()
        {
        }

        public static Money operator +(Money gr, Money gr2)
        {
            var Sum = new Money();
            Sum.Grivna = gr.Grivna + gr2.Grivna;
            return Sum;
        }

        public static Money operator -(Money gr, Money gr2)
        {
            var diff = new Money();
            diff.Grivna = gr.Grivna - gr2.Grivna;
            return diff;
        }
        public static Money operator *(Money gr, int gr2)
        {
            if (gr2 == 0) { throw new Bankrupt(); }
            else
            {
                var mult = new Money();
                mult.Grivna = gr.Grivna * gr2;
                return mult;
            }
        }
        public static Money operator / (Money gr, int gr2)
        {
            if (gr2 == 0) { throw new Bankrupt(); }
            else
            {
                var mult = new Money();
                mult.Grivna = gr.Grivna / gr2;
                return mult;
            }
        }
        public static Money operator ++(Money gr)
        {
            var inc = new Money();
            inc.Grivna = gr.Grivna + 0.01;
            return inc;
        }
        public static Money operator --(Money gr)
        {
            var dec = new Money();
            dec.Grivna = gr.Grivna - 0.01;
            return dec;
        }
        public static bool operator ==(Money gr, Money gr2)
        {
            bool result;
            if (gr.Grivna == gr2.Grivna)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static bool operator !=(Money gr, Money gr2)
        {
            bool result;
            if (gr.Grivna != gr2.Grivna)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
