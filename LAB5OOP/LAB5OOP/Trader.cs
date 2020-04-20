using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5OOP
{
    //Описание интерфейса "Торговца"(магазин)
    interface ITrader
    {
        void give(Creature trader, Item item);
        void take(Creature trader, Item item);

    }
}
