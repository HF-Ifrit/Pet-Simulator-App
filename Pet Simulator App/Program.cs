using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Simulator_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }

    public class Pet
    {
        public class Stats
        {
            private int maxHp;
            private int hp;
            private int attack;
            private int defense;

            public Stats()
            {
                maxHp = 10;
                hp = maxHp;
                attack = 5;
                defense = 5;
            }

            public Stats(int maxhealth, int att, int def)
            {
                maxHp = maxhealth;
                hp = maxHp;
                attack = att;
                defense = def;
            }

            //Stat getter-setters
            public int getMaxHealth()
            {
                return maxHp;
            }

            public void setMaxHp(int newMax)
            {
                maxHp = newMax;
            }

            public int getHealth()
            {
                return hp;
            }

            public void setHp(int newHp)
            {
                hp = newHp;
            }

            public int getAttack()
            {
                return attack;
            }

            public void setAttack(int newAtt)
            {
                attack = newAtt;
            }

            public int getDefense()
            {
                return defense;
            }

            public void setDefense(int newDef)
            {
                defense = newDef;
            }
        }

        private String name;
        private LinkedList<Item> inventory;
        private Stats petStats;

        //Pet constructors
        public Pet(String petName)
        {
            name = petName;
            petStats = new Stats();
        }

        public Pet(String petName, int petHp, int petAtt, int petDef)
        {
            name = petName;
            petStats = new Stats(petHp, petAtt, petDef);
        }

        public String getName()
        {
            return name;
        }

        public LinkedList<Item> getInventory()
        {
            return inventory;
        }

        public Stats getStats()
        {
            return petStats;
        }

        public String getStatSummary()
        {
            return "Name: " + getName() + "\nHealth: " + petStats.getMaxHealth() +
                    "/" + petStats.getHealth() + "\nAttack: " + petStats.getAttack() + "\nDefense: "
                    + petStats.getDefense();
        }
    }
    
    public class Item
    {

    }
}
