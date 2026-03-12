using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region TextEditor without Memento
            TextEditor.Without.TextEditor editorWithoutMemento = new TextEditor.Without.TextEditor();

            editorWithoutMemento.Write("Hello");
            editorWithoutMemento.Write("Hello World");
            editorWithoutMemento.Write("Hello World!!!");

            Console.WriteLine(editorWithoutMemento.Content);

            editorWithoutMemento.Undo();
            Console.WriteLine(editorWithoutMemento.Content);

            editorWithoutMemento.Undo();
            Console.WriteLine(editorWithoutMemento.Content);
            #endregion

            #region TextEditor with Memento 
            TextEditor.With.TextEditor editorWithMemento = new TextEditor.With.TextEditor();
            TextEditor.With.History history = new TextEditor.With.History();

            editorWithMemento.Content = "Hello";
            history.Save(editorWithMemento.Save());

            editorWithMemento.Content = "Hello World";
            history.Save(editorWithMemento.Save());

            editorWithMemento.Content = "Hello World!!!";

            Console.WriteLine("Current: " + editorWithMemento.Content);

            // Undo
            editorWithMemento.Restore(history.Undo());
            Console.WriteLine("After Undo: " + editorWithMemento.Content);

            editorWithMemento.Restore(history.Undo());
            Console.WriteLine("After Undo Again: " + editorWithMemento.Content);
            #endregion


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
            Game.With.SaveManager manager = new Game.With.SaveManager();

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
