using System;
using System.Collections.Generic;

namespace Example
{
    public interface IUserArmor
    {
        int CalculateDamage(DamageType type, int HitPoints);
        IList<Armor> ArmorItems { get; set;}
    }
}

