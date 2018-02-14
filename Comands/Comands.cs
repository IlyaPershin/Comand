using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Comands.Comands
{
    public abstract class Command
    {
        public Editor editor;
        protected String backup;
        protected TextBox textBox;

        public Command(Editor editor)
        {
            this.editor = editor;
            this.textBox = (TextBox)editor.Controls.Find("textBox1", false).First();
        }

        protected void Backup()
        {
            backup = textBox.Text;
        }

        public void Undo()
        {
            textBox.Text = backup;
        }

        public abstract Boolean Execute();
    }

    public class CopyCommand : Command
    {
        public CopyCommand(Editor editor) : base(editor) { }

        public override bool Execute()
        {
            editor.clipboard = textBox.SelectedText;
            return false;
        }
    }

    public class PasteCommand : Command
    {
        public PasteCommand(Editor editor) : base(editor) { }


        public override bool Execute()
        {
            if (editor.clipboard == null || editor.clipboard == "") return false;

            Backup();
            textBox.AppendText(editor.clipboard);
            return true;
        }
    }

    public class CutCommand : Command
    {

        public CutCommand(Editor editor) : base(editor) { }

        public override bool Execute()
        {
            if (textBox.SelectedText == null || textBox.SelectedText == "") return false;

            Backup();
            String source = textBox.Text;
            editor.clipboard = textBox.SelectedText;
            textBox.Text = (cutString(source, editor.clipboard));
            return true;
        }

        public String cutString(String source, String cut)
        {
            String start = source.Substring(0, textBox.SelectionStart);
            String end = source.Substring(textBox.SelectionStart + textBox.SelectionLength, source.Length - (textBox.SelectionStart + textBox.SelectionLength));
            return start + end;
        }
    }

    public class CommandHistory
    {
        private Stack<Comands.Command> history = new Stack<Comands.Command>();

        public void push(Command c)
        {
            history.Push(c);
        }

        public Command pop()
        {
            return (Command)history.Pop();
        }

        public Boolean isEmpty() { return (history == null || history.Count == 0); }
    }
}
