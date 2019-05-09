using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaveFormRendererLib;

namespace WaveFormRendererApp.Utils
{
    public static class DataGridViewExtension
    {
        public static void ToDataGridView<T>(this List<List<T>> data, DataGridView grid)
        {
            grid.Columns.Clear();

            for (int i = 0; i < data.ElementAt(0).Count(); i++)
            {
                grid.Columns.Add(i.ToString(), i.ToString());
            }

            grid.Rows.Add(data.Count());

            for (int j = 0; j < data.ElementAt(0).Count(); j++)
            {
                for (int i = 0; i < data.Count(); i++)
                {
                    grid[j, i].Value = data.ElementAt(i).ElementAt(j);
                }
            }
        }
        public static void toDataGridView(this IEnumerable<Frame> values, DataGridView gridView)
        {
            for (int i = 0; i < values.ElementAt(0).Count; i++)
            {
                gridView.Columns.Add(i.ToString(), (i + 1).ToString());
            }
            gridView.Rows.Add(values.Count());
            for (int i = 0; i < values.ElementAt(0).Count; i++)
            {
                for (int j = 0; j < values.Count(); j++)
                {
                    gridView[i, j].Value = values.ElementAt(j).buffer[i];
                }
            }
        }
    }
}
