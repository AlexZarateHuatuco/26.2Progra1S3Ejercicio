using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1_S3_Ejercicios
{
    internal class Player : Character
    {
        public Player(float life, float damage) : base(life, damage)
        {
            
        }

        public override void TakeDamage(float amount)
        {
            this.life -= amount;
            Console.WriteLine($"[Jugador] ha recibido {amount} de daño. Vida restante {this.life}");
        }

        public override float DealtDamage()
        {
            Console.WriteLine($"[Jugador] hace el ataque con un daño de {this.damage}");
            return this.damage;
        }
    }
}
