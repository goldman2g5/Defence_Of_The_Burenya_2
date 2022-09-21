using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cat
    {
        public string Name;
        public int Hunger;
        private int Weight;
        public int Energy = 100;
        public string Sprite;
        public string Meowsound;
        public bool IsOverfed = false;
        public bool IsOverMeowed = false;
        public bool IsStarving = false;
        public bool IsDead = false;
        public int DaysToDie = 0;
        public static List<Cat> CatLs = new List<Cat>();


        public Cat(string name, int weight, string sprite, string meowsound)
        {
            Name = name;
            Hunger = 50;
            Sprite = sprite;
            Meowsound = meowsound;
            
            CatLs.Add(this);
        }

        public static void UpdateStatus()
        {

            foreach (var i in CatLs.Where(x => !x.IsDead))
            {
                i.IsStarving = i.Hunger < 0;
                i.IsOverfed = i.Hunger > 100;
                i.IsOverMeowed = i.Energy < 0;
            }

        }

        public static void CheckStatus()
        {

            foreach(var i in CatLs.Where(x => !x.IsDead))
            {

                if (i.IsOverMeowed | i.IsOverfed | i.IsStarving)
                    i.DaysToDie++;
                else
                    i.DaysToDie = 0;

                if (i.DaysToDie >= 5)
                    i.IsDead = true;
            }

        }

        public void Feed(int ammount) => Hunger += ammount;

        public void Rest() => Energy = Energy + 1 > 100 ? Energy : Energy + 1;

        public void GetHungry(int ammount) => Hunger--;

        public void Meow(int ammount) => Energy -= ammount;
             


        public override string ToString()
        {
            return this.Name;
        }
    }
}
