using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Comands
{
    public abstract class Command
    {
        public Form1 editor;
        protected String backup;
        protected TextBox textField;

        public Command(Form1 editor)
        {
            this.editor = editor;
            this.textField = (TextBox)editor.Controls.Find("textBox1", false).First();
        }

        protected void Backup()
        {
            backup = textField.Text;
        }

        public void Undo()
        {
            textField.Text = backup;
        }

        public abstract Boolean Execute();
    }

    public class CopyCommand : Command
    {
        public CopyCommand(Form1 editor) : base(editor) { }

        public override bool Execute()
        {
            editor.clipboard = textField.SelectedText;
            return false;
        }
    }

    public class PasteCommand : Command
    {
        public PasteCommand(Form1 editor) : base(editor) { }


        public override bool Execute()
        {
            if (editor.clipboard == null || editor.clipboard == "") return false;

            Backup();
            textField.AppendText(editor.clipboard);
            return true;
        }
    }

    public class CutCommand : Command
    {

        public CutCommand(Form1 editor) : base(editor) { }
        
        public override bool Execute()
        {
            if (textField.SelectedText == null || textField.SelectedText == "") return false;

            Backup();
            String source = textField.Text;
            editor.clipboard = textField.SelectedText;
            textField.Text = (cutString(source, editor.clipboard));
            return true;
        }

        public String cutString(String source, String cut)
        {
            String start = source.Substring(0, textField.SelectionStart);
            String end = source.Substring(textField.SelectionStart + textField.SelectionLength, source.Length - (textField.SelectionStart + textField.SelectionLength));
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
