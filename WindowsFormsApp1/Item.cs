using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Item
    {
        public string Name;
        public string Icon;
        public string Type;
        public static List<Item> ItemsList = new List<Item>(); 

        Item(string name, string icon, string type)
        {
            Name = name;
            Icon = icon;
            Type = type;
            ItemsList.Add(this);
        }

        static Item()
        {
            new Item("Desolator", @"C:/Users/mi/source/repos/WindowsFormsApp1/desoicon.jpg", "weapon");
            new Item("Assault Cuirass", @"C:/Users/mi/source/repos/WindowsFormsApp1/acicon.png", "armor");
            new Item("Power Treads", @"C:/Users/mi/source/repos/WindowsFormsApp1/powertreadsicon.png", "boots");
        }

        public static Item Get(string name) => ItemsList.Find(x => x.Name == name);

    }
}
