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
		public int AttackDamage 
		{ get 
			{
				return weapon?.AttackDamage ?? 2; 
			} 
		}

		protected Weapon? weapon;
		protected Armour? armour;

		public Entity(int hp = 10, Weapon? weapon = null, Armour? armour = null)
		{
			this.Hp = hp;
			this.weapon = weapon;
			this.armour = armour;
		}

		public void Attack(Entity target)
		{
			int attackDamage = this.AttackDamage;
			target.Defend(attackDamage);
		}

		public void Defend(int attackDamage)
		{
			this.Hp -= attackDamage;
		}
    }
}
