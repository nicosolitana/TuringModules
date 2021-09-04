using System;
using System.Windows.Forms;
using TuringModules.Common;
using TuringModules.Controller;

namespace TuringModules
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Validator.LoadResource();
        }

        private void btnExecute_Click(object sender, EventArgs e)
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
