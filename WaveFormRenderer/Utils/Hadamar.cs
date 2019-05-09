using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WaveFormRendererApp.Utils
{
    public class Hadamar
    {
        private List<List<int>> level_0 = new List<List<int>>()
                                            { new List<int>() { 1, 1 },
                                              new List<int>() { 1, -1 }
                                            };

        public List<List<int>> currentMatrix { get; set; }

        public int MatrixLevel {
            get
            {
                for (int i = 1; i<currentMatrix.Count; i++)
                {
                    if (Math.Pow(2, i) == currentMatrix.Count)
                        return i;
                }
                return 0;
            }
            private set { }
        }

        public Hadamar BuildHadamar(int level) 
        {
            for (int k = 1; k <= level; k++)
            {
                int count = (int)Math.Pow(2, k + 1);
                List<List<int>> newMatrix = new List<List<int>>();
                for (int i = 0; i < count; i++)
                {
                    newMatrix.Add(new List<int>(new int[count]));
                }
                build(newMatrix, currentMatrix, k, 0, 0);
                build(newMatrix, currentMatrix, k, 0, (int)Math.Pow(2,k));
                build(newMatrix, currentMatrix, k, (int)Math.Pow(2, k), 0);
                build(newMatrix, currentMatrix.Select(x => x.Select(y => -y).ToList()).ToList(), k, (int)Math.Pow(2, k), (int)Math.Pow(2, k));
                currentMatrix = newMatrix;
            }
            return this;
        }

        private void build(List<List<int>> newMatrix, List<List<int>> cur, int level, int i, int j)
        {
            int count = (int)Math.Pow(2, level);
            for (int q = 0; q < count; q++)
            {
                for (int w = 0; w < count; w++)
                {
                    newMatrix[i + q][j + w] = cur[q][w];
                }
            }
        }

        public Hadamar()
        {
            currentMatrix = level_0;
        }
        public Hadamar(int level) : this()
        {
            BuildHadamar(level);
        }
        public string MatrixAsString()
        {
            String g = "";
            foreach ( var i in currentMatrix)
            {
                foreach ( var j in i)
                {
                    g += j.ToString() + "\t";
                }
                g += "\n";
            }
            return g;
        }

    }
}
