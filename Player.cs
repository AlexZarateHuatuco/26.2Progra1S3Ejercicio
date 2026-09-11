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
            if (life > 100)
            {
                this.life = 100;
            }
            else
            {
                this.life = life;
            }

            if (damage > 100)
            {
                this.damage = 100;
            }
            else
            {
                this.damage = damage;
            }
        }

        public void TakeDamage(float amount)
        {
            this.life -= amount;
            
            if (this.life < 0)
            {
                this.life = 0;
            }
        }

        public float DealtDamage()
        {
            return this.damage;
        }

        public bool IsAlive()
        {
            return this.life > 0;
        }
    }
}
