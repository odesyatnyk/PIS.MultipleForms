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

        private void buttonRunSelect_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (OdbcConnection connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["KraftHeinzConnectionStringOdbc"].ConnectionString))
            {
                connection.Open();
                OdbcCommand command = connection.CreateCommand();
                command.CommandText = @"select * from positions_tb where positionName = ?";
                command.Parameters.Add("@term", OdbcType.NVarChar, 100).Value = textBoxSelect.Text;
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var objs = new object[4];
                        reader.GetValues(objs);
                        stringBuilder.AppendLine(objs.Select(x => x.ToString()).Aggregate((x, y) => x + ", " + y));
                    }
                }

            }
            MessageBox.Show(stringBuilder.ToString());
        }

        private void buttonRunScalar_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            using (OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["KraftHeinzConnectionStringOleDB"].ConnectionString))
            {
                OleDbCommand command = new OleDbCommand()
                {
                    CommandText = "select positionName from positions_tb where idPosition = ?",
                    Connection = connection
                };

                command.Parameters.Add("@id", OleDbType.Integer).Value = Convert.ToInt32(textBoxScalar.Text);

                try
                {
                    connection.Open();
                    result = (string)command.ExecuteScalar();
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
            if (string.IsNullOrWhiteSpace(result))
                MessageBox.Show("No results");
            else
                MessageBox.Show(result);
        }

        private void buttonRunNonQ_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["KraftHeinzConnectionStringOleDB"].ConnectionString))
            {
                OleDbCommand command = new OleDbCommand()
                {
                    CommandText = "update positions_tb set positionDescription = ? where idPosition = ?",
                    Connection = connection
                };

                command.Parameters.Add("@pos", OleDbType.VarChar, 100).Value = textBoxNonQ.Text;
                command.Parameters.Add("@id", OleDbType.Integer).Value = Convert.ToInt32(textBoxNonQueryId.Text);

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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
