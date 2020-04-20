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
    public partial class Main : Form
    {
        //Создание экземпляра персонажа
        Creature Person = new Creature();

        public Main()
        {
            InitializeComponent();
        }
        //Конструктор
        public Main(string name,int health,int money,string inventory)
        {
            InitializeComponent();
            Person.Cname = name;
            Person.Chealth = health;
            Person.Cmoney = money;
            Person.Cinventory = inventory;
            label1.Text = Person.Cname;
            label4.Text = Person.Chealth + "%";
            label6.Text = Person.Cmoney + " ЗОЛОТЫХ";
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        //Описание поведения кнопки "БОЙ"
        private void battle_Click(object sender, EventArgs e)
        {
            if (Person.Chealth > 0)
            {
                Battle BattleOpen = new Battle(Person.Cname, Person.Chealth, Person.Cmoney, Person.Cinventory);
                BattleOpen.Show();
                this.Close();
            }
            else
                MessageBox.Show("У вас слишком мало здоровья.");
        }
        //Описание поведения кнопки "МАГАЗИН"
        private void store_Click(object sender, EventArgs e)
        {
            Store StoreOpen = new Store(Person.Cname, Person.Chealth, Person.Cmoney, Person.Cinventory);
            StoreOpen.Show();
            this.Close();
        }

    }
}
