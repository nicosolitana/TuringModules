using System;
using System.Threading;
using System.Windows.Forms;
using TuringModules.Common;
using TuringModules.Controller;
using TuringModules.Model;

namespace TuringModules
{
    public partial class MainForm : Form
    {
        private Thread simThread = null;

        public MainForm()
        {
            InitializeComponent();
            Validator.LoadResource();
            TuringModGUI.Output = lblOuputString;
            TuringModGUI.SimulationResult = txtSimResult;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            ResetGUI();
            simThread = new Thread(new ThreadStart(Execute));
            simThread.Start();
        }

        private void ResetGUI()
        {
            TuringModGUI.Output.Text = string.Empty;
            TuringModGUI.SimulationResult.Text = string.Empty;
        }

        private void Execute()
        {
            try
            {
                string code = txtProgram.Text;
                string input = txtInputStr.Text;
                Execute exec = new Execute();
                bool res = exec.Start(input, code);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
