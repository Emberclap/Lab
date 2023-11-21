using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DoesDummy_TakeDmg_WhenAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(1);

            Assert.That(dummy.Health, Is.EqualTo(9), "Dummy health doesn't change after attack.");
            
        }
        [Test]
        public void DoDeadDummy_ThrowsExeption_IfAttackedAfterDead()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(2));

        }
        [Test]
        public void WhetherDeadDummy_CanGive_XP()
        {
            Dummy dummy = new Dummy(0, 10);
            
            Assert.NotZero(dummy.GiveExperience());

        }
        [Test]
        public void WhetherAliveDummy_CantGive_XP()
        {
            Dummy dummy = new Dummy(5, 10);
            
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

        }
        
    }
}