using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game.Without
{
    class Game
    {
        public int Level;
        public int Health;
        public string Position;

        private List<(int, int, string)> saves = new List<(int, int, string)>();

        public void Save()
        {
            saves.Add((Level, Health, Position));
        }

        public void Load(int index)
        {
            var save = saves[index];
            Level = save.Item1;
            Health = save.Item2;
            Position = save.Item3;
        }

        public void Show()
        {
            Console.WriteLine($"Level: {Level}, Health: {Health}, Position: {Position}");
        }
    }
}
