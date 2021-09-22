using System;
using System.Drawing.Printing;
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
            ClearPanel();
            Validator.LoadResource();
            TuringModGUI.SimulationPanel = pnlRes;
            TuringModGUI.Result = txtResult;
        }

        private void ClearPanel()
        {
            pnlRes.Controls.Clear();
            pnlRes.AutoScroll = false;
            pnlRes.VerticalScroll.Enabled = true;
            pnlRes.VerticalScroll.Visible = true;
            pnlRes.HorizontalScroll.Visible = false;
            pnlRes.AutoScroll = true;
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
            TuringModGUI.SimulationPanel.Controls.Clear();
            TuringModGUI.SimPanelLocY = 0;
            TuringModGUI.Result.Text = string.Empty;
            ClearPanel();
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
            txtInputStr.Text = string.Empty;
            txtProgram.Text = string.Empty;
            ClearPanel();
            ResetGUI();
        }

        private void cmbTestCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetGUI();
            string selection = cmbTestCase.SelectedItem.ToString().Split('(')[0].Trim();
            var input = TestCase.GetDefaultTestCase(selection);
            txtInputStr.Text = input[0];
            txtProgram.Text = input[1];
        }
    }
}
