using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1_S3_Ejercicios
{
    internal class Player
    {
        private float life;
        private float damage;

        public Player(float life, float damage)
        {
            this.life = life;
            this.damage = damage;
        }

        public void TakeDamage(float amount)
        {
            this.life -= amount;
        }

        public float DealtDamage()
        {
            return this.damage;
        }
    }
}
