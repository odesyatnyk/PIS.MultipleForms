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
    public partial class ParameterizedQueriesForm : Form
    {
        #region Initialize

        MainForm parentForm;

        public ParameterizedQueriesForm()
        {
            InitializeComponent();
        }

        public ParameterizedQueriesForm(MainForm mainForm) : this()
        {
            parentForm = mainForm;
            this.FormClosed += ParameterizedQueriesForm_FormClosed;
        }

        private void ParameterizedQueriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.CleanParameterizedQueriesForm();
        }

        #endregion


    }
}
