using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class DataCardio
    {
        public static string frequenzaMax_min(string eta, ref string min)//1
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


        public static string frequenzanome(string frequenza)//2
        {
            string risultato = "";
            try
            {
                int tmp = Convert.ToInt32(frequenza);
                if (tmp <= 0)
                {
                    risultato = "attenzione non puoi inserire una frequenza uguale a 0 o inferiore";
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
            //3
            string risultato = "";

            try
            {
                int A = Convert.ToInt32(eta);
                int P = Convert.ToInt32(peso);
                int F = Convert.ToInt32(frequenza);
                int T = Convert.ToInt32(durata);

                if (T <= 0) risultato = "attenzione non puoi inserire un eta uguale a 0 o inferiore";
                else if (P <= 0) risultato = "attenzione non puoi inserire un peso uguale a 0 o inferiore";
                else if (F <= 0) risultato = "attenzione non puoi inserire una frequenza uguale a 0 o inferiore";
                else if (A <= 0) risultato = "attenzione non puoi inserire una durata uguale a 0 o inferiore";
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

        public static string allenamento(string allenamento, string Km, string peso)//4
        {
            string calcolo = "";

            try
            {
                int Km2 = Convert.ToInt32(Km);
                int peso2 = Convert.ToInt32(peso);

                if (peso2 == 0)
                {
                    calcolo = "non puoi inserire un peso sotto 0";
                }
                else if (allenamento.ToUpper() == "CORSA")
                {
                    calcolo = Convert.ToString(0.9 * Km2 * peso2);
                }
                else if (allenamento.ToUpper() == "CAMMINATA")
                {
                    calcolo = Convert.ToString(0.5 * Km2 * peso2);
                }
                else
                {
                    calcolo = "attenzione devi inserire o camminata o corsa";
                }



            }
            catch
            {
                calcolo = "attenzione devi inserire dei numeri sui Km e sul peso";
            }


            return calcolo;
        }


        public static string IsDetermined4(string battito01, string battito02, string battito03)
        {
            //numero 5
            string risultato = "";
            string media = "";
            string frequenza = "";
            string variabilità = "";
            string primo = "";
            string secondo = "";
            string terzo = "";
            double battitomedio = 0;
            double min = 1000;
            double max = 0;
            double centrale = 0;
            try
            {
                double battito1 = Convert.ToDouble(battito01);
                double battito2 = Convert.ToDouble(battito02);
                double battito3 = Convert.ToDouble(battito03);


            battitomedio = Convert.ToUInt32((battito1 + battito2 + battito3) / 3);
            
                media = Convert.ToString(battitomedio);

                if (battitomedio < 60)
                {
                    frequenza = "Bradicardia";
                }

                if (battitomedio >= 60 && battitomedio <= 100)
                {
                    frequenza = "Normale";
                }

                if (battitomedio > 100)
                {
                    frequenza = "Tachicardia";
                }

                if (min > battito1) min = battito1;
                if (min > battito2) min = battito2;
                if (min > battito3) min = battito3;

                if (max < battito1) max = battito1;
                if (max < battito2) max = battito2;
                if (max < battito3) max = battito3;

                variabilità = Convert.ToString(max - min);

                if (battito1 != min)
                {
                    if (battito1 != max) centrale = battito1;
                }
                if (battito2 != min)
                {
                    if (battito2 != max) centrale = battito2;
                }
                if (battito3 != min)
                {
                    if (battito3 != max) centrale = battito3;
                }


                primo = Convert.ToString(min);
                secondo = Convert.ToString(centrale);
                terzo = Convert.ToString(max);

                risultato = media + " " + frequenza + " " + variabilità + " " + primo + " " + secondo + " " + terzo;
            }
            catch
            {
                risultato = "attenzione devi inserire dei numeri";
            }


            return risultato;
        }


        public static string pesoideale(string altezza, string peso)//6
        {
            string risultato = "";

            try
            {
                double peso2 = Convert.ToDouble(peso);
                double altezza2 = Convert.ToDouble(altezza);

                if (altezza2 <= 0 || peso2 <= 0)
                {
                    risultato = "non puoi inserire numeri negativi";
                }
                else
                {
                    double risultato2 = (peso2 / (altezza2 * altezza2));

                    if (risultato2 > 40) risultato = "OBESITA’ DI ALTO GRADO";
                    else if (risultato2 > 30 && risultato2 < 40) risultato = "OBESITA’ DI MEDIO GRADO";
                    else if (risultato2 > 25 && risultato2 < 30) risultato = "SOVRAPPESO";
                    else if (risultato2 > 18.5 && risultato2 < 25) risultato = "NORMOPESO";
                    else if (risultato2 > 16 && risultato2 < 18.5) risultato = "SOTTOPESO";
                    else risultato = "GRAVE MAGREZZA";


                }

            }
            catch
            {
                risultato = "devi inserire dei numeri";
            }


            return risultato;
        }
    }
}
