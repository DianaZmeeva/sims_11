namespace sims_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.input_days = new System.Windows.Forms.NumericUpDown();
            this.input_price = new System.Windows.Forms.NumericUpDown();
            this.label_days = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.input_days);
            this.panel1.Controls.Add(this.input_price);
            this.panel1.Controls.Add(this.label_days);
            this.panel1.Controls.Add(this.label_price);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_days
            // 
            this.input_days.Location = new System.Drawing.Point(81, 47);
            this.input_days.Name = "input_days";
            this.input_days.Size = new System.Drawing.Size(120, 20);
            this.input_days.TabIndex = 3;
            this.input_days.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // input_price
            // 
            this.input_price.DecimalPlaces = 2;
            this.input_price.Location = new System.Drawing.Point(81, 15);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(120, 20);
            this.input_price.TabIndex = 2;
            this.input_price.Value = new decimal(new int[] {
            7267,
            0,
            0,
            131072});
            // 
            // label_days
            // 
            this.label_days.AutoSize = true;
            this.label_days.Location = new System.Drawing.Point(12, 49);
            this.label_days.Name = "label_days";
            this.label_days.Size = new System.Drawing.Size(34, 13);
            this.label_days.TabIndex = 1;
            this.label_days.Text = "Days:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(12, 15);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(63, 13);
            this.label_price.TabIndex = 0;
            this.label_price.Text = "Initial price: ";
            // 
            // chart1
            // 
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f2";
            series1.Legend = "Legend1";
            series1.Name = "Euro";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(319, 220);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 320);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown input_days;
        private System.Windows.Forms.NumericUpDown input_price;
        private System.Windows.Forms.Label label_days;
        private System.Windows.Forms.Label label_price;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

