using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
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

        private void buttonRunQuery_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (OdbcConnection connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["KraftHeinzConnectionStringOdbc"].ConnectionString))
            {
                connection.Open();
                using (OdbcCommand com = new OdbcCommand("select * from positions_tb", connection))
                {
                    using (OdbcDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var objs = new object[4];
                            reader.GetValues(objs);
                            stringBuilder.AppendLine(objs.Select(x => x.ToString()).Aggregate((x, y) => x + ", " + y));
                        }
                    }
                }
            }
            MessageBox.Show(stringBuilder.ToString());
        }

        private void buttonRunNonQuery_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["KraftHeinzConnectionStringOleDB"].ConnectionString))
            {
                OleDbCommand command = new OleDbCommand()
                {
                    CommandText = "update positions_tb set positionDescription = 'now all descriptions like this'",
                    Connection = connection
                };

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Query successfully completed");
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
