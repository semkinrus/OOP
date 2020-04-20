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
{   //Класс, используемый при бое
    public partial class Battle : Form
    {
        //Создание экземпляров героев
        Enemy warrior = new Enemy("Windranger",100,100,650,"",500);
        Creature Person = new Creature();
        
        //Создание экземпляров предметов(оружия)
        Item Wweapon = new Item("Лук", 0, 0, 0, true);
        Item Pweapon = new Item("Магия", 0, 0, 0, true);
      
        public Battle()
        {
            InitializeComponent();
        }

        //Конструктор, в котором определяются значения и выводятся в форму
        public Battle(string name, int health, int money, string inventory)
        {
            InitializeComponent();
            Person.Cname = name;
            Person.Chealth = health;
            Person.Cmoney = money;
            Person.Cinventory = inventory;
            label3.Text = Person.Cname;
            warrior.Chealth = 100;
           //Задание свойств преметам(оружию)
            Random r = new Random();
            Pweapon.Icost = r.Next(100, 300);
            Pweapon.Idamage = r.Next(2, 15);
            Pweapon.Iweight = r.Next(2, 10);
            Wweapon.Icost = r.Next(100, 300);
            Wweapon.Idamage = r.Next(2, 15);
            Wweapon.Iweight = r.Next(2, 10);
            goto Show;
        
        Show:
            {
                label4.Text = Person.Chealth + "%";
                label6.Text = warrior.Chealth + "%";
                label8.Text = Pweapon.Iname + ", урон: " + Pweapon.Idamage;
                label10.Text = Wweapon.Iname + ", урон: " + Wweapon.Idamage;
            }
        }
        //Описание поведения кнопки "НАЗАД" (при нажатии возвращает на главный экран)
        private void button2_Click(object sender, EventArgs e)
        {
            Main MainOpen = new Main(Person.Cname, Person.Chealth, Person.Cmoney, Person.Cinventory);
            MainOpen.Show();
            this.Close();
        }
        //Описание поведения кнопки "АТАКА"
        private void button1_Click(object sender, EventArgs e)
        {
            if (warrior.Chealth<=0)
            {
                MessageBox.Show("Поздравляем! Вы победили.");
            }
            else Person.Attack(warrior, Pweapon, Wweapon, Person);
            if (Person.Chealth <=0)
            {
                MessageBox.Show("Вы проиграли.");
            }    
            
            goto Show;
        Show:
            {
                
                label4.Text = Person.Chealth + "%";
                label6.Text = warrior.Chealth + "%";
                label8.Text = Pweapon.Iname + ", урон: " + Pweapon.Idamage;
                label10.Text = Wweapon.Iname + ", урон: " + Wweapon.Idamage;
            }
        }
    }
}
