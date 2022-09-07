using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRaceLibary.Items
{
    public class Carrot : IItem
    {
        public void Equip(Rat rat)
        {
            rat.item = this;
            rat.Position += 2;
        }

        public void Unequip(Rat rat)
        {
            rat.item = null;
            rat.Position -= 2;
        }
    }
}
