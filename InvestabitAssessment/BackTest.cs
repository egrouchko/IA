using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestabitAssessment
{
    class BackTest
    {
        public class BackTestOrder
        {
            public string Symbol = null;
            public int Size = 0; // Positive means BUY, Negative means SELL
        }

        public static void BackTestStrategy(decimal cashStart, out decimal cashEnd, out int tradeCount)
        {
            const decimal tradeCommission = 0.001m; // 0.1%

            tradeCount = 0;

            decimal cashPosition = cashStart;

            int BTCUSD_Position = 0;
            int ETHUSD_Position = 0;
            int XRPUSD_Position = 0;

            IList<DataClass> BTCUSD_Series = DataClass.GetSymbolSeries("BTCUSD");
            IList<DataClass> ETHUSD_Series = DataClass.GetSymbolSeries("ETHUSD");
            IList<DataClass> XRPUSD_Series = DataClass.GetSymbolSeries("XRPUSD");

            DataClass.CalculateIndicators(BTCUSD_Series);
            DataClass.CalculateIndicators(ETHUSD_Series);
            DataClass.CalculateIndicators(XRPUSD_Series);

            DateTime time = new DateTime(2017, 10, 1, 0, 0, 0);

            TimeSpan _15m = new TimeSpan(0, 15, 0);

            DateTime end = new DateTime(2017, 10, 31, 23, 45, 0);

            do
            {
                DataClass BTCUSD_current = BTCUSD_Series.FirstOrDefault(m => m.TimeStamp == time);
                DataClass ETHUSD_current = ETHUSD_Series.FirstOrDefault(m => m.TimeStamp == time);
                DataClass XRPUSD_current = XRPUSD_Series.FirstOrDefault(m => m.TimeStamp == time);

                IList<DataClass> BTCUSD_Past = BTCUSD_Series.TakeWhile(m => m.TimeStamp < time).ToList();
                IList<DataClass> ETHUSD_Past = ETHUSD_Series.TakeWhile(m => m.TimeStamp < time).ToList();
                IList<DataClass> XRPUSD_Past = XRPUSD_Series.TakeWhile(m => m.TimeStamp < time).ToList();

                IList<BackTest.BackTestOrder> orders = Strategy.Trade(
                    cashPosition,
                    BTCUSD_Position,
                    ETHUSD_Position,
                    XRPUSD_Position,
                    BTCUSD_current,
                    ETHUSD_current,
                    XRPUSD_current,
                    BTCUSD_Past,
                    ETHUSD_Past,
                    XRPUSD_Past,
                    time == end);

                // Process the orders
                foreach(BackTest.BackTestOrder order in orders)
                {
                    if (order.Size == 0) continue;

                    tradeCount++;

                    decimal orderPrice = 0;

                    switch (order.Symbol)
                    {
                        case "BTCUSD":
                            BTCUSD_Position += order.Size;
                            orderPrice = order.Size * BTCUSD_current.Close;
                            break;

                        case "ETHUSD":
                            ETHUSD_Position += order.Size;
                            orderPrice = order.Size * ETHUSD_current.Close;
                            break;

                        case "XRPUSD":
                            XRPUSD_Position += order.Size;
                            orderPrice = order.Size * XRPUSD_current.Close;
                            break;
                    }

                    if (orderPrice != 0)
                    {
                        cashPosition -= orderPrice;
                        cashPosition -= Math.Abs(orderPrice) * tradeCommission;
                    }

                    if (cashPosition < 0)
                    {
                        //throw new Exception("Not enough cash");
                    }
                }

                time = time.Add(_15m);
            } while (time <= end);

            cashEnd = cashPosition;
        }
    }
}
