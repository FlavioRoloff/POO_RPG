using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace ProjetoPOO.src.Entities
{
  public abstract class Hero
  {
    public Hero(string Name, int Level, string HeroType, int LifePoints, int ManaPoints)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.LifePoints = 100;
      this.ManaPoints = 100;
    }

    public Hero()
    {
    }
    public string Name;
    public int Level;
    public string HeroType;
    public int LifePoints;
    public int ManaPoints;

    public override string ToString()
    {
      return this.Name + " " + "Lvl. " + this.Level + " " + this.HeroType;
    }

    public virtual string Attack()
    {
      return this.Name + " Atacou com a sua espada";
    }
  }
}