﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestCore
{
	internal class NoWeapon : Weapon
	{


		public NoWeapon():
			base(attackDamage: 2) 
		{ 
		}
	}
}
