using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPOO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int LifePoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.LifePoints = 100;
            this.ManaPoints = 100;
        }
        public Wizard()
        {
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }
    }
}