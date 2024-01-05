using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestCore
{
	public class Armour : IItem, IDefence
	{
		int IDefence.DefencePoints
		{
			get 
			{ 
				throw new NotImplementedException(); 
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public Armour(int defencePoints)
		{
			((IDefence)this).DefencePoints = defencePoints;
		}
	}
}
