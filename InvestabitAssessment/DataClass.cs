using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace InvestabitAssessment
{
    partial class DataClass
    {
        public string Symbol
        {
            get;
            private set;
        }
        public DateTime TimeStamp
        {
            get;
            private set;
        }
        public decimal Open
        {
            get;
            private set;
        }
        public decimal High
        {
            get;
            private set;
        }
        public decimal Low
        {
            get;
            private set;
        }
        public decimal Close
        {
            get;
            private set;
        }
        public decimal WeightedPrice
        {
            get;
            private set;
        }
        public decimal Volume
        {
            get;
            private set;
        }
    }

    // Indicators
    partial class DataClass
    {
        public double? SMA20 // 20 periods SMA
        {
            get;
            private set;
        }
        public decimal TR
        {
            get;
            private set;
        }
        public double? ATR14 // 14 periods ATR
        {
            get;
            private set;
        }
        public double? RSI14 // 14 periods RSI
        {
            get;
            private set;
        }
        public decimal? PM10 // 10 periods price momentum
        {
            get;
            private set;
        }

        public double? AverageGain { get; private set; }
        public double? AverageLoss { get; private set; }
        public double? RS { get; private set; }

        public static void CalculateIndicators(IList<DataClass> series)
        {
            for (int i = 0; i < series.Count(); i++)
            {
                DataClass dataItem = series[i];

                DataClass prevDataItem = null;

                if (i > 0)
                {
                    prevDataItem = series[i - 1];
                }

                // Calculate TR

                decimal highMinusLow = dataItem.High - dataItem.Low;

                if (prevDataItem == null)
                {
                    dataItem.TR = highMinusLow;
                }
                else
                {
                    decimal prevClose = prevDataItem.Close;

                    decimal? highMinusPrevClose = dataItem.High - prevClose;
                    decimal? lowMinusPrevClose = dataItem.Low - prevClose;


                    dataItem.TR = Math.Max(Math.Max(highMinusLow, highMinusPrevClose.Value), lowMinusPrevClose.Value);
                }

                // Calculate ATR14

                if (i == 13)
                {
                    dataItem.ATR14 = 0;

                    for (int j = 0; j < 14; j++)
                    {
                        dataItem.ATR14 += (double)series[j].TR;
                    }

                    dataItem.ATR14 = dataItem.ATR14 / 14;
                }
                else if (i > 13)
                {
                    dataItem.ATR14 = (prevDataItem.ATR14 * 13 + (double)dataItem.TR) / 14;
                }

                // Calculate SMA20

                if (i == 19)
                {
                    dataItem.SMA20 = 0;

                    for (int j = 0; j < 20; j++)
                    {
                        dataItem.SMA20 += (double)series[j].Close;
                    }

                    dataItem.SMA20 = dataItem.SMA20 / 20;
                }
                else if (i > 13)
                {
                    dataItem.SMA20 = (prevDataItem.SMA20 * 19 + (double)dataItem.Close) / 20;
                }

                // Calculate RSI14

                if (i == 13)
                {
                    dataItem.AverageGain = 0;
                    dataItem.AverageLoss = 0;

                    for (int j = 0; j < 20; j++)
                    {
                        double gain = (double)series[j].Close - (double)series[j].Open;

                        if (gain > 0)
                        {
                            dataItem.AverageGain += gain;
                        }
                        else
                        {
                            dataItem.AverageLoss += gain;
                        }
                    }

                    dataItem.AverageGain = dataItem.AverageGain / 14;
                    dataItem.AverageLoss = dataItem.AverageLoss / 14;
                }
                else if (i > 13)
                {
                    double gain = (double)dataItem.Close - (double)dataItem.Open;

                    if (gain > 0)
                    {
                        dataItem.AverageGain = (prevDataItem.AverageGain * 13 + gain) / 14;
                        dataItem.AverageLoss = (prevDataItem.AverageLoss * 13) / 14;
                    }
                    else
                    {
                        dataItem.AverageLoss = (prevDataItem.AverageLoss * 13 + gain) / 14;
                        dataItem.AverageGain = (prevDataItem.AverageGain * 13) / 14;
                    }
                }

                if (dataItem.AverageGain.HasValue)
                {
                    dataItem.RS = dataItem.AverageGain.Value / (-dataItem.AverageLoss.Value);
                    dataItem.RSI14 = 100 - 100 / (1 + dataItem.RS);
                }

                // Calculate PM10

                if (i >= 10)
                {
                    dataItem.PM10 = series[i].Close - series[i - 10].Close;
                }


            }
        }
    }

    // Database
    partial class DataClass
    {
        static string ConnectionString
        {
            get
            {
                return @"Data Source=PHAEDRUS\SQL2016;Initial Catalog=InvestabitAssessment;Integrated Security=True;";
            }
        }

        public static IList<DataClass> GetSymbolSeries(string symbol)
        {
            var connection = new SqlConnection(ConnectionString);

            connection.Open();

            var command = connection.CreateCommand();

            command.CommandTimeout = 30; // 30 seconds

            command.CommandType = System.Data.CommandType.Text;

            var parameter = new SqlParameter("@symbol", System.Data.SqlDbType.VarChar, 50);

            parameter.Value = symbol;

            command.Parameters.Add(parameter);

            command.CommandText = "SELECT * FROM [History] WHERE [Symbol] = @symbol ORDER BY [TimeStamp] ASC;";

            var dataReader = command.ExecuteReader();

            var series = new List<DataClass>();

            while (dataReader.Read())
            {
                var data = new DataClass
                {
                    Symbol = (string)dataReader["Symbol"],
                    TimeStamp = (DateTime)dataReader["TimeStamp"],
                    Open = (decimal)dataReader["Open"],
                    High = (decimal)dataReader["High"],
                    Low = (decimal)dataReader["Low"],
                    Close = (decimal)dataReader["Close"],
                    WeightedPrice = (decimal)dataReader["WeightedPrice"],
                    Volume = (decimal)dataReader["Volume"]
                };

                series.Add(data);
            }

            dataReader.Close();
            dataReader.Dispose();

            command.Dispose();

            connection.Close();
            connection.Dispose();

            return series;
        }
    }
}
