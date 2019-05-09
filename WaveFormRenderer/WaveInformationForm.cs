using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaveFormRendererApp.Utils;

namespace WaveFormRendererApp
{
    public partial class WaveInformationForm : Form
    {
        private WaveFormat format;
        public WaveInformationForm()
        {
            InitializeComponent();
        }
        public WaveInformationForm(WaveFormat fr) : this()
        {
            format = fr;
            initInformations();
        }
        private void initInformations()
        {
            String g = new Hadamar(3).MatrixAsString();
            if (format == null)
                return;
            average.Text = format.AverageBytesPerSecond.ToString();
            bitsPer.Text = format.BitsPerSample.ToString();
            blockAlign.Text = format.BlockAlign.ToString();
            channels.Text = format.Channels.ToString();
            encoding.Text = format.Encoding.ToString();
            extraSize.Text = format.ExtraSize.ToString();
            sampleRate.Text = format.SampleRate.ToString();
        }
    }
}
