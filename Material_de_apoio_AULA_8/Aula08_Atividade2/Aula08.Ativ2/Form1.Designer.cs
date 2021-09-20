namespace Aula08.Ativ2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabuadaTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tabuadaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a tabuada:";
            // 
            // tabuadaTextBox
            // 
            this.tabuadaTextBox.Location = new System.Drawing.Point(135, 23);
            this.tabuadaTextBox.Name = "tabuadaTextBox";
            this.tabuadaTextBox.Size = new System.Drawing.Size(56, 22);
            this.tabuadaTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(200, 19);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tabuadaListBox
            // 
            this.tabuadaListBox.FormattingEnabled = true;
            this.tabuadaListBox.ItemHeight = 16;
            this.tabuadaListBox.Location = new System.Drawing.Point(16, 84);
            this.tabuadaListBox.Name = "tabuadaListBox";
            this.tabuadaListBox.Size = new System.Drawing.Size(382, 180);
            this.tabuadaListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 305);
            this.Controls.Add(this.tabuadaListBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tabuadaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tabuadaTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox tabuadaListBox;
    }
}

