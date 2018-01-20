namespace InvestabitAssessment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ButtonBackTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bTCUSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTHUSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xRPUSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewSymbol = new System.Windows.Forms.DataGridView();
            this.dataClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightedPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMA20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTR14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSI14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pM10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageGainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageLossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelGain = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.LabelTrades = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonBackTest,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.LabelGain,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.LabelTrades});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ButtonBackTest
            // 
            this.ButtonBackTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonBackTest.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBackTest.Image")));
            this.ButtonBackTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonBackTest.Name = "ButtonBackTest";
            this.ButtonBackTest.Size = new System.Drawing.Size(65, 23);
            this.ButtonBackTest.Text = "BackTest";
            this.ButtonBackTest.Click += new System.EventHandler(this.ButtonBackTest_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Controls.Add(this.tabPageChart);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 449);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dataGridViewSymbol);
            this.tabPageData.Controls.Add(this.toolStrip2);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(810, 423);
            this.tabPageData.TabIndex = 0;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // tabPageChart
            // 
            this.tabPageChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(810, 423);
            this.tabPageChart.TabIndex = 1;
            this.tabPageChart.Text = "Chart";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(804, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bTCUSDToolStripMenuItem,
            this.eTHUSDToolStripMenuItem,
            this.xRPUSDToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bTCUSDToolStripMenuItem
            // 
            this.bTCUSDToolStripMenuItem.Name = "bTCUSDToolStripMenuItem";
            this.bTCUSDToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.bTCUSDToolStripMenuItem.Text = "BTCUSD";
            this.bTCUSDToolStripMenuItem.Click += new System.EventHandler(this.bTCUSDToolStripMenuItem_Click);
            // 
            // eTHUSDToolStripMenuItem
            // 
            this.eTHUSDToolStripMenuItem.Name = "eTHUSDToolStripMenuItem";
            this.eTHUSDToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.eTHUSDToolStripMenuItem.Text = "ETHUSD";
            this.eTHUSDToolStripMenuItem.Click += new System.EventHandler(this.eTHUSDToolStripMenuItem_Click);
            // 
            // xRPUSDToolStripMenuItem
            // 
            this.xRPUSDToolStripMenuItem.Name = "xRPUSDToolStripMenuItem";
            this.xRPUSDToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.xRPUSDToolStripMenuItem.Text = "XRPUSD";
            this.xRPUSDToolStripMenuItem.Click += new System.EventHandler(this.xRPUSDToolStripMenuItem_Click);
            // 
            // dataGridViewSymbol
            // 
            this.dataGridViewSymbol.AutoGenerateColumns = false;
            this.dataGridViewSymbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSymbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.weightedPriceDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.sMA20DataGridViewTextBoxColumn,
            this.tRDataGridViewTextBoxColumn,
            this.aTR14DataGridViewTextBoxColumn,
            this.rSI14DataGridViewTextBoxColumn,
            this.pM10DataGridViewTextBoxColumn,
            this.averageGainDataGridViewTextBoxColumn,
            this.averageLossDataGridViewTextBoxColumn,
            this.rSDataGridViewTextBoxColumn});
            this.dataGridViewSymbol.DataSource = this.dataClassBindingSource;
            this.dataGridViewSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSymbol.Location = new System.Drawing.Point(3, 28);
            this.dataGridViewSymbol.Name = "dataGridViewSymbol";
            this.dataGridViewSymbol.Size = new System.Drawing.Size(804, 392);
            this.dataGridViewSymbol.TabIndex = 1;
            // 
            // dataClassBindingSource
            // 
            this.dataClassBindingSource.DataSource = typeof(InvestabitAssessment.DataClass);
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            this.symbolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            this.openDataGridViewTextBoxColumn.HeaderText = "Open";
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "High";
            this.highDataGridViewTextBoxColumn.HeaderText = "High";
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "Low";
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "Close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "Close";
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightedPriceDataGridViewTextBoxColumn
            // 
            this.weightedPriceDataGridViewTextBoxColumn.DataPropertyName = "WeightedPrice";
            this.weightedPriceDataGridViewTextBoxColumn.HeaderText = "WeightedPrice";
            this.weightedPriceDataGridViewTextBoxColumn.Name = "weightedPriceDataGridViewTextBoxColumn";
            this.weightedPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sMA20DataGridViewTextBoxColumn
            // 
            this.sMA20DataGridViewTextBoxColumn.DataPropertyName = "SMA20";
            this.sMA20DataGridViewTextBoxColumn.HeaderText = "SMA20";
            this.sMA20DataGridViewTextBoxColumn.Name = "sMA20DataGridViewTextBoxColumn";
            this.sMA20DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRDataGridViewTextBoxColumn
            // 
            this.tRDataGridViewTextBoxColumn.DataPropertyName = "TR";
            this.tRDataGridViewTextBoxColumn.HeaderText = "TR";
            this.tRDataGridViewTextBoxColumn.Name = "tRDataGridViewTextBoxColumn";
            this.tRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aTR14DataGridViewTextBoxColumn
            // 
            this.aTR14DataGridViewTextBoxColumn.DataPropertyName = "ATR14";
            this.aTR14DataGridViewTextBoxColumn.HeaderText = "ATR14";
            this.aTR14DataGridViewTextBoxColumn.Name = "aTR14DataGridViewTextBoxColumn";
            this.aTR14DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rSI14DataGridViewTextBoxColumn
            // 
            this.rSI14DataGridViewTextBoxColumn.DataPropertyName = "RSI14";
            this.rSI14DataGridViewTextBoxColumn.HeaderText = "RSI14";
            this.rSI14DataGridViewTextBoxColumn.Name = "rSI14DataGridViewTextBoxColumn";
            this.rSI14DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pM10DataGridViewTextBoxColumn
            // 
            this.pM10DataGridViewTextBoxColumn.DataPropertyName = "PM10";
            this.pM10DataGridViewTextBoxColumn.HeaderText = "PM10";
            this.pM10DataGridViewTextBoxColumn.Name = "pM10DataGridViewTextBoxColumn";
            this.pM10DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averageGainDataGridViewTextBoxColumn
            // 
            this.averageGainDataGridViewTextBoxColumn.DataPropertyName = "AverageGain";
            this.averageGainDataGridViewTextBoxColumn.HeaderText = "AverageGain";
            this.averageGainDataGridViewTextBoxColumn.Name = "averageGainDataGridViewTextBoxColumn";
            this.averageGainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averageLossDataGridViewTextBoxColumn
            // 
            this.averageLossDataGridViewTextBoxColumn.DataPropertyName = "AverageLoss";
            this.averageLossDataGridViewTextBoxColumn.HeaderText = "AverageLoss";
            this.averageLossDataGridViewTextBoxColumn.Name = "averageLossDataGridViewTextBoxColumn";
            this.averageLossDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rSDataGridViewTextBoxColumn
            // 
            this.rSDataGridViewTextBoxColumn.DataPropertyName = "RS";
            this.rSDataGridViewTextBoxColumn.HeaderText = "RS";
            this.rSDataGridViewTextBoxColumn.Name = "rSDataGridViewTextBoxColumn";
            this.rSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LabelGain
            // 
            this.LabelGain.Name = "LabelGain";
            this.LabelGain.Size = new System.Drawing.Size(36, 23);
            this.LabelGain.Text = "0.00";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 23);
            this.toolStripLabel1.Text = "Gain";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(48, 23);
            this.toolStripLabel2.Text = "Trades";
            // 
            // LabelTrades
            // 
            this.LabelTrades.Name = "LabelTrades";
            this.LabelTrades.Size = new System.Drawing.Size(17, 23);
            this.LabelTrades.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Investabit Assessment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonBackTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TabPage tabPageChart;
        private System.Windows.Forms.DataGridView dataGridViewSymbol;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem bTCUSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTHUSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xRPUSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingSource dataClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightedPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMA20DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTR14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSI14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pM10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageGainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageLossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel LabelGain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel LabelTrades;
    }
}

