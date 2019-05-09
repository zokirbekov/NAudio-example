using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaveFormRendererLib
{
    public class Frame
    {
        public List<float> buffer { get; set; }
        public Frame(List<float> buffer)
        {
            this.buffer = buffer;
        }

        public int Count {
            get
            {
                return buffer.Count();
            }
        }
    }
}
