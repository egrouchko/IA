using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestabitAssessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ButtonBackTest_Click(object sender, EventArgs e)
        {
            try
            {
                LabelGain.Text = "***";

                const decimal cashStart = 100000m;

                decimal cashEnd;
                int tradeCount;

                BackTest.BackTestStrategy(cashStart, out cashEnd, out tradeCount);

                decimal gain = cashEnd - cashStart;

                LabelGain.Text = gain.ToString("0.00");
                LabelTrades.Text = tradeCount.ToString();
            }
            catch (Exception ex)
            {
                string x = ex.ToString();
            }
        }

        private void bTCUSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGrid("BTCUSD");
        }

        private void eTHUSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGrid("ETHUSD");
        }

        private void xRPUSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGrid("XRPUSD");
        }

        void LoadGrid(string symbol)
        {
            try
            {
                IList<DataClass> series = DataClass.GetSymbolSeries(symbol);

                DataClass.CalculateIndicators(series);

                dataClassBindingSource.DataSource = series;
            }
            catch(Exception ex)
            {
                string x = ex.ToString();
            }
        }
    }
}
