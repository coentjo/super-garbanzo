﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestCore
{
	internal interface IWeapon
	{
        public int AttackDamage { get; protected set; }
    }
}