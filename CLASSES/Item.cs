using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurichev_Lab3.CLASSES
{
    public class Item
    {
        private string ItemCategory;
        private string ItemName;
        private bool ItemAvailability;
        private int ItemPrice;
        private double ItemRating;

        // Геттер-сеттеры

        [DisplayName("Категория")]
        public string itemCategory
        {
            get { return ItemCategory; }
            set { ItemCategory = value; }
        }

        [DisplayName("Товар")]
        public string itemname
        {
            get { return ItemName; }
            set { ItemName = value; }
        }

        [DisplayName("Наличие")]
        public bool itemAvailability
        {
            get { return ItemAvailability; }
            set { ItemAvailability = value; }
        }

        [DisplayName("Цена")]
        public int itemPrice
        {
            get { return ItemPrice; }
            set { ItemPrice = value; }
        }

        [DisplayName("Рейтинг")]
        public double itemRating
        {
            get { return ItemRating; }
            set { ItemRating = value; }
        }

        // Конструктор
        public Item (string InputItemCategory, string InputItemName, bool InputItemAvailability, int InputItemPrice, double InputItemRating)
        {
            ItemCategory = InputItemCategory;
            ItemName = InputItemName;
            ItemAvailability = InputItemAvailability;
            ItemPrice = InputItemPrice;
            ItemRating = InputItemRating;
        }

        // Конуструктор без параметров
        public Item() : this("TempCategory", "TempName", true, 15000, 3.2)
        {
            ;
        }
    }
}
