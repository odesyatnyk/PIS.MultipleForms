namespace MultipleFormsShowCase
{
    partial class NonParameterizedQueriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRunQuery = new System.Windows.Forms.Button();
            this.buttonRunNonQuery = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRunQuery
            // 
            this.buttonRunQuery.Location = new System.Drawing.Point(377, 12);
            this.buttonRunQuery.Name = "buttonRunQuery";
            this.buttonRunQuery.Size = new System.Drawing.Size(112, 37);
            this.buttonRunQuery.TabIndex = 1;
            this.buttonRunQuery.Text = "Run \"Query\"";
            this.buttonRunQuery.UseVisualStyleBackColor = true;
            this.buttonRunQuery.Click += new System.EventHandler(this.buttonRunQuery_Click);
            // 
            // buttonRunNonQuery
            // 
            this.buttonRunNonQuery.Location = new System.Drawing.Point(377, 55);
            this.buttonRunNonQuery.Name = "buttonRunNonQuery";
            this.buttonRunNonQuery.Size = new System.Drawing.Size(112, 37);
            this.buttonRunNonQuery.TabIndex = 2;
            this.buttonRunNonQuery.Text = "Run \"Non Query\"";
            this.buttonRunNonQuery.UseVisualStyleBackColor = true;
            this.buttonRunNonQuery.Click += new System.EventHandler(this.buttonRunNonQuery_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(377, 193);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(112, 37);
            this.buttonCloseForm.TabIndex = 3;
            this.buttonCloseForm.Text = "Close";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // resultsGrid
            // 
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Location = new System.Drawing.Point(12, 12);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.Size = new System.Drawing.Size(359, 218);
            this.resultsGrid.TabIndex = 4;
            // 
            // NonParameterizedQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 242);
            this.Controls.Add(this.resultsGrid);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonRunNonQuery);
            this.Controls.Add(this.buttonRunQuery);
            this.Name = "NonParameterizedQueriesForm";
            this.Text = "NonParameterizedQueriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRunQuery;
        private System.Windows.Forms.Button buttonRunNonQuery;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.DataGridView resultsGrid;
    }
}