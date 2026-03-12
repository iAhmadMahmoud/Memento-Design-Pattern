using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.Game.With;
using Memento.Game.Without;


namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {







            #region Game without Memento
            Game.Without.Game gameWithoutMemento = new Game.Without.Game();

            gameWithoutMemento.Level = 1;
            gameWithoutMemento.Health = 100;
            gameWithoutMemento.Position = "Village";

            gameWithoutMemento.Save();

            gameWithoutMemento.Level = 2;
            gameWithoutMemento.Health = 80;
            gameWithoutMemento.Position = "Forest";

            gameWithoutMemento.Show();

            gameWithoutMemento.Load(0);

            gameWithoutMemento.Show();

            #endregion

            #region Game with Memento
            Game.With.Game gameWithMemento = new Game.With.Game();
            SaveManager manager = new SaveManager();

            gameWithMemento.Level = 1;
            gameWithMemento.Health = 100;
            gameWithMemento.Position = "Village";

            manager.SaveGame(gameWithMemento.Save());

            gameWithMemento.Level = 2;
            gameWithMemento.Health = 80;
            gameWithMemento.Position = "Forest";

            Console.WriteLine("Current Game State:");
            gameWithMemento.ShowStatus();

            Console.WriteLine("\nLoading previous save...");
            gameWithMemento.Load(manager.LoadGame(0));

            gameWithMemento.ShowStatus();
            #endregion
        }
    }
}
