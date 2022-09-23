using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Inventory
    {
        public InventorySlot weaponslot;
        public InventorySlot armorslot;
        public InventorySlot bootslot;
        public List<InventorySlot> Slots = new List<InventorySlot>();

        public Inventory()
        {

        }

        public void AddSlot(InventorySlot slot) => Slots.Add(slot);
    }

    public class InventorySlot
    {
        Item StoredItem;
        string Blankimg;
        private PictureBox Picture;
        public string Img;
        public string Type;

        public InventorySlot(string name, string blankimg, PictureBox picturebox)
        {
            Type = name;
            Blankimg = blankimg;
            Img = Blankimg;
            Picture = picturebox;
            using (var img = Image.FromFile(Blankimg))
            {
                picturebox.Image = img;
            }
                
        }

        public void Set(Item item) {
            StoredItem = item; 
            Img = StoredItem.Icon;
            if (Picture.Image != null)
            {
                Picture.Image.Dispose();
                Picture.Image = null;
            }
            using (var img = Image.FromFile(Img))
            {
                Picture.Image = img;
            }
            
        }

        public void takeoff()
        {
            if (Picture.Image != null)
            {
                Picture.Image.Dispose();
                Picture.Image = null;
            }
            using (var img = Image.FromFile(Blankimg))
            {
                Picture.Image = img;
                StoredItem = null;
            }
            
        }

    }
}
