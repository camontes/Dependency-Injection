using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class Gun: IWeapon
    {
        public string Shoot()
        {
            return "Shoot Gun";
        }
    }
}
