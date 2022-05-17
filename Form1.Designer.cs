namespace Simulation.Lab._11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_exit = new System.Windows.Forms.Button();
            this.nud_prob5 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob5 = new System.Windows.Forms.Label();
            this.nud_prob4 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob4 = new System.Windows.Forms.Label();
            this.nud_prob3 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob3 = new System.Windows.Forms.Label();
            this.nud_prob2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob2 = new System.Windows.Forms.Label();
            this.nud_prob1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_prob1 = new System.Windows.Forms.Label();
            this.nud_n = new System.Windows.Forms.NumericUpDown();
            this.lbl_n = new System.Windows.Forms.Label();
            this.btn_get_answer = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.lbl_info5 = new System.Windows.Forms.Label();
            this.lbl_info4 = new System.Windows.Forms.Label();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.tb_average = new System.Windows.Forms.TextBox();
            this.tb_variance = new System.Windows.Forms.TextBox();
            this.tb_chi = new System.Windows.Forms.TextBox();
            this.tb_chi_count = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_sign = new System.Windows.Forms.Label();
            this.lbl_true_false = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(790, 11);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 45);
            this.btn_exit.TabIndex = 101;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // nud_prob5
            // 
            this.nud_prob5.DecimalPlaces = 3;
            this.nud_prob5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob5.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud_prob5.Location = new System.Drawing.Point(93, 149);
            this.nud_prob5.Name = "nud_prob5";
            this.nud_prob5.ReadOnly = true;
            this.nud_prob5.Size = new System.Drawing.Size(128, 26);
            this.nud_prob5.TabIndex = 113;
            this.nud_prob5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob5.ValueChanged += new System.EventHandler(this.nud_prob5_ValueChanged);
            // 
            // lbl_prob5
            // 
            this.lbl_prob5.AutoSize = true;
            this.lbl_prob5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob5.Location = new System.Drawing.Point(32, 151);
            this.lbl_prob5.Name = "lbl_prob5";
            this.lbl_prob5.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob5.TabIndex = 117;
            this.lbl_prob5.Text = "Prob 5";
            // 
            // nud_prob4
            // 
            this.nud_prob4.DecimalPlaces = 3;
            this.nud_prob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob4.Location = new System.Drawing.Point(93, 117);
            this.nud_prob4.Name = "nud_prob4";
            this.nud_prob4.Size = new System.Drawing.Size(128, 26);
            this.nud_prob4.TabIndex = 112;
            this.nud_prob4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob4.ValueChanged += new System.EventHandler(this.nud_prob4_ValueChanged);
            // 
            // lbl_prob4
            // 
            this.lbl_prob4.AutoSize = true;
            this.lbl_prob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob4.Location = new System.Drawing.Point(32, 119);
            this.lbl_prob4.Name = "lbl_prob4";
            this.lbl_prob4.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob4.TabIndex = 116;
            this.lbl_prob4.Text = "Prob 4";
            // 
            // nud_prob3
            // 
            this.nud_prob3.DecimalPlaces = 3;
            this.nud_prob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob3.Location = new System.Drawing.Point(93, 85);
            this.nud_prob3.Name = "nud_prob3";
            this.nud_prob3.Size = new System.Drawing.Size(128, 26);
            this.nud_prob3.TabIndex = 111;
            this.nud_prob3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob3.ValueChanged += new System.EventHandler(this.nud_prob3_ValueChanged);
            // 
            // lbl_prob3
            // 
            this.lbl_prob3.AutoSize = true;
            this.lbl_prob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob3.Location = new System.Drawing.Point(32, 87);
            this.lbl_prob3.Name = "lbl_prob3";
            this.lbl_prob3.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob3.TabIndex = 115;
            this.lbl_prob3.Text = "Prob 3";
            // 
            // nud_prob2
            // 
            this.nud_prob2.DecimalPlaces = 3;
            this.nud_prob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob2.Location = new System.Drawing.Point(93, 53);
            this.nud_prob2.Name = "nud_prob2";
            this.nud_prob2.Size = new System.Drawing.Size(128, 26);
            this.nud_prob2.TabIndex = 110;
            this.nud_prob2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob2.ValueChanged += new System.EventHandler(this.nud_prob2_ValueChanged);
            // 
            // lbl_prob2
            // 
            this.lbl_prob2.AutoSize = true;
            this.lbl_prob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob2.Location = new System.Drawing.Point(32, 55);
            this.lbl_prob2.Name = "lbl_prob2";
            this.lbl_prob2.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob2.TabIndex = 114;
            this.lbl_prob2.Text = "Prob 2";
            // 
            // nud_prob1
            // 
            this.nud_prob1.DecimalPlaces = 3;
            this.nud_prob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_prob1.Location = new System.Drawing.Point(93, 21);
            this.nud_prob1.Name = "nud_prob1";
            this.nud_prob1.Size = new System.Drawing.Size(128, 26);
            this.nud_prob1.TabIndex = 109;
            this.nud_prob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_prob1.ValueChanged += new System.EventHandler(this.nud_prob1_ValueChanged);
            // 
            // lbl_prob1
            // 
            this.lbl_prob1.AutoSize = true;
            this.lbl_prob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_prob1.Location = new System.Drawing.Point(32, 23);
            this.lbl_prob1.Name = "lbl_prob1";
            this.lbl_prob1.Size = new System.Drawing.Size(55, 20);
            this.lbl_prob1.TabIndex = 108;
            this.lbl_prob1.Text = "Prob 1";
            // 
            // nud_n
            // 
            this.nud_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_n.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_n.Location = new System.Drawing.Point(93, 181);
            this.nud_n.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_n.Name = "nud_n";
            this.nud_n.Size = new System.Drawing.Size(128, 26);
            this.nud_n.TabIndex = 118;
            this.nud_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_n.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_n.Location = new System.Drawing.Point(46, 183);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(20, 20);
            this.lbl_n.TabIndex = 119;
            this.lbl_n.Text = "N";
            // 
            // btn_get_answer
            // 
            this.btn_get_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_get_answer.Location = new System.Drawing.Point(543, 331);
            this.btn_get_answer.Name = "btn_get_answer";
            this.btn_get_answer.Size = new System.Drawing.Size(225, 42);
            this.btn_get_answer.TabIndex = 120;
            this.btn_get_answer.Text = "Получить ответ";
            this.btn_get_answer.UseVisualStyleBackColor = true;
            this.btn_get_answer.Click += new System.EventHandler(this.btn_get_answer_Click);
            // 
            // btn_random
            // 
            this.btn_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_random.Location = new System.Drawing.Point(358, 331);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(179, 42);
            this.btn_random.TabIndex = 130;
            this.btn_random.Text = "Случайные значния";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // lbl_info5
            // 
            this.lbl_info5.AutoSize = true;
            this.lbl_info5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info5.Location = new System.Drawing.Point(32, 303);
            this.lbl_info5.Name = "lbl_info5";
            this.lbl_info5.Size = new System.Drawing.Size(95, 20);
            this.lbl_info5.TabIndex = 133;
            this.lbl_info5.Text = "Chi-squared";
            // 
            // lbl_info4
            // 
            this.lbl_info4.AutoSize = true;
            this.lbl_info4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info4.Location = new System.Drawing.Point(32, 273);
            this.lbl_info4.Name = "lbl_info4";
            this.lbl_info4.Size = new System.Drawing.Size(72, 20);
            this.lbl_info4.TabIndex = 132;
            this.lbl_info4.Text = "Variance";
            // 
            // lbl_info3
            // 
            this.lbl_info3.AutoSize = true;
            this.lbl_info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info3.Location = new System.Drawing.Point(32, 242);
            this.lbl_info3.Name = "lbl_info3";
            this.lbl_info3.Size = new System.Drawing.Size(68, 20);
            this.lbl_info3.TabIndex = 131;
            this.lbl_info3.Text = "Average";
            // 
            // tb_average
            // 
            this.tb_average.Location = new System.Drawing.Point(146, 244);
            this.tb_average.Name = "tb_average";
            this.tb_average.Size = new System.Drawing.Size(60, 20);
            this.tb_average.TabIndex = 134;
            // 
            // tb_variance
            // 
            this.tb_variance.Location = new System.Drawing.Point(146, 275);
            this.tb_variance.Name = "tb_variance";
            this.tb_variance.Size = new System.Drawing.Size(60, 20);
            this.tb_variance.TabIndex = 135;
            // 
            // tb_chi
            // 
            this.tb_chi.Location = new System.Drawing.Point(146, 305);
            this.tb_chi.Name = "tb_chi";
            this.tb_chi.Size = new System.Drawing.Size(60, 20);
            this.tb_chi.TabIndex = 136;
            // 
            // tb_chi_count
            // 
            this.tb_chi_count.Location = new System.Drawing.Point(253, 305);
            this.tb_chi_count.Name = "tb_chi_count";
            this.tb_chi_count.Size = new System.Drawing.Size(60, 20);
            this.tb_chi_count.TabIndex = 137;
            this.tb_chi_count.Text = "9.488";
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.Location = new System.Drawing.Point(358, 21);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(410, 304);
            this.chart1.TabIndex = 138;
            this.chart1.Text = "chart1";
            // 
            // lbl_sign
            // 
            this.lbl_sign.AutoSize = true;
            this.lbl_sign.Location = new System.Drawing.Point(212, 308);
            this.lbl_sign.Name = "lbl_sign";
            this.lbl_sign.Size = new System.Drawing.Size(0, 13);
            this.lbl_sign.TabIndex = 139;
            // 
            // lbl_true_false
            // 
            this.lbl_true_false.AutoSize = true;
            this.lbl_true_false.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_true_false.Location = new System.Drawing.Point(211, 342);
            this.lbl_true_false.Name = "lbl_true_false";
            this.lbl_true_false.Size = new System.Drawing.Size(0, 20);
            this.lbl_true_false.TabIndex = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 397);
            this.Controls.Add(this.lbl_true_false);
            this.Controls.Add(this.lbl_sign);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tb_chi_count);
            this.Controls.Add(this.tb_chi);
            this.Controls.Add(this.tb_variance);
            this.Controls.Add(this.tb_average);
            this.Controls.Add(this.lbl_info5);
            this.Controls.Add(this.lbl_info4);
            this.Controls.Add(this.lbl_info3);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.btn_get_answer);
            this.Controls.Add(this.nud_n);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.nud_prob5);
            this.Controls.Add(this.lbl_prob5);
            this.Controls.Add(this.nud_prob4);
            this.Controls.Add(this.lbl_prob4);
            this.Controls.Add(this.nud_prob3);
            this.Controls.Add(this.lbl_prob3);
            this.Controls.Add(this.nud_prob2);
            this.Controls.Add(this.lbl_prob2);
            this.Controls.Add(this.nud_prob1);
            this.Controls.Add(this.lbl_prob1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.NumericUpDown nud_prob5;
        private System.Windows.Forms.Label lbl_prob5;
        private System.Windows.Forms.NumericUpDown nud_prob4;
        private System.Windows.Forms.Label lbl_prob4;
        private System.Windows.Forms.NumericUpDown nud_prob3;
        private System.Windows.Forms.Label lbl_prob3;
        private System.Windows.Forms.NumericUpDown nud_prob2;
        private System.Windows.Forms.Label lbl_prob2;
        private System.Windows.Forms.NumericUpDown nud_prob1;
        private System.Windows.Forms.Label lbl_prob1;
        private System.Windows.Forms.NumericUpDown nud_n;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Button btn_get_answer;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Label lbl_info5;
        private System.Windows.Forms.Label lbl_info4;
        private System.Windows.Forms.Label lbl_info3;
        private System.Windows.Forms.TextBox tb_average;
        private System.Windows.Forms.TextBox tb_variance;
        private System.Windows.Forms.TextBox tb_chi;
        private System.Windows.Forms.TextBox tb_chi_count;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_sign;
        private System.Windows.Forms.Label lbl_true_false;
    }
}

