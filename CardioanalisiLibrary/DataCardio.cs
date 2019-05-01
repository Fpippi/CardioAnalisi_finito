using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class DataCardio
    {
        public static string frequenzaMax_min(string eta, ref string min)
        {
            string risultato = "";

            try
            {
                int tmp = Convert.ToInt32(eta);
                if (tmp <= 0)
                {
                    risultato = "attenzione non puoi inserire un eta uguale a 0 o inferiore";
                }
                else
                {
                    tmp = 220 - tmp;

                    min = Convert.ToString(tmp * 0.7);
                    risultato = Convert.ToString(tmp * 0.9);
                }


            }
            catch
            {
                risultato = "non puoi inserire delle lettere";
            }


            return risultato;
        }
    }
}
