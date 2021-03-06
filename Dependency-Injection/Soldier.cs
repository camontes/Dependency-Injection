﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class Soldier
    {
        protected IWeapon weapon;
        public Soldier(IWeapon _weapon)
        {
            this.weapon = _weapon;
        }

        public string Shoot()
        {
            return this.weapon.Shoot();
        }
    }
}
