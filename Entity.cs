using System;
using System.Collections.Generic;
using System.Text;

namespace Progra1_S3_Ejercicios
{
    internal class Entity
    {
        protected int vida;
        protected int daño;

        public Entity(int vida, int daño)
        {
            this.vida = Math.Max(0, Math.Min(vida, 100));
            this.daño = Math.Max(0, Math.Min(daño, 100));
        }

        public virtual int ObtenerDaño()        
        {
            return daño;
        }

        public virtual void RecibirDaño(int daño)
        {
            // ...
        }
    }
}
