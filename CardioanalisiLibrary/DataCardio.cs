using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class DataCardio
    {
        public static string frequenzaMax_min(string eta, ref string min)//biagioni
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


        public static string frequenzanome(string frequenza)//biagioni
        {
            string risultato = "";
            try
            {
                int tmp = Convert.ToInt32(frequenza);
                if (tmp <= 0)
                {
                    risultato = "attenzione non puoi inserire un eta uguale a 0 o inferiore";
                }
                else
                {
                    if (tmp <= 60) risultato = "Bradicardia";
                    else if (tmp <= 100) risultato = "Normale";
                    else risultato = "Tachicardia";
                }


            }
            catch
            {
                risultato = "non puoi inserire delle lettere";
            }

            return risultato;
        }

        public static string calcolo(string frequenza, string peso, string eta, string durata, ref string femmina)//pippi
        {
            string risultato = "";

            try
            {
                int A = Convert.ToInt32(eta);
                int P = Convert.ToInt32(peso);
                int F = Convert.ToInt32(frequenza);
                int T = Convert.ToInt32(durata);

                if (T <= 0) risultato = "attenzione non puoi inserire un eta uguale a 0 o inferiore";
                else if (P <= 0) risultato = "attenzione non puoi inserire un eta uguale a 0 o inferiore";
                else if (F <= 0) risultato = "attenzione non puoi inserire un eta uguale a 0 o inferiore";
                else if (A <= 0) risultato = "attenzione non puoi inserire un eta uguale a 0 o inferiore";
                else
                {

                    if ((((A * 0.2017) + (P * 0.199) + (F * 0.6309) - 55.0969) * T / 4.184) > 0)
                    {
                        risultato = Convert.ToString(((A * 0.2017) + (P * 0.199) + (F * 0.6309) - 55.0969) * T / 4.184);
                    }
                    else
                    {
                        risultato = "Attenzione hai inserito dei dati non corretti";
                    }

                    if ((((A * 0.074) - (P * 0.126) + (F * 0.4472) - 20.4022) * T / 4.184) > 0)
                    {
                        femmina = Convert.ToString(((A * 0.074) + (P * 0.126) + (F * 0.4472) - 20.4022) * T / 4.184);
                    }
                    else
                    {
                        femmina = "Attenzione hai inserito dei dati non corretti";
                    }

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
