using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double m=0.01;
        double s=0.05;
        double dt=0.1;
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            double price = (double)input_price.Value;
            int days = (int)input_days.Value;
            chart1.Series[0].Points.AddXY(0, price);
            for (int i = 1; i <= days; i++)
            {
                price = price * Math.Exp((m - s * s / 2) * dt + s * Math.Sqrt(dt) * RN());
                chart1.Series[0].Points.AddXY(i, price);
            }

        }

        private double RN()
        {
            double alpha = rnd.NextDouble();
            double t = Math.Sqrt(-1*Math.Log10(alpha));
            double F = (2.30753 + 0.27061 * t) / (1 - 0.99229 * t + 0.04481 * t * t) - t;
            if(alpha>=0.5)
                return F;
            else
                return -F;
        }
    }
}
