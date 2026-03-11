namespace AplikacjaKalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWynik = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            buttonOdejmij = new Button();
            buttonMnoz = new Button();
            buttonDziel = new Button();
            buttonDodaj = new Button();
            SuspendLayout();
            // 
            // labelWynik
            // 
            labelWynik.AutoSize = true;
            labelWynik.Location = new Point(280, 391);
            labelWynik.Name = "labelWynik";
            labelWynik.Size = new Size(46, 15);
            labelWynik.TabIndex = 0;
            labelWynik.Text = "Wynik: ";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(117, 68);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(404, 68);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 2;
            // 
            // buttonOdejmij
            // 
            buttonOdejmij.Location = new Point(415, 140);
            buttonOdejmij.Name = "buttonOdejmij";
            buttonOdejmij.Size = new Size(75, 23);
            buttonOdejmij.TabIndex = 4;
            buttonOdejmij.Text = "Odejmij";
            buttonOdejmij.UseVisualStyleBackColor = true;
            // 
            // buttonMnoz
            // 
            buttonMnoz.Location = new Point(129, 253);
            buttonMnoz.Name = "buttonMnoz";
            buttonMnoz.Size = new Size(75, 23);
            buttonMnoz.TabIndex = 5;
            buttonMnoz.Text = "Pomnóż";
            buttonMnoz.UseVisualStyleBackColor = true;
            // 
            // buttonDziel
            // 
            buttonDziel.Location = new Point(415, 253);
            buttonDziel.Name = "buttonDziel";
            buttonDziel.Size = new Size(75, 23);
            buttonDziel.TabIndex = 6;
            buttonDziel.Text = "Podziel";
            buttonDziel.UseVisualStyleBackColor = true;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(129, 140);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(75, 23);
            buttonDodaj.TabIndex = 3;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDziel);
            Controls.Add(buttonMnoz);
            Controls.Add(buttonOdejmij);
            Controls.Add(buttonDodaj);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(labelWynik);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWynik;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button buttonOdejmij;
        private Button buttonMnoz;
        private Button buttonDziel;
        private Button buttonDodaj;
    }
}
