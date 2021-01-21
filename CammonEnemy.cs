using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CammonEnemy : IEnemy
    {
        public override string attack()
        {
            return "\nLight attack";
        }
    }
}
