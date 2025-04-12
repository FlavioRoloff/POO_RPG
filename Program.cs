using ProjetoPOO.src.Entities;
using static System.Console;

class Program
{
  static void Main(string[] args)
  {
    Clear();
    List<Hero> heroes = new List<Hero>
    {
      new Knight("Crono", 13, "Knight", 100, 100),
      new Wizard("Magus", 20, "Black Wizard", 100, 100),
      new Knight("Frog", 26, "Knight", 100, 100),
      new Wizard("Marle", 10, "White Wizard", 100, 100),
      new Ninja("Robo", 15, "Ninja", 100, 100),
      new Hunter("Lucca", 12, "Hunter", 100, 100),
    };

    Hero ShowMenu(List<Hero> heroes)
    {
      WriteLine("+----+----------------+------+---------------+------------+------------+");
      WriteLine("| ID | Nome           | Nível| Classe        | Vida       | Mana       |");
      WriteLine("+----+----------------+------+---------------+------------+------------+");

      for (int i = 0; i < heroes.Count; i++)
      {
        WriteLine($"| {i,-2} | {heroes[i].Name,-14} | {heroes[i].Level,-4} | {heroes[i].HeroType,-13} | {heroes[i].LifePoints,-10} | {heroes[i].ManaPoints,-10} |");
      }
      WriteLine("+----+----------------+------+---------------+------------+------------+");
      WriteLine("Escolha seu herói digitando o ID correspondente.");
      Write("Escolha um herói: ");
      int heroIndex = int.Parse(ReadLine()!);
      Hero selectedHero = heroes[heroIndex];
      if (heroIndex >= 0 && heroIndex < heroes.Count)
      {
        WriteLine($"Você escolheu: {selectedHero}");
        Thread.Sleep(2000);
      }
      else
      {
        WriteLine("Índice inválido.");
      }  
      return heroes[heroIndex];
    }
    Hero selectedHero = ShowMenu(heroes);
    Clear();
    bool continueGame = true;
    while (continueGame)
    {
      Clear();
      WriteLine("1 - Atacar");
      WriteLine("2 - Status");
      WriteLine("3 - Escolher outro herói");
      WriteLine("4 - Sair do jogo");
      Write("Escolha uma opção ");
      int option = int.Parse(ReadLine()!);

      switch (option)
      {
        case 1:
          WriteLine($"\n{selectedHero.Attack()}");
          WriteLine("Pressione qualquer tecla para continuar...");
          ReadKey(true);
          break;
        case 2:
          Clear();
          WriteLine("+----------------+--------------------+");
          WriteLine("| Atributo       | Valor              |");
          WriteLine("+----------------+--------------------+");
          WriteLine($"| Nome           | {selectedHero.Name,-18} |");
          WriteLine($"| Nível          | {selectedHero.Level,-18} |");
          WriteLine($"| Tipo           | {selectedHero.HeroType,-18} |");
          WriteLine($"| Pontos de Vida | {selectedHero.LifePoints,-18}/100         |");
          WriteLine($"| Pontos de Mana | {selectedHero.ManaPoints,-18}/100         |");
          WriteLine("+----------------+--------------------+");
          WriteLine("Pressione qualquer tecla para continuar...");
          ReadKey(true);
          break;
        case 3:
          Clear();
          ShowMenu(heroes);
          break;
        case 4:
          continueGame = false;
          Clear();
          WriteLine("Saindo do jogo...");
          WriteLine("Pressione qualquer tecla para continuar...");
          ReadKey(true);
          break;
        default:
          WriteLine("Ação inválida. Tente novamente.");
          break;
      }
    }
  }
}