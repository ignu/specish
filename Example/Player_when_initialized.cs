using Specish;
using NUnit.Framework;

namespace Example
{
    [TestFixture]
    public class Player_when_initialized : base_automock_test
    {
        private Player player;
        
        protected override void because()
        {
            player = Create<Player>();
        }

        [Test]
        public void is_alive()
        {
            player.Alive.ShouldBeTrue();
        }

        [Test]
        public void has_100_hitpoints()
        {
            player.HitPoints.ShouldEqual(100);
        }
    }
}