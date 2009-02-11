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
            Assert.Ignore("Need To Test");
        }
    }
}