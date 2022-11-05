using RPGGameConsole.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameConsole.Items.Models
{
    public class Item : IItem
    {
        public ItemType Name;
        public string Description { get; set; }
        public int ObjectiveNumber { get; set; }
        public int Weight { get; set; }
        public int GoldValue { get; set; }

    }

    public enum ItemType
    {
        Rope,
        Torch,
        HolySymbol,
        Water,
        Food,
        Tinerbox
    }
}
