using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5OOP
{
    //Класс, описывающий персонажа(существо)
    class Creature: IWarrior, ITrader
    {
        public string Cname;
        public int Chealth;
        public int Ctonnage;
        public int Cmoney;
        public string Cinventory;

        //Конструктор
        public Creature (string Cname, int Chealth, int Ctonnage, int Cmoney, string Cinventory)
        {
            this.Cname = Cname;
            this.Chealth = Chealth;
            this.Ctonnage = Ctonnage;
            this.Cmoney = Cmoney;
            this.Cinventory = Cinventory;
        }
        //Конструктор по умолчанию
        public Creature()
        {
            
        }
        //конструктор, принимающий только сумму денег
        public Creature(int Cmoney)
        {
            this.Cmoney = Cmoney;
        }
        public Creature(int Chealth, int Ctonnage, int Cmoney, string Cinventory)
        {
            
            this.Chealth = Chealth;
            this.Ctonnage = Ctonnage;
            this.Cmoney = Cmoney;
            this.Cinventory = Cinventory;
        }

        //Реализация интерфейса Trader

        //Отдать
        public void give(Creature trader, Item item)
        {
            trader.Cmoney -= item.Icost;
            trader.Cinventory += "Sword ";
        }


        //Взять
        public void take(Creature trader, Item item)
        {
            trader.Cmoney += item.Icost;
            string[] a = trader.Cinventory.Split(' ');
            trader.Cinventory = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == "Sword")
                {
                    a[i] = "";
                    break;
                }
                else
                {
                    trader.Cinventory += a[i];
                }
            }
        }
        //End of "Реализация интерфейса Trader"

        //Метод, вызываемый при атаке
        public void Attack(Enemy enemy, Item weapon, Item Wweapon, Creature creature)
        {
            enemy.Chealth -= weapon.Idamage;
            creature.Chealth -= Wweapon.Idamage;
            if (enemy.Chealth <= 0)
            {
                creature.Cmoney += enemy.EkillM;
            }
        }
    }




}
