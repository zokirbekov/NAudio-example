using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaveFormRendererLib;

namespace WaveFormRendererApp
{
    public partial class FiltrForm : Form
    {

        private List<Frame> frames;
        private List<Frame> filtredFrames;
        private const int K = 16;

        public FiltrForm()
        {
            InitializeComponent();
        }
        public FiltrForm(List<Frame> frames)
        {
            InitializeComponent();
            this.frames = frames;
            backgroundWorker1.RunWorkerAsync();
            FormClosed += FiltrForm_FormClosed;
        }

        private void FiltrForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }

        private void toDataGridView(IEnumerable<Frame> values, DataGridView gridView)
        {
            for (int i=0; i < values.ElementAt(0).Count; i++)
            {
                gridView.Columns.Add(i.ToString(), (i + 1).ToString());
            }
            gridView.Rows.Add(values.Count());
            for (int i = 0; i < values.ElementAt(0).Count; i++)
            {
                for (int j = 0; j< values.Count(); j++)
                {
                    gridView[i, j].Value = values.ElementAt(j).buffer[i];
                }
            }
        }

        private IEnumerable<Frame> filtr()
        {
            List<Frame> afterFiltr = new List<Frame>();
            double progress = 0;
            double progressStep = 100.0 / frames.Count;
            foreach (var i in frames)
            {
                Frame frame = new Frame(new List<float>());
                IEnumerable<float> val = i.buffer;
                int takedElement = 1;
                int skipedElement = 0;

                while (val.Count() > 0)
                {
                    frame.buffer.Add(val.Take(takedElement).Sum() / takedElement);
                    if (val.Count() > 16)
                    {
                        if (takedElement == 16)
                            skipedElement = 1;
                        else
                            takedElement++;
                    }
                    else
                    {
                        takedElement--;
                    }
                    val = val.Skip(skipedElement);
                }
                afterFiltr.Add(frame);
                progress += progressStep;
                backgroundWorker1.ReportProgress((int)Math.Floor(progress));
            }
            return afterFiltr;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            filtredFrames = filtr().ToList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toDataGridView(frames, dataGridViewOriginal);
            toDataGridView(filtredFrames, dataGridViewAfterFilter);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            
        }
    }
}
