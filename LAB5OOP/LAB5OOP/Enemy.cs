using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5OOP
{
    //Класс, который принмает данные о враге
    class Enemy:Creature
    {
        //Сумма денег, которая "выпадает" из врага при убийстве
        public int EkillM;
        //Конструктор
        public Enemy(string Cname, int Chealth, int Ctonnage, int Cmoney, string Cinventory, int EkillM) : base(Cname, Chealth, Ctonnage, Cmoney, Cinventory)
        {

            this.EkillM = EkillM;
        }
    }
}
