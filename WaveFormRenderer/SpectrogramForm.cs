using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaveFormRendererApp
{
    public partial class SpectrogramForm : Form
    {
        List<List<float>> data;
        public SpectrogramForm()
        {
            InitializeComponent();
        }
        public SpectrogramForm(List<List<float>> data)
        {
            InitializeComponent();
            this.data = data;
            drawSpectrogram();
        }
        private void drawSpectrogram()
        {
            int red = Color.Red.R;
            int width = pictureBox1.Width;
            int height = data[0].Count;

            Bitmap bitmap = new Bitmap(width, height);
            var q = data.Select(w=> w.Select(y => Math.Abs(y)));//.Max().Max();
            float max = q.Max(w => w.Max());
            float koef = red / max;
            float xStep = width / data.Count;
            float x = 0;
            using (var graph = Graphics.FromImage(bitmap))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    for (int j = 0; j < data[i].Count; j++)
                    {
                        int color = (int)Math.Abs(koef * data[i][j]);
                        graph.DrawRectangle(new Pen(Color.FromArgb(color, 0, 0)), x, j, x + xStep, 1);
                        //bitmap.SetPixel(i, j, Color.FromArgb((int)Math.Abs(koef * data[i][j]), 0, 0));
                    }
                    x += xStep;
                }
            }
            pictureBox1.Height = height;
            pictureBox1.Image = bitmap;
        }
        private float maxData()
        {
            float max = 0;
            return max;
        }
    }
}
