using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestCore
{
	public interface IAttack
	{
		// Possible fix: turn propery into get and set methods
		public abstract int AttackDamage { get; }
    }
}
