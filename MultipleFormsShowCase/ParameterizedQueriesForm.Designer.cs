namespace MultipleFormsShowCase
{
    partial class ParameterizedQueriesForm
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
            this.buttonRunSelect = new System.Windows.Forms.Button();
            this.buttonRunScalar = new System.Windows.Forms.Button();
            this.buttonRunNonQ = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.textBoxScalar = new System.Windows.Forms.TextBox();
            this.textBoxNonQ = new System.Windows.Forms.TextBox();
            this.textBoxNonQueryId = new System.Windows.Forms.TextBox();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRunSelect
            // 
            this.buttonRunSelect.Location = new System.Drawing.Point(570, 11);
            this.buttonRunSelect.Name = "buttonRunSelect";
            this.buttonRunSelect.Size = new System.Drawing.Size(112, 37);
            this.buttonRunSelect.TabIndex = 2;
            this.buttonRunSelect.Text = "Run \"Select\"";
            this.buttonRunSelect.UseVisualStyleBackColor = true;
            this.buttonRunSelect.Click += new System.EventHandler(this.buttonRunSelect_Click);
            // 
            // buttonRunScalar
            // 
            this.buttonRunScalar.Location = new System.Drawing.Point(570, 53);
            this.buttonRunScalar.Name = "buttonRunScalar";
            this.buttonRunScalar.Size = new System.Drawing.Size(112, 37);
            this.buttonRunScalar.TabIndex = 3;
            this.buttonRunScalar.Text = "Run \"Scalar\"";
            this.buttonRunScalar.UseVisualStyleBackColor = true;
            this.buttonRunScalar.Click += new System.EventHandler(this.buttonRunScalar_Click);
            // 
            // buttonRunNonQ
            // 
            this.buttonRunNonQ.Location = new System.Drawing.Point(570, 96);
            this.buttonRunNonQ.Name = "buttonRunNonQ";
            this.buttonRunNonQ.Size = new System.Drawing.Size(112, 37);
            this.buttonRunNonQ.TabIndex = 4;
            this.buttonRunNonQ.Text = "Run \"Non Query\"";
            this.buttonRunNonQ.UseVisualStyleBackColor = true;
            this.buttonRunNonQ.Click += new System.EventHandler(this.buttonRunNonQ_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(570, 193);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 37);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(377, 12);
            this.textBoxSelect.Multiline = true;
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(187, 36);
            this.textBoxSelect.TabIndex = 6;
            // 
            // textBoxScalar
            // 
            this.textBoxScalar.Location = new System.Drawing.Point(377, 54);
            this.textBoxScalar.Multiline = true;
            this.textBoxScalar.Name = "textBoxScalar";
            this.textBoxScalar.Size = new System.Drawing.Size(187, 36);
            this.textBoxScalar.TabIndex = 7;
            // 
            // textBoxNonQ
            // 
            this.textBoxNonQ.Location = new System.Drawing.Point(377, 96);
            this.textBoxNonQ.Multiline = true;
            this.textBoxNonQ.Name = "textBoxNonQ";
            this.textBoxNonQ.Size = new System.Drawing.Size(110, 36);
            this.textBoxNonQ.TabIndex = 8;
            // 
            // textBoxNonQueryId
            // 
            this.textBoxNonQueryId.Location = new System.Drawing.Point(493, 96);
            this.textBoxNonQueryId.Multiline = true;
            this.textBoxNonQueryId.Name = "textBoxNonQueryId";
            this.textBoxNonQueryId.Size = new System.Drawing.Size(71, 36);
            this.textBoxNonQueryId.TabIndex = 9;
            // 
            // resultsGrid
            // 
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Location = new System.Drawing.Point(12, 12);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.Size = new System.Drawing.Size(359, 218);
            this.resultsGrid.TabIndex = 10;
            // 
            // ParameterizedQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 242);
            this.Controls.Add(this.resultsGrid);
            this.Controls.Add(this.textBoxNonQueryId);
            this.Controls.Add(this.textBoxNonQ);
            this.Controls.Add(this.textBoxScalar);
            this.Controls.Add(this.textBoxSelect);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRunNonQ);
            this.Controls.Add(this.buttonRunScalar);
            this.Controls.Add(this.buttonRunSelect);
            this.Name = "ParameterizedQueriesForm";
            this.Text = "ParameterizedQueriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRunSelect;
        private System.Windows.Forms.Button buttonRunScalar;
        private System.Windows.Forms.Button buttonRunNonQ;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.TextBox textBoxScalar;
        private System.Windows.Forms.TextBox textBoxNonQ;
        private System.Windows.Forms.TextBox textBoxNonQueryId;
        private System.Windows.Forms.DataGridView resultsGrid;
    }
}