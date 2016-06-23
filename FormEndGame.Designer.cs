namespace Ballons
{
    partial class FormEndGame
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
            this.labelTablo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPlaceGraphItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTablo
            // 
            this.labelTablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))); //Czcionka
            this.labelTablo.Location = new System.Drawing.Point(64, 27); //lokalizacja tej części
            this.labelTablo.Name = "labelTablo"; //imię
            this.labelTablo.Size = new System.Drawing.Size(243, 70); //Rozmiar
            this.labelTablo.TabIndex = 0; //Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze
            this.labelTablo.Text = "Gra skonczona!\r\nCzy chcesz zagrać ponownie?"; //Tekst
            this.labelTablo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1 
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK; //Pobiera lub ustawia okno dialogowe wynik dla formularza.
            this.button1.Location = new System.Drawing.Point(84, 113); //lokalizacja tej części
            this.button1.Name = "button1"; //imię
            this.button1.Size = new System.Drawing.Size(75, 23); //Rozmiar
            this.button1.TabIndex = 1; //Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze
            this.button1.Text = "Tak"; //Tekst
            this.button1.UseVisualStyleBackColor = true; //Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;//Pobiera lub ustawia okno dialogowe wynik dla formularza.
            this.button2.Location = new System.Drawing.Point(181, 113);//lokalizacja tej części
            this.button2.Name = "button2"; //imię
            this.button2.Size = new System.Drawing.Size(75, 23);//Rozmiar
            this.button2.TabIndex = 2; //Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze
            this.button2.Text = "Nie"; //Tekst
            this.button2.UseVisualStyleBackColor = true; //Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            // 
            // labelPlaceGraphItem
            // 
            this.labelPlaceGraphItem.Location = new System.Drawing.Point(12, 23);//lokalizacja tej części
            this.labelPlaceGraphItem.Name = "labelPlaceGraphItem";//imię
            this.labelPlaceGraphItem.Size = new System.Drawing.Size(40, 40);//Rozmiar
            this.labelPlaceGraphItem.TabIndex = 3;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze
            this.labelPlaceGraphItem.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPlaceGraphItem_Paint); //Działa, kiedy kolor elementu zmienia się
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 148);
            this.Controls.Add(this.labelPlaceGraphItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTablo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gratuluję!";
            this.Load += new System.EventHandler(this.FormEndGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTablo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelPlaceGraphItem;
    }
}