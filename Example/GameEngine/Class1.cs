using System;
using System.Collections.Generic;

namespace Example
{
    public interface IUserArmor
    {
        int CalculateDamage(DamageType type, int HitPoints);
        IList<Armor> ArmorItems { get; set;}
    }

    public class Player
    {
        
        private IUserArmor armor;
        private readonly ISomethingElse somethingElse;

        public Player(IUserArmor armor, ISomething something, ISomethingElse somethingElse)
        {
            this.armor = armor;
            this.somethingElse = somethingElse;
            this.HitPoints = 100;
            this.Alive = true;
        }

        public bool Alive { get; set; }
        public int Rage { get; private set; }
        public int HitPoints { get; private set; }

        public void Damage(DamageType type, int hitPoints)
        {
            throw new NotImplementedException();
        }
    }
}
