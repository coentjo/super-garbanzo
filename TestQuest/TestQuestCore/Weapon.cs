using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestCore
{
	public class Weapon : IItem, IAttack
	{
		public int AttackDamage { get; protected set; }

        public Weapon(int attackDamage)
        {
            AttackDamage = attackDamage;
        }
    }
}
