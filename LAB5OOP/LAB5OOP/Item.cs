using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5OOP
{
    //Класс, описывающий любой предмет
    class Item: IWeapon
    {
        public string Iname;
        public int Icost;
        public int Iweight;
        public int Idamage;
        public bool isweapon;

        //Конструктор
        public Item(string Iname, int Icost, int Iweight,int Idamage, bool isweapon)
        {
            this.Iname = Iname;
            this.Icost = Icost;
            this.Iweight = Iweight;           
            this.Idamage = Idamage;
            this.isweapon = isweapon;
        }
        //Метод, при вызове которого наносится урон
        public int DoDamage()
        {
            if (isweapon == true)
            {
                return Idamage;
            }
            else return 0;
        }
    }
}
