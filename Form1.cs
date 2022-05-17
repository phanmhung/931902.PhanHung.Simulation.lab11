using System;
using System.Drawing;
using System.Windows.Forms;

namespace Simulation.Lab._11
{
    public partial class Form1 : Form
    {

        double[] probs;
        double[] probs_freq;
        double chi = 9.488d;
        double X;
        int N;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random_prob = 1001;
            nud_prob1.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob1.Value * 1000);
            nud_prob2.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob2.Value * 1000);
            nud_prob3.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob3.Value * 1000);
            nud_prob4.Value = (decimal)rnd.Next(random_prob) / 1000;
        }

        private void btn_get_answer_Click(object sender, EventArgs e)
        {
            double expected_value = 0;
            double dispersion_value = 0;
            double[] st;
            X = 0d;
            //chi = Convert.ToDouble(tb_chi_count.Text);

            probs = new double[5];
            probs_freq = new double[5];

            probs[0] = (double)nud_prob1.Value;
            probs[1] = (double)nud_prob2.Value;
            probs[2] = (double)nud_prob3.Value;
            probs[3] = (double)nud_prob4.Value;
            probs[4] = (double)nud_prob5.Value;

            N = (int)nud_n.Value;
            st = calculate_stat(probs, N);

            for (int i = 0; i < probs.Length; i++) probs_freq[i] = st[i] / N;

            for (int i = 0; i < probs.Length; i++) expected_value += (i + 1) * probs_freq[i];

            for (int i = 0; i < probs.Length; i++) dispersion_value += probs_freq[i] * ((i + 1) - expected_value) * ((i + 1) - expected_value);

            tb_average.Text = Convert.ToString(expected_value);
            tb_variance.Text = Convert.ToString(dispersion_value);

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < probs.Length; i++) chart1.Series[0].Points.AddXY(i + 1, probs_freq[i]);

            for (int i = 0; i < probs.Length; i++) X += (st[i] * st[i]) / (N * probs[i]);
            X -= N;

            tb_chi.Text = Convert.ToString(X);
            if (X < chi)
            {
                lbl_sign.Text = "<";
                lbl_true_false.ForeColor = Color.Green;
                lbl_true_false.Text = "TRUE";
            }
            else
            {
                lbl_sign.Text = ">";
                lbl_true_false.ForeColor = Color.Red;
                lbl_true_false.Text = "FALSE";
            }
        }

        private double[] calculate_stat(double[] probs, int N)
        {
            double[] Statistic = new double[5];
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                double K = rnd.NextDouble();
                int event_id = 0;

                K -= probs[0];

                while (K > 0)
                {
                    event_id++;
                    K -= probs[event_id];
                };

                Statistic[event_id]++;
            }

            return Statistic;
        }

        private void set_prob5_value()
        {
            decimal temp = (decimal)(1d - (double)nud_prob1.Value - (double)nud_prob2.Value - (double)nud_prob3.Value - (double)nud_prob4.Value);
            if (temp > 0) nud_prob5.Value = temp;
        }

        private void reload_chart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(1, nud_prob1.Value);
            chart1.Series[0].Points.AddXY(2, nud_prob2.Value);
            chart1.Series[0].Points.AddXY(3, nud_prob3.Value);
            chart1.Series[0].Points.AddXY(4, nud_prob4.Value);
            chart1.Series[0].Points.AddXY(5, nud_prob5.Value);
        }

        private void nud_prob1_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }

        private void nud_prob2_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }

        private void nud_prob3_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }

        private void nud_prob4_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }

        private void nud_prob5_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }
    }
}
