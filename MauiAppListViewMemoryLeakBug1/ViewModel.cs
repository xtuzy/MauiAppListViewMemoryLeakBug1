using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppListViewMemoryLeakBug1
{
    internal class ViewModel
    {
        public List<Model> list { set; get; }

        public ViewModel()
        {
            list = new List<Model>();
            for (int i = 0; i < 500; i++)
            {
                list.Add(new Model() { Text = i.ToString(), Detail = i.ToString() });
            }
        }
    }
}
