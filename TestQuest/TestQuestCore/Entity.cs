using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestCore
{
	public class Entity
	{
        public int Hp { get; private set; }
		public int AttackDamage { get { return weapon.AttackDamage; } }
        public EntityStatus Status { get; private set; }

        public int DefencePoints
		{
			get
			{ 
				return armour.GetDefencePoints(); 
			}
		}

		protected Weapon weapon;
		protected Armour armour;

		public Entity(int hp = 10, Weapon? weapon = null, Armour? armour = null)
		{
			this.Hp = hp;
			this.weapon = weapon ?? new NoWeapon();
			this.armour = armour ?? new NoArmour();
		}

		public void Attack(Entity target)
		{
			int attackDamage = this.AttackDamage;
			target.Defend(attackDamage);
		}

		public void Defend(int attackDamage)
		{
			if (attackDamage > this.DefencePoints)
			{
				this.Hp -= (attackDamage - this.DefencePoints);
			}

			if (this.Hp <= 0)
			{
				this.Status = EntityStatus.DEAD;
			}
		}
	}

	public enum EntityStatus
	{
		ALIVE,
		DEAD
	}
}
