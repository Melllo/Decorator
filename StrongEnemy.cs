using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class StrongEnemy : EnemyDecorator
    {
        public StrongEnemy(IEnemy enemy):base(enemy) { 
        }
        
        public override string attack()
        {
            return base.attack() + battleCry();
        }

        public string battleCry() {
            return "\nBattlecry";
        }
    }
}
