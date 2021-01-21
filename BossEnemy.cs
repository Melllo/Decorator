using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BossEnemy : EnemyDecorator
    {
        public BossEnemy(IEnemy enemy) : base(enemy)
        {
        }
        public override string attack()
        {
            return base.attack() + hardAttack();
        }

        public string hardAttack()
        {
            return "\nHard Attack";
        }

    }
}
