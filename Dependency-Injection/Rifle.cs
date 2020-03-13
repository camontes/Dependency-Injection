using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class Rifle: IWeapon
    {
        public string Shoot()
        {
            return "Shoot Rifle";
        }
    }
}
