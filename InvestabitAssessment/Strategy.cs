using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestabitAssessment
{
    class Strategy
    {
        static List<BackTest.BackTestOrder> ClosePositions(
            string symbol,
            int position,
            DataClass current,
            ref decimal availableCash)
        {
            List<BackTest.BackTestOrder> orders = new List<BackTest.BackTestOrder>();

            try
            {
                int size = 0;

                if (current != null)
                {
                    if (current.RSI14 < 40)
                    {
                        // Close the existing position
                        if (position < 0)
                        {
                            size = -position;
                            availableCash += current.Close * position;
                        }
                    }
                    else if (current.RSI14 > 60)
                    {
                        // Close the existing position
                        if (position > 0)
                        {
                            size = -position;
                            availableCash += current.Close * position;
                        }
                    }
                }

                if (size != 0)
                {
                    orders.Add(new BackTest.BackTestOrder { Size = size, Symbol = symbol });
                }
            }
            catch(Exception ex)
            {
                string x = ex.ToString();
            }

            return orders;
        }

        public static IList<BackTest.BackTestOrder> Trade(
            decimal cash,
            int BTCUSD_Position,
            int ETHUSD_Position,
            int XRPUSD_Position,
            DataClass BTCUSD_current,
            DataClass ETHUSD_current,
            DataClass XRPUSD_current,
            IList<DataClass> BTCUSD_Past,
            IList<DataClass> ETHUSD_Past,
            IList<DataClass> XRPUSD_Past,
            bool lastDay)
        {
            List<BackTest.BackTestOrder> orders = new List<BackTest.BackTestOrder>();

            if (!lastDay)
            {
                decimal availableCash = cash;

                // Cloase positions

                orders.AddRange(ClosePositions("BTCUSD", BTCUSD_Position, BTCUSD_current, ref availableCash));
                orders.AddRange(ClosePositions("ETHUSD", ETHUSD_Position, ETHUSD_current, ref availableCash));
                orders.AddRange(ClosePositions("XRPUSD", XRPUSD_Position, XRPUSD_current, ref availableCash));

                // Use remaining cash

                double relativeBTCUSD_PM = 0;
                double relativeETHUSD_PM = 0;
                double relativeXRPUSD_PM = 0;

                if (BTCUSD_current != null && BTCUSD_current.RSI14 < 40 && BTCUSD_current.PM10 > 0)
                {
                    relativeBTCUSD_PM = (double)(BTCUSD_current.PM10 / BTCUSD_current.Close);
                }

                if (ETHUSD_current != null && ETHUSD_current.RSI14 < 40 && ETHUSD_current.PM10 > 0)
                {
                    relativeETHUSD_PM = (double)(ETHUSD_current.PM10 / ETHUSD_current.Close);
                }

                if (XRPUSD_current != null && XRPUSD_current.RSI14 < 40 && XRPUSD_current.PM10 > 0)
                {
                    relativeXRPUSD_PM = (double)(XRPUSD_current.PM10 / XRPUSD_current.Close);
                }

                double relativeSum = relativeBTCUSD_PM + relativeETHUSD_PM + relativeXRPUSD_PM;

                int sizeBTCUSD = 0;
                int sizeETHUSD = 0;
                int sizeXRPUSD = 0;

                if (relativeSum > 0)
                {
                    if (BTCUSD_current != null) sizeBTCUSD = (int)Math.Floor(((double)availableCash * relativeBTCUSD_PM / relativeSum) / (double)BTCUSD_current.Close);
                    if (ETHUSD_current != null) sizeETHUSD = (int)Math.Floor(((double)availableCash * relativeETHUSD_PM / relativeSum) / (double)ETHUSD_current.Close);
                    if (XRPUSD_current != null) sizeXRPUSD = (int)Math.Floor(((double)availableCash * relativeXRPUSD_PM / relativeSum) / (double)XRPUSD_current.Close);
                }

                if (sizeBTCUSD != 0)
                {
                    //if (sizeBTCUSD > 1) sizeBTCUSD--;
                    orders.Add(new BackTest.BackTestOrder { Size = sizeBTCUSD, Symbol = "BTCUSD" });
                }
                if (sizeETHUSD != 0)
                {
                    if (sizeETHUSD > 1) sizeETHUSD--;
                    orders.Add(new BackTest.BackTestOrder { Size = sizeETHUSD, Symbol = "ETHUSD" });
                }
                if (sizeXRPUSD != 0)
                {
                    if (sizeXRPUSD > 1) sizeXRPUSD--;
                    orders.Add(new BackTest.BackTestOrder { Size = sizeXRPUSD, Symbol = "XRPUSD" });
                }

                //if (BTCUSD_current != null)
                //{
                //    if (BTCUSD_current.RSI14 < 40)
                //    {
                //        // Close the existing position
                //        if (BTCUSD_Position < 0)
                //        {
                //            sizeBTCUSD = -BTCUSD_Position;
                //            availableCash += BTCUSD_current.Close * BTCUSD_Position;
                //        }

                //        //if (BTCUSD_current.PM10 > 0)
                //        //{
                //        //    sizeBTCUSD += (int)Math.Floor(availableCash / BTCUSD_current.Close);
                //        //}
                //    }
                //    else if (BTCUSD_current.RSI14 > 60)
                //    {
                //        // Close the existing position
                //        if (BTCUSD_Position > 0)
                //        {
                //            sizeBTCUSD = -BTCUSD_Position;
                //            availableCash += BTCUSD_current.Close * BTCUSD_Position;
                //        }
                //    }
                //}

                //if (BTCUSD_Past.Count() == 0)
                //{
                //    orders.Add(new BackTest.BackTestOrder { Size = 1, symbol = "BTCUSD" });
                //    orders.Add(new BackTest.BackTestOrder { Size = 1, symbol = "ETHUSD" });
                //    orders.Add(new BackTest.BackTestOrder { Size = 1, symbol = "XRPUSD" });
                //}
            }
            else
            {
                // Close all the positions

                if (BTCUSD_Position != 0)
                {
                    orders.Add(new BackTest.BackTestOrder { Size = -BTCUSD_Position, Symbol = "BTCUSD" });
                }
                if (ETHUSD_Position != 0)
                {
                    orders.Add(new BackTest.BackTestOrder { Size = -ETHUSD_Position, Symbol = "ETHUSD" });
                }
                if (XRPUSD_Position != 0)
                {
                    orders.Add(new BackTest.BackTestOrder { Size = -XRPUSD_Position, Symbol = "XRPUSD" });
                }
            }

            return orders;
        }
    }
}
