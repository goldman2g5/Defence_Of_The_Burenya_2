using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InventoryForm : Form
    {
        public Item selectedItem;

        public Inventory inventory;

        public InventoryForm()
        {
            InitializeComponent();
            UpdateItemList();
            inventory = new Inventory();
        }

        public void UpdateItemList()
        {
            foreach (var i in Item.ItemsList)
            {
                listBox1.Items.Add(i.Name);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null) 
            {
                label1.Text = listBox1.SelectedItem.ToString();
                selectedItem = Item.Get(listBox1.SelectedItem.ToString());
            }
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selectedItem != null)
            {

                inventory.Slots.Find(x => x.Type == selectedItem.Type).Set(selectedItem);
            }
            
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            if (!inventory.Slots.Any()) 
            {
                inventory.AddSlot(new InventorySlot("weapon", @"C:/Users/mi/source/repos/WindowsFormsApp1/weaponsloticon.png", pictureBox1));
                inventory.AddSlot(new InventorySlot("armor", @"C:/Users/mi/source/repos/WindowsFormsApp1/armoricon.png", pictureBox2));
                inventory.AddSlot(new InventorySlot("boots", @"C:/Users/mi/source/repos/WindowsFormsApp1/booticon.jpg", pictureBox3));
            }

        }
    }
}
