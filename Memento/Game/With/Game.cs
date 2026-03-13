using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game.With
{


    //Originator(Game)
    class Game
    {
        public int Level { get; set; }
        public int Health { get; set; }
        public string Position { get; set; }

        public GameMemento Save()
        {
            return new GameMemento(Level, Health, Position);
        }

        public void Load(GameMemento memento)
        {
            Level = memento.Level;
            Health = memento.Health;
            Position = memento.Position;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Level: {Level}, Health: {Health}, Position: {Position}");
        }
    }

    //Memento(stores game state)
    class GameMemento
    {
        public int Level { get; }
        public int Health { get; }
        public string Position { get; }

        public GameMemento(int level, int health, string position)
        {
            Level = level;
            Health = health;
            Position = position;
        }
    }



    //Caretaker(Save Manager)
    class SaveManager
    {
        private List<GameMemento> saves = new List<GameMemento>();

        public void SaveGame(GameMemento memento)
        {
            saves.Add(memento);
        }

        public GameMemento LoadGame(int index)
        {
            return saves[index];
        }
    }
}
