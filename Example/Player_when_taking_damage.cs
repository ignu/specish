using Specish;
using NUnit.Framework;

namespace Example
{
    [TestFixture]
    public class Player_when_taking_damage : base_automock_test
    {
        Player player;
        private int returnedDamage = 33;

        protected override void establish_context()
        {                        
            Mock<IUserArmor>()
                .Expect(u => u.CalculateDamage(DamageType.Piercing, 50))
                .Returns(returnedDamage);

            player = Create<Player>();
        }

        protected override void because()
        {            
            player.Damage(DamageType.Piercing, 50);
        }

        [Test]
        public void damage_minus_armor_buffer_is_subtracted_from_hitpoints()
        {
            player.HitPoints.ShouldEqual(100 - returnedDamage);
        }
 
        [Test]
        public void rage_is_increased_by_one()
        {
            player.Rage.ShouldEqual(1);            
        }

        [Test]
        public void message_is_sent_to_user()
        {
            Mock<IMessenger>()
                .Verify(e => e.Message("Damange was done."));
        }
        
    }
}