using System;
using System.Windows.Forms;
using Comands.Comands;

namespace Comands
{
    public partial class Editor : Form
    {
        public CommandHistory history = new CommandHistory();
        public String clipboard;

        public Editor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void executeCommand(Command command)
        {
            if (command.Execute())
            {
                history.push(command);
            }
        }

        public void Undo()
        {
            if (history.isEmpty()) return;

            Command command = history.pop();
            if (command != null)
            {
                command.Undo();
            }
        }

        private void CtrlZButton_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void CtrlXButton_Click(object sender, EventArgs e)
        {
            executeCommand(new Comands.CutCommand(this));
        }

        private void CtrlCButton_Click(object sender, EventArgs e)
        {
            executeCommand(new Comands.CopyCommand(this));
        }

        private void CtrlVButton_Click(object sender, EventArgs e)
        {
            executeCommand(new Comands.PasteCommand(this));
        }
    }
}
