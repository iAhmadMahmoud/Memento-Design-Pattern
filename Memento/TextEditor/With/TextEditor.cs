using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.TextEditor.With
{
    // Memento: stores the state
    class TextMemento
    {
        public string Content { get; }

        public TextMemento(string content)
        {
            Content = content;
        }
    }

    // Originator: the text editor
    class TextEditor
    {
        public string Content { get; set; }

        public TextMemento Save()
        {
            return new TextMemento(Content);
        }

        public void Restore(TextMemento memento)
        {
            Content = memento.Content;
        }
    }

    // Caretaker: manages history
    class History
    {
        private Stack<TextMemento> states = new Stack<TextMemento>();

        public void Save(TextMemento memento)
        {
            states.Push(memento);
        }

        public TextMemento Undo()
        {
            if (states.Count > 0)
                return states.Pop();

            return null;
        }
    }

}
