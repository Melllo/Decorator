using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
     abstract class EnemyDecorator : IEnemy
    {
        IEnemy enemy;

        public EnemyDecorator(IEnemy enemy) {
            this.enemy = enemy;
        }
        public override string attack()
        {
            return enemy.attack();
        }
    }
}
