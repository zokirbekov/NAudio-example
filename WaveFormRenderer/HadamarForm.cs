using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaveFormRendererApp.Utils;
using WaveFormRendererLib;

namespace WaveFormRendererApp
{
    public partial class HadamarForm : Form
    {
        Hadamar hadamar = new Hadamar(7);
        List<Frame> data;
        List<List<float>> C;
        public HadamarForm()
        {
            InitializeComponent();
        }
        public HadamarForm(List<Frame> data)
        {
            InitializeComponent();
            hadamar.currentMatrix.ToDataGridView(dataGridViewHadamar);
            data.AsEnumerable().toDataGridView(dataGridViewF);
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
            this.data = data;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            C.ToDataGridView(dataGridViewMul);
            buttonSpectro.Enabled = true;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }


        private List<List<float>> calc()
        {
            List<List<float>> c = new List<List<float>>();
            double progress = 0;
            double progressStep = 100.0 / data.Count;
            for (int i=0;i<data.Count; i++)
            {
                c.Add(hadamar.currentMatrix.MultWithDiv(data[i].buffer.AsEnumerable()).ToList());
                progress += progressStep;
                backgroundWorker1.ReportProgress((int)Math.Floor(progress));
            }
            return c;
        }

        private void paintToChart(List<float> c)
        {
            chart1.Series[0].Points.Clear();
            var height = chart1.Height;
            var width = chart1.Width - 100;
            var xStep = width / c.Count;
            float x = xStep - 5;

            for (int i=0;i < c.Count; i++)
            {
                chart1.Series[0].Points.AddXY(x, c[i]);
                x += xStep;
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            C = calc();
        }

        private void dataGridViewMul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            paintToChart(C[e.RowIndex]);   
        }

        private void buttonSpectro_Click(object sender, EventArgs e)
        {
            new SpectrogramForm(C).Show();
        }
    }
}
