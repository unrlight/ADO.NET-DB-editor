using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurichev_Lab3
{
    public class TxtToList
    {
        private string DataLocationPath = @"C:\Users\root\source\repos\Kurichev_Lab3\shopdata.txt";
        private BindingList<Kurichev_Lab3.CLASSES.Item> ItemList;

        public TxtToList() // Заполнение списка
        {
            ItemList = new BindingList<Kurichev_Lab3.CLASSES.Item>();

            foreach (var line in File.ReadAllLines(DataLocationPath))
            {
                var columns = line.Split(';');
                ItemList.Add(new CLASSES.Item(Convert.ToString(columns[0]), Convert.ToString(columns[1]),
                    Convert.ToBoolean(columns[2]), Convert.ToInt32(columns[3]), Convert.ToDouble(columns[4])));
            }
        }

        public BindingList<Kurichev_Lab3.CLASSES.Item> itemList // Геттер-сеттер для списка
        {
            get { return ItemList; }
            set { ItemList = value; }
        }
    }
}
