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
    public partial class NonParameterizedQueriesForm : Form
    {
        #region Initialize

        MainForm parentForm;

        protected NonParameterizedQueriesForm()
        {
            InitializeComponent();
        }

        public NonParameterizedQueriesForm(MainForm mainForm) : this()
        {
            parentForm = mainForm;
            this.FormClosed += NonParameterizedQueriesForm_FormClosed;
        }

        private void NonParameterizedQueriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.CleanNonParameterizedQueriesForm();
        }

        #endregion


    }
}
