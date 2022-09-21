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
    public partial class Form1 : Form
    {
        public Cat selectedcat;

        public Form1()
        {
            InitializeComponent();
            new Cat("Neco Arc", 100, @"C:/Users/mi/source/repos/WindowsFormsApp1/necoarc.jpg", @"C:/Users/mi/source/repos/WindowsFormsApp1/neco-arc-sound-effect.wav");
            new Cat("Neco Arc Chaos", 100, @"C:/Users/mi/source/repos/WindowsFormsApp1/nekoarcchaos.jpg", @"C:/Users/mi/source/repos/WindowsFormsApp1/doridori.wav"); 
            foreach (var i in Cat.CatLs)
                listView1.Items.Add(i.ToString());
        }


        public void Log(string text)
        {
            richTextBox1.AppendText(text + "\n");
        }

        public Cat GetCat(string str) => Cat.CatLs.Find(x => x.Name == str);

        public void UpdatePenis()
        {
            if (selectedcat != null)
            {
                textBox1.Text = $"{selectedcat.Hunger}%";
                textBox2.Text = $"{selectedcat.Energy}%";
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                pictureBox1.Image = Image.FromFile(selectedcat.Sprite);


            }
            
        }

        public void Notify()
        {
            var items = listView1.Items;

            for (int i = 0; i < items.Count; i++)
            {
                Cat cat = GetCat(items[i].Text);
                if (cat.IsDead)
                {
                    listView1.Items.RemoveAt(i);
                    MessageBox.Show($"{cat.Name} ПОГИБ!!!");
                }
                if (cat.IsStarving)
                    Log($"{cat.Name} Голодает!!!");
                if (cat.IsOverfed)
                    Log($"{cat.Name} Перекормлен!!!");
                if (cat.IsOverMeowed)
                    Log($"{cat.Name} Замеукан!!!");

            }
        }

        public void GetHungryAll()
        {
            foreach (var i in Cat.CatLs)
                i.GetHungry(10);
        }

        public void RestAll()
        {
            foreach (var i in Cat.CatLs)
                i.Rest();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            selectedcat = Cat.CatLs.Find(x => x.Name == listView1.SelectedItems[0].Text);
            UpdatePenis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedcat.Feed(10);
            UpdatePenis();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = selectedcat.Meowsound;
            player.Play();
            if (selectedcat != null)
                selectedcat.Meow(20);
            UpdatePenis();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cat.CheckStatus();
            Notify();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RestAll();
            GetHungryAll();
            Cat.UpdateStatus();
            UpdatePenis();
        }
    }
}
