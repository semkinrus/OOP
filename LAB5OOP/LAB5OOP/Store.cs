using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5OOP
{
    public partial class Store : Form
    {
        Creature Stores = new Creature(100000);
        Creature Person = new Creature();
        public Store(string name, int health, int money, string inventory)
        {
            InitializeComponent();
            Person.Chealth = health;
            Person.Cmoney = money;
            Person.Cinventory = inventory;
            label4.Text = Person.Chealth + "%";
            label6.Text = Person.Cmoney + " ЗОЛОТЫХ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main MainOpen = new Main(Person.Cname, Person.Chealth, Person.Cmoney, Person.Cinventory);
            MainOpen.Show();
            this.Close();
        }

        
        Item Water = new Item("Живая вода", 250, 0, 0, false);
        Item Armor = new Item("Броня", 500, 15, 0, false);
        Item Horse = new Item("Лошадь", 600, 0, 0, false);

        private void button1_Click(object sender, EventArgs e)
        {
            if (Person.Cmoney >= 350)
            {
                Stores.give(Person, Water);
                int needed = 100 - Person.Chealth;
                Person.Chealth += needed;
                label4.Text = Person.Chealth + "%";
                label6.Text = Person.Cmoney + " ЗОЛОТЫХ";
                textBox2.Text += Environment.NewLine + "Живая вода (до 100% здоровье) — 250 золотых.";
                
            }
            else
                MessageBox.Show("Недостаточно средств.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Person.Cmoney >= 500)
            {
                Stores.give(Person, Armor);
                Person.Chealth += 150;
                label4.Text = Person.Chealth + "%";
                label6.Text = Person.Cmoney + " ЗОЛОТЫХ";
                textBox2.Text += Environment.NewLine + "Броня (+ 150 к здоровью, +15 к весу) — 500 золотых.";
            }
            else
                MessageBox.Show("Недостаточно средств.");
        }
    }
    
}
