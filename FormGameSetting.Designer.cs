namespace Ballons
{
    partial class FormGameSetting
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
            this.buttonOK = new System.Windows.Forms.Button();//Dodawanie nowego obiektu
            this.buttonCancel = new System.Windows.Forms.Button();//Dodawanie nowego obiektu
            this.tabControlSetting = new System.Windows.Forms.TabControl();//Dodawanie nowego obiektu
            this.tabPage2 = new System.Windows.Forms.TabPage();//Dodawanie nowego obiektu
            this.groupBox2 = new System.Windows.Forms.GroupBox();//Dodawanie nowego obiektu
            this.radioButtonRhombus = new System.Windows.Forms.RadioButton();//Dodawanie nowego obiektu
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();//Dodawanie nowego obiektu
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();//Dodawanie nowego obiektu
            this.groupBox1 = new System.Windows.Forms.GroupBox();//Dodawanie nowego obiektu
            this.buttonColor3 = new System.Windows.Forms.Button();//Dodawanie nowego obiektu
            this.buttonColr2 = new System.Windows.Forms.Button();//Dodawanie nowego obiektu
            this.buttonColor1 = new System.Windows.Forms.Button();//Dodawanie nowego obiektu
            this.labelGraphItemColor3 = new System.Windows.Forms.Label();//Dodawanie nowego obiektu
            this.labelGraphItemColor2 = new System.Windows.Forms.Label(); //Dodawanie nowego obiektu
            this.labelGraphItemColor1 = new System.Windows.Forms.Label(); //Dodawanie nowego obiektu
            this.tabControlSetting.SuspendLayout();//Tymczasowo zawiesza logikę układ elementu. 
            this.tabPage2.SuspendLayout();//Tymczasowo zawiesza logikę układ elementu.
            this.groupBox2.SuspendLayout();//Tymczasowo zawiesza logikę układ elementu.
            this.groupBox1.SuspendLayout();//Tymczasowo zawiesza logikę układ elementu.
            this.SuspendLayout();//Tymczasowo zawiesza logikę układ elementu.
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;//Pobiera lub ustawia okno dialogowe wynik dla formularza. 
            this.buttonOK.Location = new System.Drawing.Point(134, 233); //roztaszowanie tej części
            this.buttonOK.Name = "buttonOK";//imię
            this.buttonOK.Size = new System.Drawing.Size(75, 23); //Rozmiar
            this.buttonOK.TabIndex = 0;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze 
            this.buttonOK.Text = "OK";// Tekst dla użytkownika
            this.buttonOK.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click); //Działa, kiedy robimy kliknięcie przyciska
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;//Pobiera lub ustawia okno dialogowe wynik dla formularza. 
            this.buttonCancel.Location = new System.Drawing.Point(236, 233);//roztaszowanie tej części
            this.buttonCancel.Name = "buttonCancel";//imię
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);//Rozmiar
            this.buttonCancel.TabIndex = 1;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze  
            this.buttonCancel.Text = "Anuluj";// Tekst dla użytkownika
            this.buttonCancel.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // tabControlSetting
            // 
            this.tabControlSetting.Controls.Add(this.tabPage2); //Dodawananie nowej tabeli
            this.tabControlSetting.Dock = System.Windows.Forms.DockStyle.Top;//Określa, które krawędzi elementu są powiązane z kontenerem. 
            this.tabControlSetting.Location = new System.Drawing.Point(0, 0);//roztaszowanie tej części
            this.tabControlSetting.Name = "tabControlSetting";//imię
            this.tabControlSetting.SelectedIndex = 0;//Indeks, który odebrany jest (link)
            this.tabControlSetting.Size = new System.Drawing.Size(445, 224);//Rozmiar
            this.tabControlSetting.TabIndex = 2;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze 
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);//Dodawananie grupy
            this.tabPage2.Controls.Add(this.groupBox1);//Dodawananie grupy
            this.tabPage2.Location = new System.Drawing.Point(4, 22);//roztaszowanie tej części
            this.tabPage2.Name = "tabPage2";//imię
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);//Odstępy
            this.tabPage2.Size = new System.Drawing.Size(437, 198);//Rozmiar
            this.tabPage2.TabIndex = 1;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze 
            this.tabPage2.Text = "Kolor";// Tekst dla użytkownika
            this.tabPage2.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która wskazuje, czy użytkownik może nadać fokus na ten element dziłający
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonRhombus);//Dodawananie przycisku
            this.groupBox2.Controls.Add(this.radioButtonRectangle);//Dodawananie przycisku
            this.groupBox2.Controls.Add(this.radioButtonEllipse);//Dodawananie przycisku
            this.groupBox2.Location = new System.Drawing.Point(218, 6);//roztaszowanie tych części
            this.groupBox2.Name = "groupBox2";//imię
            this.groupBox2.Size = new System.Drawing.Size(168, 109);//Rozmiar
            this.groupBox2.TabIndex = 3;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze 
            this.groupBox2.TabStop = false;//Pobiera lub ustawia wartość, która wskazuje, czy użytkownik może nadać fokus na ten element dziłający
            this.groupBox2.Text = "Widok figury geometrycznej";// Tekst dla użytkownika
            // 
            // radioButtonRhombus
            // 
            this.radioButtonRhombus.AutoSize = true; //Robi autorozmiar zgodnie z AutoSizeMode
            this.radioButtonRhombus.Location = new System.Drawing.Point(14, 66);//roztaszowanie tych części
            this.radioButtonRhombus.Name = "radioButtonRhombus";//imię
            this.radioButtonRhombus.Size = new System.Drawing.Size(52, 17);//Rozmiar
            this.radioButtonRhombus.TabIndex = 0;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze  
            this.radioButtonRhombus.TabStop = true;//Pobiera lub ustawia wartość, która wskazuje, czy użytkownik może nadać fokus na ten element dziłający
            this.radioButtonRhombus.Text = "Romb"; //Tekst dla użytkownika
            this.radioButtonRhombus.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            this.radioButtonRhombus.CheckedChanged += new System.EventHandler(this.radioButtonsGraphTypeItem_CheckedChanged); //sprawdzanie zmian
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true; //Robi autorozmiar zgodnie z AutoSizeMode
            this.radioButtonRectangle.Location = new System.Drawing.Point(14, 43); //roztaszowanie tych części
            this.radioButtonRectangle.Name = "radioButtonRectangle";//imię
            this.radioButtonRectangle.Size = new System.Drawing.Size(105, 17);//Rozmiar
            this.radioButtonRectangle.TabIndex = 0;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze  
            this.radioButtonRectangle.TabStop = true;//Pobiera lub ustawia wartość, która wskazuje, czy użytkownik może nadać fokus na ten element dziłający
            this.radioButtonRectangle.Text = "Prostokąt";//Tekst dla użytkownika
            this.radioButtonRectangle.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonsGraphTypeItem_CheckedChanged);//sprawdzanie zmian
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;//Robi autorozmiar zgodnie z AutoSizeMode
            this.radioButtonEllipse.Location = new System.Drawing.Point(14, 20);//roztaszowanie tych części
            this.radioButtonEllipse.Name = "radioButtonEllipse";//imię
            this.radioButtonEllipse.Size = new System.Drawing.Size(46, 17);//Rozmiar
            this.radioButtonEllipse.TabIndex = 0;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze  
            this.radioButtonEllipse.TabStop = true;//Pobiera lub ustawia wartość, która wskazuje, czy użytkownik może nadać fokus na ten element dziłający
            this.radioButtonEllipse.Text = "Ballon";//Tekst dla użytkownika
            this.radioButtonEllipse.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonsGraphTypeItem_CheckedChanged);//sprawdzanie zmian
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonColor3);//Dodawananie przycisku
            this.groupBox1.Controls.Add(this.buttonColr2);//Dodawananie przycisku
            this.groupBox1.Controls.Add(this.buttonColor1);//Dodawananie przycisku
            this.groupBox1.Controls.Add(this.labelGraphItemColor3);//Dodawananie gragu (image)
            this.groupBox1.Controls.Add(this.labelGraphItemColor2);//Dodawananie gragu (image)
            this.groupBox1.Controls.Add(this.labelGraphItemColor1);//Dodawananie gragu (image)
            this.groupBox1.Location = new System.Drawing.Point(8, 6);//roztaszowanie tych części
            this.groupBox1.Name = "groupBox1";//imię
            this.groupBox1.Size = new System.Drawing.Size(204, 109);//Rozmiar
            this.groupBox1.TabIndex = 2;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze 
            this.groupBox1.TabStop = false;//Pobiera lub ustawia wartość, która wskazuje, czy użytkownik może nadać fokus na ten element dziłający
            this.groupBox1.Text = "Wybór koloru figury";//Tekst dla użytkownika
            // 
            // buttonColor3
            // 
            this.buttonColor3.Location = new System.Drawing.Point(135, 77);//roztaszowanie tych części
            this.buttonColor3.Name = "buttonColor3";//imię
            this.buttonColor3.Size = new System.Drawing.Size(50, 23);//Rozmiar
            this.buttonColor3.TabIndex = 2;//Pobiera lub ustawia sekwencje przejścia za pomocą przyciska TAB między elementami formantowane w kontenerze. 
            this.buttonColor3.Tag = "3";//Dane pro element kerowania
            this.buttonColor3.Text = "Kolor 3";//Tekst dla użytkownika
            this.buttonColor3.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            this.buttonColor3.Click += new System.EventHandler(this.buttonsColors_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // buttonColr2
            // 
            this.buttonColr2.Location = new System.Drawing.Point(78, 77);//roztaszowanie tych części
            this.buttonColr2.Name = "buttonColr2";//imię
            this.buttonColr2.Size = new System.Drawing.Size(50, 23);//Rozmiar
            this.buttonColr2.TabIndex = 2;//Pobiera lub ustawia sekwencje przejścia za pomocą przyciska TAB między elementami formantowane w kontenerze. 
            this.buttonColr2.Tag = "2";//Dane pro element kerowania
            this.buttonColr2.Text = "Kolor 2";//Tekst dla użytkownika
            this.buttonColr2.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            this.buttonColr2.Click += new System.EventHandler(this.buttonsColors_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // buttonColor1
            // 
            this.buttonColor1.Location = new System.Drawing.Point(20, 77);//roztaszowanie tych części
            this.buttonColor1.Name = "buttonColor1";//imię
            this.buttonColor1.Size = new System.Drawing.Size(50, 23);//Rozmiar
            this.buttonColor1.TabIndex = 2;//Pobiera lub ustawia sekwencje przejścia za pomocą przyciska TAB między elementami formantowane w kontenerze. 
            this.buttonColor1.Tag = "1";//Dane pro element kierowania
            this.buttonColor1.Text = "Kolor 1";//Tekst dla użytkownika
            this.buttonColor1.UseVisualStyleBackColor = true;//Pobiera lub ustawia wartość, która określa, czy powinno być tło rysowane za pomocą Visual Style (jeśli ono obsługiwane)
            this.buttonColor1.Click += new System.EventHandler(this.buttonsColors_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // labelGraphItemColor3
            // 
            this.labelGraphItemColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;//Wskazuje na styl granic elementu
            this.labelGraphItemColor3.Location = new System.Drawing.Point(135, 20);//roztaszowanie tych części
            this.labelGraphItemColor3.Name = "labelGraphItemColor3";//imię
            this.labelGraphItemColor3.Size = new System.Drawing.Size(50, 50);//Rozmiar
            this.labelGraphItemColor3.TabIndex = 1;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze. 
            this.labelGraphItemColor3.Tag = "3";//Dane pro element kierowania
            this.labelGraphItemColor3.Text = "Trzeci kolor";//Tekst dla użytkownika
            this.labelGraphItemColor3.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBallColor_Paint);//Dziła, kiedy kolor elementu zmienia się
            // 
            // labelGraphItemColor2
            // 
            this.labelGraphItemColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;//Wskazuje na styl granic elementu
            this.labelGraphItemColor2.Location = new System.Drawing.Point(78, 20);//roztaszowanie tych części
            this.labelGraphItemColor2.Name = "labelGraphItemColor2";//imię
            this.labelGraphItemColor2.Size = new System.Drawing.Size(50, 50);//Rozmiar
            this.labelGraphItemColor2.TabIndex = 1;//Pobiera lub ustawia sekwencje przejścia elementami formantowane w kontenerze. 
            this.labelGraphItemColor2.Tag = "2";//Dane pro element kierowania
            this.labelGraphItemColor2.Text = "Drugi kolor";//Tekst dla użytkownika
            this.labelGraphItemColor2.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBallColor_Paint);//Dziła, kiedy kolor elementu zmienia się
            // 
            // labelGraphItemColor1
            // 
            this.labelGraphItemColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;//Wskazuje na styl granic elementu
            this.labelGraphItemColor1.Location = new System.Drawing.Point(20, 20);//roztaszowanie tych części
            this.labelGraphItemColor1.Name = "labelGraphItemColor1";//imię
            this.labelGraphItemColor1.Size = new System.Drawing.Size(50, 50);//Rozmiar
            this.labelGraphItemColor1.TabIndex = 1;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze. 
            this.labelGraphItemColor1.Tag = "1";//Dane pro element kierowania
            this.labelGraphItemColor1.Text = "Pierwszy kolor";//Tekst dla użytkownika
            this.labelGraphItemColor1.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBallColor_Paint);//Działa, kiedy kolor elementu zmienia się
            // 
            // FormGameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);//Pobiera lub ustawia wymiary, dla których element został zaprojektowany. 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;//Pobiera lub ustawia automatyczny tryb skalowania tego elementu. 
            this.ClientSize = new System.Drawing.Size(445, 266);//Rozmiar
            this.Controls.Add(this.tabControlSetting);//Dodawanie nowego elementu zarządzania do macierzy Controls
            this.Controls.Add(this.buttonCancel);//Dodawanie nowego elementu zarządzania do macierzy Controls
            this.Controls.Add(this.buttonOK);//Dodawanie nowego elementu zarządzania do macierzy Controls
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;//Wskazuje na styl granic elementu
            this.MaximizeBox = false;//Pobiera lub ustawia wartość wskazującą czy przycisk 'maksymalizuj' jest ustawiony w formularze. 
            this.MinimizeBox = false;//Pobiera lub ustawia wartość wskazującą czy przycisk 'minimizuj' jest ustawiony w formularze. 
            this.Name = "FormGameSetting";//imię
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;//Pobiera lub ustawia pozycję początkową formularza w czasie wykonywania.
            this.Text = "Ustawienia";//Tekst dla użytkownika
            this.Load += new System.EventHandler(this.FormGameSetting_Load);//Występuje przed początkowo wyświetlaną formą. 
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGameSetting_FormClosed);//Występuje po zamknięciu formy.
            this.tabControlSetting.ResumeLayout(false);//Zarządza zestawem ustawień. 
            this.tabPage2.ResumeLayout(false);//Reprezentuje stronę z TabControl (w tym przypadku 2). 
            this.groupBox2.ResumeLayout(false);//Reprezentuje element Windows, który wyświetla ramkę wokół grupy formantów i, opcjonalnie, nagłówek nad nim.
            this.groupBox2.PerformLayout();//Reprezentuje element Windows, który wyświetla ramkę wokół grupy formantów i, opcjonalnie, nagłówek nad nim.
            this.groupBox1.ResumeLayout(false);//Reprezentuje element Windows, który wyświetla ramkę wokół grupy formantów i, opcjonalnie, nagłówek nad nim.
            this.ResumeLayout(false);//Wraca logiki zwykłe układu. 

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.Button buttonCancel;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.TabControl tabControlSetting;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.TabPage tabPage2;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.Label labelGraphItemColor1;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.Label labelGraphItemColor3;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.Label labelGraphItemColor2;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.GroupBox groupBox1;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.Button buttonColor3;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.Button buttonColr2;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.Button buttonColor1;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.GroupBox groupBox2;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.RadioButton radioButtonRhombus;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.RadioButton radioButtonRectangle;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.RadioButton radioButtonEllipse;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
    }
}