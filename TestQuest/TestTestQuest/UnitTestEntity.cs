using TestQuestCore;

namespace TestTestQuest
{
	public class UnitTestEntity
	{
		/// <summary>
		/// A simple attack without weapons or armour
		/// </summary>
		[Theory]
		[InlineData(10, 8)]
		public void TestSimpleAttack(int StartHp, int expectedHp)
		{
			Entity attacker = new();
			Entity defender = new(hp: StartHp);

			attacker.Attack(defender);

			Assert.Equal(defender.Hp, expectedHp);
		}

		[Theory]
		[InlineData(1, 10, 9)]
		[InlineData(3, 10, 10)]
		public void TestDefenceAttack(int defencePoints, int startHp, int expectedHp) 
		{
			Entity attacker = new();
			Armour defenderArmour = new(defencePoints);
			Entity defender = new(hp: startHp, armour: defenderArmour);

			attacker.Attack(defender);

			Assert.Equal(expectedHp, defender.Hp);
		}

		[Theory]
		[InlineData(5, 10, 5)]
		[InlineData(0, 10, 10)]
		public void TestAugmentedAttack(int attackPoints, int startHp, int expectedHp)
		{
			Weapon attackerWeapon = new(attackPoints);
			Entity attacker = new(weapon: attackerWeapon);
			Entity defender = new(hp: startHp);

			attacker.Attack(defender);

			Assert.Equal(expectedHp, defender.Hp);
		}

		[Fact]
		public void TestAttackDeath() 
		{
			Entity attacker = new();
			Entity defender = new(hp: 1);

			attacker.Attack(defender);

			Assert.Equal(EntityStatus.DEAD, defender.Status);
		}
	}
}