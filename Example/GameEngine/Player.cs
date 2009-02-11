namespace Example
{
    public class Player
    {
        
        private IUserArmor armor;
        private readonly IMessenger messenger;
        private readonly ISomethingElse somethingElse;

        public Player(IUserArmor armor, IMessenger messenger, ISomethingElse somethingElse)
        {
            this.armor = armor;
            this.messenger = messenger;
            this.somethingElse = somethingElse;
            this.HitPoints = 100;
            this.Alive = true;
            this.Rage = 0;
        }

        public bool Alive { get; set; }
        public int Rage { get; private set; }
        public int HitPoints { get; private set; }

        public void Damage(DamageType type, int hitPoints)
        {
            messenger.Message("Damange was done");
            HitPoints = HitPoints - armor.CalculateDamage(type, hitPoints);
            Rage++;
        }
    }
}