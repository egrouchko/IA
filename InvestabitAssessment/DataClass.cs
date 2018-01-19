using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace InvestabitAssessment
{
    class DataClass
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

        static string ConnectionString
        {
            get
            {
                return @"Data Source=PHAEDRUS\SQL2016;Initial Catalog=InvestabitAssessment;Integrated Security=True;";
            }
        }

        public static IEnumerable<DataClass> GetSymbolSeries(string symbol)
        {
            var connection = new SqlConnection(ConnectionString);

            connection.Open();

            var command = connection.CreateCommand();

            command.CommandTimeout = 30; // 30 seconds

            command.CommandType = System.Data.CommandType.Text;

            var parameter = new SqlParameter("@symbol", System.Data.SqlDbType.VarChar, 50);

            parameter.Value = symbol;

            command.Parameters.Add(parameter);

            command.CommandText = "SELECT * FROM [History] WHERE [Symbol] = @symbol;";

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
