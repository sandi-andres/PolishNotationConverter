namespace PolishNotationConverter
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInfix = new System.Windows.Forms.TextBox();
            this.labelPostfix = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInfix
            // 
            this.textBoxInfix.Location = new System.Drawing.Point(36, 66);
            this.textBoxInfix.Name = "textBoxInfix";
            this.textBoxInfix.Size = new System.Drawing.Size(167, 20);
            this.textBoxInfix.TabIndex = 0;
            // 
            // labelPostfix
            // 
            this.labelPostfix.AutoSize = true;
            this.labelPostfix.Location = new System.Drawing.Point(33, 99);
            this.labelPostfix.Name = "labelPostfix";
            this.labelPostfix.Size = new System.Drawing.Size(0, 13);
            this.labelPostfix.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(227, 66);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(98, 22);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(22, 19);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(321, 26);
            this.labelInstructions.TabIndex = 3;
            this.labelInstructions.Text = "Insert a prefix expression. I can only contain 1 digit whole numbers.\r\nAccepted o" +
    "perators: + – * / ^ %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 144);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelPostfix);
            this.Controls.Add(this.textBoxInfix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfix;
        private System.Windows.Forms.Label labelPostfix;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelInstructions;
    }
}

