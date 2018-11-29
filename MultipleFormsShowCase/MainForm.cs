using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleFormsShowCase
{
    public partial class MainForm : Form
    {
        NonParameterizedQueriesForm NonParameterizedQueriesForm;
        ParameterizedQueriesForm ParameterizedQueriesForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void nonParaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NonParameterizedQueriesForm == null)
            {
                NonParameterizedQueriesForm = new NonParameterizedQueriesForm(this);
                NonParameterizedQueriesForm.Show();
            }
            else
            {
                MessageBox.Show($"Form {nameof(NonParameterizedQueriesForm)} is already opened");
            }
        }

        private void parameterizedQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParameterizedQueriesForm == null)
            {
                ParameterizedQueriesForm = new ParameterizedQueriesForm(this);
                ParameterizedQueriesForm.Show();
            }
            else
            {
                MessageBox.Show($"Form {nameof(ParameterizedQueriesForm)} is already opened");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CleanNonParameterizedQueriesForm()
        {
            NonParameterizedQueriesForm = null;
        }

        public void CleanParameterizedQueriesForm()
        {
            ParameterizedQueriesForm = null;
        }

    }
}
