namespace Ballons
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));//Zapewnia proste funkcje wyliczanie zasobów dla komponentu lub obiektu. Componentresourcemanager Klasa ResourceManager. 
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();//nowy obiekt
            this.toolStripButtonNewGame = new System.Windows.Forms.ToolStripButton();//nowy obiekt
            this.toolStripButtonFullscreen = new System.Windows.Forms.ToolStripButton();//nowy obiekt
            this.toolStripButtonChangePlayersName = new System.Windows.Forms.ToolStripButton();//nowy obiekt
            this.toolStripButtonGameSetting = new System.Windows.Forms.ToolStripButton();//nowy obiekt
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();//nowy obiekt
            this.toolStrip1.SuspendLayout();//Tymczasowo zawiesza logikę układ elementu.
            this.SuspendLayout();//Tymczasowo zawiesza logikę układ elementu.
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewGame,
            this.toolStripButtonFullscreen,
            this.toolStripButtonChangePlayersName,
            this.toolStripButtonGameSetting,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);//roztaszowanie
            this.toolStrip1.Name = "toolStrip1";//imię
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);//Rozmiar
            this.toolStrip1.TabIndex = 0;//Pobiera lub ustawia sekwencje przejścia między elementami formantowane w kontenerze
            this.toolStrip1.Text = "toolStrip1";//Tekst dla użytkownika
            // 
            // toolStripButtonNewGame
            // 
            this.toolStripButtonNewGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;//Pobiera lub ustawia wartość, która wskazuje, czy tekst i obraz wyświetla na ToolStripItem. 
            this.toolStripButtonNewGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewGame.Image")));//Abstrakcyjna klasa podstawowa, która zapewnia funkcjonalność Bitmap i Metafile dla klasy pochodnej. 
            this.toolStripButtonNewGame.ImageTransparentColor = System.Drawing.Color.Magenta;//Pobiera lub ustawia kolor, aby traktować jako przezroczysty obraz ToolStripItem.
            this.toolStripButtonNewGame.Name = "toolStripButtonNewGame";//imię
            this.toolStripButtonNewGame.Size = new System.Drawing.Size(73, 22);//Rozmiar
            this.toolStripButtonNewGame.Text = "Nowa gra";//Tekst dla użytkownika
            this.toolStripButtonNewGame.Click += new System.EventHandler(this.toolStripButtonNewGame_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // toolStripButtonFullscreen
            // 
            this.toolStripButtonFullscreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;//Pobiera lub ustawia wartość, która wskazuje, czy tekst i obraz wyświetla na ToolStripItem. 
            this.toolStripButtonFullscreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFullscreen.Image")));//Abstrakcyjna klasa podstawowa, która zapewnia funkcjonalność Bitmap i Metafile dla klasy pochodnej. 
            this.toolStripButtonFullscreen.ImageTransparentColor = System.Drawing.Color.Magenta;//Pobiera lub ustawia kolor, aby traktować jako przezroczysty obraz ToolStripItem.
            this.toolStripButtonFullscreen.Name = "toolStripButtonFullscreen";//imię
            this.toolStripButtonFullscreen.Size = new System.Drawing.Size(92, 22);//Rozmiar
            this.toolStripButtonFullscreen.Text = "Full screen";//Tekst dla użytkownika
            this.toolStripButtonFullscreen.Click += new System.EventHandler(this.toolStripButtonFullscreen_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // toolStripButtonChangePlayersName
            // 
            this.toolStripButtonChangePlayersName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;//Pobiera lub ustawia wartość, która wskazuje, czy tekst i obraz wyświetla na ToolStripItem. 
            this.toolStripButtonChangePlayersName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonChangePlayersName.Image")));//Abstrakcyjna klasa podstawowa, która zapewnia funkcjonalność Bitmap i Metafile dla klasy pochodnej. 
            this.toolStripButtonChangePlayersName.ImageTransparentColor = System.Drawing.Color.Magenta;//Pobiera lub ustawia kolor, aby traktować jako przezroczysty obraz ToolStripItem.
            this.toolStripButtonChangePlayersName.Name = "toolStripButtonChangePlayersName";//imię
            this.toolStripButtonChangePlayersName.Size = new System.Drawing.Size(90, 22);//Rozmiar
            this.toolStripButtonChangePlayersName.Text = "Zmień imię";//Tekst dla użytkownika
            this.toolStripButtonChangePlayersName.Click += new System.EventHandler(this.toolStripButtonChangePlayersName_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // toolStripButtonGameSetting
            // 
            this.toolStripButtonGameSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;//Pobiera lub ustawia wartość, która wskazuje, czy tekst i obraz wyświetla na ToolStripItem. 
            this.toolStripButtonGameSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGameSetting.Image")));//Abstrakcyjna klasa podstawowa, która zapewnia funkcjonalność Bitmap i Metafile dla klasy pochodnej. 
            this.toolStripButtonGameSetting.ImageTransparentColor = System.Drawing.Color.Magenta;//Pobiera lub ustawia kolor, aby traktować jako przezroczysty obraz ToolStripItem.
            this.toolStripButtonGameSetting.Name = "toolStripButtonGameSetting";//imię
            this.toolStripButtonGameSetting.Size = new System.Drawing.Size(71, 22);//Rozmiar
            this.toolStripButtonGameSetting.Text = "Ustawienia";//Tekst dla użytkownika
            this.toolStripButtonGameSetting.Click += new System.EventHandler(this.toolStripButtonGameSetting_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;//Pobiera lub ustawia wartość, która wskazuje, czy tekst i obraz wyświetla na ToolStripItem. 
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));//Abstrakcyjna klasa podstawowa, która zapewnia funkcjonalność Bitmap i Metafile dla klasy pochodnej. 
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;//Pobiera lub ustawia kolor, aby traktować jako przezroczysty obraz ToolStripItem.
            this.toolStripButtonExit.Name = "toolStripButtonExit";//imię
            this.toolStripButtonExit.Size = new System.Drawing.Size(45, 22);//Rozmiar
            this.toolStripButtonExit.Text = "Wyjście";//Tekst dla użytkownika
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);//Działa, kiedy robimy kliknięcie przyciska
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);//Pobiera lub ustawia wymiary, dla których element został zaprojektowany. 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;//Pobiera lub ustawia automatyczny tryb skalowania tego elementu. 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(810, 640);
            this.Controls.Add(this.toolStrip1);//Dodawanie nowego elementu zarządzania do macierzy Controls
            this.DoubleBuffered = true; //Pobiera lub ustawia wartość wskazującą, czy powierzchni tego elementu należy odświeżyć za pomocą drugorzędnego buforu do zmniejszenia lub zapobieżenia migowania. 
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));//Obiekt jako icon
            this.MinimumSize = new System.Drawing.Size(400, 300);//Rozmiar minimalny
            this.Name = "FormMain";//imię
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;//Pozycja początkowa
            this.Text = "Ballons";//Tekst dla użytkownika
            this.Load += new System.EventHandler(this.Form1_Load);//Występuje przed początkowo wyświetlaną formą. 
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);//Działa, kiedy kolor elementu zmienia się
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);//Działa, kiedy robimy kliknięcie przyciska
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);//Występuje po zamknięciu formy.
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.toolStrip1.ResumeLayout(false);//Wraca logiki zwykłe układu. 
            this.toolStrip1.PerformLayout();//Wymusza kontrolki ma być stosowana logikę układu do wszystkich jej kontrolek podrzędnych.
            this.ResumeLayout(false);//Wraca logiki zwykłe układu. 
            this.PerformLayout();//Wymusza kontrolki ma być stosowana logikę układu do wszystkich jej kontrolek podrzędnych.

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.ToolStripButton toolStripButtonNewGame;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.ToolStripButton toolStripButtonFullscreen;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.ToolStripButton toolStripButtonGameSetting;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
        private System.Windows.Forms.ToolStripButton toolStripButtonChangePlayersName;//Prywatny dostęp jest najmniej dozwolonym poziomem dostępu
    }
}

