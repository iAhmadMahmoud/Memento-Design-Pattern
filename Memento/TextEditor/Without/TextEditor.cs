using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.TextEditor.Without
{
    class TextEditor
    {
        public string Content = "";
        private Stack<string> history = new Stack<string>();

        public void Write(string newText)
        {
            history.Push(Content); // save old state
            Content = newText;
        }

        public void Undo()
        {
            if (history.Count > 0)
                Content = history.Pop();
        }
    }
}
