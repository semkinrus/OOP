using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5OOP
{
    //Описание интерфейса "Бойца"
    interface IWarrior
    {
        void Attack(Enemy enemuy, Item Pweapon,Item Wweapon, Creature creature);
    }
}
