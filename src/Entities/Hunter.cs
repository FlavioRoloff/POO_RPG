using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPOO.src.Entities
{
    public class Hunter : Hero
    {
        public Hunter()
        {
        }
        public Hunter(string Name, int Level, string HeroType, int LifePoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.LifePoints = 100;
            this.ManaPoints = 100;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com a sua besta";
        }
    }
}