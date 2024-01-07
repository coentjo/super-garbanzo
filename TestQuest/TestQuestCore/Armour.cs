using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestCore
{
	public class Armour : IItem, IDefence
	{
		protected int defencePoints;

		public Armour(int defencePoints)
		{
			this.defencePoints = defencePoints;
		}

		public int GetDefencePoints()
		{
			return defencePoints;
		}

		public void SetDefencePoints(int defencePoints)
		{
			this.defencePoints = defencePoints;
		}
	}
}
