using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestCore
{
	internal class Entity
	{
        public int Hp { get; private set; }

		protected Weapon? weapon;
		protected Armour? armour;

		protected Entity(int hp = 10, Weapon? weapon = null, Armour? armour = null)
		{
			this.Hp = hp;
			this.weapon = weapon;
			this.armour = armour;
		}
    }
}
