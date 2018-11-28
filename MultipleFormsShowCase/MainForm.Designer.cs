namespace MultipleFormsShowCase
{
    partial class MainForm
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
            this.buttonNonPar = new System.Windows.Forms.Button();
            this.buttonPar = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNonPar
            // 
            this.buttonNonPar.Location = new System.Drawing.Point(66, 39);
            this.buttonNonPar.Name = "buttonNonPar";
            this.buttonNonPar.Size = new System.Drawing.Size(112, 37);
            this.buttonNonPar.TabIndex = 0;
            this.buttonNonPar.Text = "Non Parameterized Queries";
            this.buttonNonPar.UseVisualStyleBackColor = true;
            this.buttonNonPar.Click += new System.EventHandler(this.buttonNonPar_Click);
            // 
            // buttonPar
            // 
            this.buttonPar.Location = new System.Drawing.Point(66, 82);
            this.buttonPar.Name = "buttonPar";
            this.buttonPar.Size = new System.Drawing.Size(112, 37);
            this.buttonPar.TabIndex = 1;
            this.buttonPar.Text = "Parameterized Queries";
            this.buttonPar.UseVisualStyleBackColor = true;
            this.buttonPar.Click += new System.EventHandler(this.buttonPar_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(66, 125);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 37);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 226);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPar);
            this.Controls.Add(this.buttonNonPar);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNonPar;
        private System.Windows.Forms.Button buttonPar;
        private System.Windows.Forms.Button buttonExit;
    }
}

