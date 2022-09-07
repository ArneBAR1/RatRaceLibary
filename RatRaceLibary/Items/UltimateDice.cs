using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRaceLibary.Items
{
    public class UltimateDice : IItem
    {
        public void Equip(Rat rat)
        {
            rat.item = this;
            rat.SpacesMoved = RNG.Range(4, 9);
        }

        public void Unequip(Rat rat)
        {
            rat.item = null;
            rat.SpacesMoved = RNG.Range(4, 9);
        }
    }
}
