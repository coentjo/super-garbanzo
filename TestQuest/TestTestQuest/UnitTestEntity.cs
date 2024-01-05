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
		public void TestDefenceAttack(int defencePoints, int startHp, int expectedHp) 
		{
			Entity attacker = new();
			Armour defenderArmour = new(defencePoints);
			Entity defender = new(hp: startHp, armour: defenderArmour);

			attacker.Attack(defender);

			Assert.Equal(defender.Hp, expectedHp);
		}
	}
}