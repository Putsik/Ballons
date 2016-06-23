using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace Ballons
{

    public partial class FormMain : Form
    {
        //Przygotować generator jakiekolwiek (random) liczb 
        //dla zainicjalizacji rozpoczęcia gry (zakres grafelementov) 
        //i dodajemy dodać grafelementy podczas gry.
        Random rand = new Random(Environment.TickCount);
        GraphItem[] GItems = null; // Glówne uczęstnicy - elementy graficzne
        GameSetting GameSet = new GameSetting(); // Moduł zapamiętywanie preferencji użytkownika
        string NamePlayer = "Gracz"; // Nazwa domyślnego odtwarzacza (gracza)

        public FormMain()
        {
            InitializeComponent();

            //Przed pobraniem formularza wybieramy pamięć dla wszystkich elementów graficznych. 
            GItems = new GraphItem[Global.NumGraphItems];
            for (int i = 0; i < Global.NumGraphItems; i++)
                GItems[i] = new GraphItem(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Próba ładowania danych z pliku konfiguracji (ustawień), 
            //jeśli on istnieje.
            FromFileIni();

            // Początek inicjowania gry 
            InitNewGame();

            // Obliczenie współrzędnych lokalizacji elementów graficznych 
            ComputeCellsCoordinate();
        }
        
        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            int indexClick = -1; // indeks grafelementa, który kliknieliśmy 

            // Po kliknięciu na widoczny grafelement (kształt geometryczny), robimy go aktywnym, 
            // powinien być migający rozmiar aktywnego elementu, potem wychodzimy z funkcji,
            for (int i = 0; i < 100; i++)
            {
                if (GItems[i].CellCoordinate.Contains(e.X, e.Y) == true)
                {
                    indexClick = i;
                    if (GItems[i].Visible == true)
                    {
                        for (int p = 0; p < Global.NumGraphItems; p++)
                        {
                            GItems[p].Active = false;
                        }
                        GItems[i].Active = true;
                        return;
                    }
                }
            }


            // Po kliknięciu na niewidoczny grafelement (bez kształtu geometrycznego), 
            // przeprowadzić następujące 
            // 1. znaleźć actywny grafelement (jeśli nie, to będzie wykonywany po prostu pusty cykl)
            // 2. Sprawdzamy, czy aktywne grafelement może przesunąć się do miejsca,
            // gdzie użytkownik chce
            // 3. zmieniamy miejscami oraz właściwości actywnego i 'pasywnego' grafèlementu. 
            for (int a = 0; a < 100; a++)
            {
                if (GItems[a].Active == true)
                {
                    if (indexClick != -1)
                    {
                        if (CheckCanMoveGraphItem(GItems[a], GItems[indexClick]) == true)
                        {
                            // zmieniamy miejscami i właściwości obliczonych grafelementów 
                            Color color = GItems[indexClick].Color;
                            GItems[indexClick].Color = GItems[a].Color;
                            GItems[indexClick].Active = false;
                            GItems[a].Color = color;
                            GItems[a].Visible = false;
                            GItems[a].Active = false;
                            GItems[indexClick].Visible = true;
                            Invalidate();

                            // Zrobić krótkie opóźnienie tej funkcji, bez opóźnienia wykonania programu, 
                            // Podnosimy uwagę na przenoszenia grafelementu. 
                            Application.DoEvents();
                            Thread.Sleep(80);

                            // Po chwili dodajemy nowe grafelementy 
                            ShowGraphItems(3);

                            // Zrobić krótkie opóźnienie tej funkcji, bez opóźnienia wykonania programu, 
                            // Podnosimy uwagę na przenoszenia grafelementu. (Znowu).
                            Application.DoEvents();
                            Thread.Sleep(80);

                            // Jeśli mamy sekwencję grafelementów z 
                            // conajmniej 5 sztuk, mamy usunięcie sekwencji .
                            bool hidegraphitems = HideGraphItems();

                            // Zrobić krótkie opóźnienie tej funkcji
                            // Podnosimy uwagę na przenoszenia grafelementu. (Znowu).
                            Application.DoEvents();
                            Thread.Sleep(50);

                            // W końcu mamy formularz i 
                            // mamy ponowne przydzielenie miejsc graczy w stosunku do 
                            // aktualnego gracza.
                            Invalidate();
                            ParseDataPlayers();
                            Invalidate();

                            // Jeśli poszło zniknienie, oznacza to sprawdzenie gry anulujemy 
                            // w przeciwnym razie sprawdzamy grę do pełnego zapełniania 
                            // grafelementami.
                            if (hidegraphitems == false)
                                IsEndGame();

                        }
                    }

                    break;
                }
            }
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            Font font = new Font("Times New Roman", 12);
            int x = GItems[90].CellCoordinate.X + GItems[90].CellCoordinate.Width + 20;
            int y = 40 + toolStrip1.Height;
            
            g.DrawString("Teraz gra -  " + NamePlayer, font, new SolidBrush(Color.White), x, y);


            y = 60 + toolStrip1.Height;
            for (int i = 0; i < GameSet.DRH.Length; i++)
            {
                if (GameSet.DRH[i].CurrentPlayer == true)
                {
                    g.DrawString("Iłość punktów - " + GameSet.DRH[i].Score.ToString(), font, new SolidBrush(Color.White), x, y);
                    break;
                }
            }


            g.DrawString("Najlepsze gracze:", font, new SolidBrush(Color.White), x, y + 20);

            y += 80;
            for (int i = 0; i < GameSet.DRH.Length - 0; i++)
            {
                if (GameSet.DRH[i] != null && GameSet.DRH[i].Score > 0)
                {
                    if (GameSet.DRH[i].CurrentPlayer == false)
                    {
                        g.DrawString((i + 1).ToString() + ". " + GameSet.DRH[i].Name, font, new SolidBrush(Color.White), x, y + i * 20);
                        g.DrawString("\t\t" + GameSet.DRH[i].Score.ToString(), font, new SolidBrush(Color.White), x, y + i * 20);
                    }

                    if (GameSet.DRH[i].CurrentPlayer == true)
                    {
                        Font f = new Font("Times New Roman", 12);
                        g.DrawString((i + 1).ToString() + ". " + GameSet.DRH[i].Name, f, new SolidBrush(Color.Yellow), x, y + i * 20);
                        g.DrawString("\t\t" + GameSet.DRH[i].Score.ToString(), f, new SolidBrush(Color.Yellow), x, y + i * 20);
                    }

                }
            }
           

            for (int i = 0; i < Global.NumGraphItems; i++)
            {
                GItems[i].Draw(g);
            }

            
           
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            // Przy zmianie rozmiaru okna, dostosowamy
            // siatkę współrzędnych, pola i stanu grafelementów.
            ComputeCellsCoordinate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Po zamknięciu aplikacji wszystkie ustawienia są w pliku konfiguracji. 
            ToFileIni();
        }

        private void toolStripButtonNewGame_Click(object sender, EventArgs e)
        {
            InitNewGame();
        }

        private void toolStripButtonFullscreen_Click(object sender, EventArgs e)
        {
            // Przełączanie z pełnego ekranu w trybie okienkowym i z powrotem.
            if (this.TopMost == false)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                toolStripButtonFullscreen.Text = "Okno";
            }
            else
            {
                this.TopMost = false;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                toolStripButtonFullscreen.Text = "Full screen";
            }

        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonGameSetting_Click(object sender, EventArgs e)
        {
            FormGameSetting fgs = new FormGameSetting(this);
            fgs.TopMost = this.TopMost;
            // Kolory klonujemy, w przeciwnym razie proste przypisanie będzie po prostu przypisywać fgs. ColorBalls adres ColorBalls 
            // i zmiana odbędzie się jednocześnie w obu tablicach.
            fgs.ColorGraphItems = (Color[])GameSet.GraphItems.Clone();
            fgs.CurrentGraphItem = GameSet.CurrentGraphItem;
            if (fgs.ShowDialog() == DialogResult.OK)
            {
                // Zapisujemy dane gry do pliku
                GameSet.CurrentGraphItem = fgs.CurrentGraphItem;
                // Zmiana typu grafelementa we wszystkich obiektów klasy GraphItem. 
                GraphItem.CurrentTypeGraphItem = GameSet.CurrentGraphItem;

                // Zmiana kolorów grafelementów. 
                // pewne grafelementy mają jednakowy kolor za pomocą opcji Tab
                // Aby prawidłowo przydzielić nowe kolory. 
                for (int i = 0; i < GItems.Length; i++)
                {
                    if (GItems[i].Color == GameSet.GraphItems[0]) GItems[i].Tag = 0;
                    if (GItems[i].Color == GameSet.GraphItems[1]) GItems[i].Tag = 1;
                    if (GItems[i].Color == GameSet.GraphItems[2]) GItems[i].Tag = 2;
                }

                // na podstawie właściwości Tag mamy nowe kolory. 
                for (int i = 0; i < GItems.Length; i++)
                {
                    if (GItems[i].Tag != -1)
                    {
                        GItems[i].Color = fgs.ColorGraphItems[GItems[i].Tag];
                        this.Invalidate(GItems[i].CellCoordinate);
                    }
                }

                // Zapisujemy dane gry do pliku
                GameSet.GraphItems = fgs.ColorGraphItems;
            }



        }

        private void toolStripButtonChangePlayersName_Click(object sender, EventArgs e)
        {
            // Zmienić imię bieżącego gracza. 
            FormPlayerName fpn = new FormPlayerName();
            fpn.TopMost = this.TopMost;
            fpn.PlayerName = NamePlayer;
            if (fpn.ShowDialog() == DialogResult.OK)
            {
                NamePlayer = fpn.PlayerName;
                for (int p = 0; p < GameSet.DRH.Length; p++)
                {
                    if (GameSet.DRH[p].CurrentPlayer == true)
                    {
                        GameSet.DRH[p].Name = NamePlayer;
                        break;
                    }
                }
                Invalidate();
            }
        }

        #region Инициализация игры, проверка окончания

        /// <summary>
        ///Inicjowanie elementów graficznych danych i bieżącego gracza 
        /// </summary>
        void InitNewGame()
        {
            // Tworzymy wszystkie grafelementy, rozproszonych 
            // w pole gry w kolejności losowej,
            // przypisywanie kolorów losowych elementom graficznym,
            // i wszystkie elementy graficzne nie będą widoczne aż do tego momentu.
            for (int i = 0; i < Global.NumGraphItems; i++)
            {
                int r = rand.Next(Global.AmountColorBalls);
                GItems[i].Color = GameSet.GraphItems[r];
                GItems[i].Visible = false;
            }

            // Instalacja typu grafelementu dla całej tablicy, 
            // za pomocą statycznej zmiennej GraphItem.CurrentTypeGraphItem.
            GraphItem.CurrentTypeGraphItem = GameSet.CurrentGraphItem;

            // Aby rozpocząć grę będą widoczne pierwsze pięć grafelementov. 
            ShowGraphItems(5);

            // Usuniemy etykietę bieżącego gracza od poprzedniego gracza,
            // Ta funkcja występuje przy powtarzaniu gry.
            for (int i = 0; i < GameSet.DRH.Length; i++)
            {
                if (GameSet.DRH[i] != null)
                    GameSet.DRH[i].CurrentPlayer = false;
            }

            // Dodanie nowego gracza do najlepszych graczy,
            // na ostatnie niewiem miejsce, nowemu graczu należy przypisać nazwę bieżącego. 
            GameSet.DRH[Global.NumPlayers - 1].CurrentPlayer = true;
            GameSet.DRH[Global.NumPlayers - 1].Name = NamePlayer;
            GameSet.DRH[Global.NumPlayers - 1].Score = 0;

        }

        // Sprawdzanie końca gry. 
        bool IsEndGame()
        {
            // Jeżeli jest chociąż jeden niewidoczny grafelement
            // Oznacza to, że gra nie jest skończona jeszcze. 
            for (int i = 0; i < Global.NumGraphItems; i++)
            {
                if (GItems[i].Visible == false)
                {
                    return false;
                }
            }

            // Pobierzemy liczbę punktów gracza. 
            int score = 0;
            for (int i = 0; i < GameSet.DRH.Length; i++)
            {
                if (GameSet.DRH[i].CurrentPlayer == true)
                {
                    score = GameSet.DRH[i].Score;
                    break;
                }
            }

            FormEndGame formEndGame = new FormEndGame(score);
            formEndGame.TopMost = this.TopMost;
            if (formEndGame.ShowDialog() == DialogResult.OK)
            {
                toolStripButtonNewGame_Click(null, null);
            }
            return true;
        }

        #endregion

        #region Работа с графэлементами: показ, вычисление координат, возможность перемещения

        /// <summary>
        /// Pokaż grafelementy 
        /// </summary>
        /// <param name="numballs">Iłość grafelementów</param>
        void ShowGraphItems(int numballs)
        {
            // Aplikacja musi mieć listę grafelementów niewiem kształty geometryczne. 
            List<GraphItem> hideGraphItems = new List<GraphItem>();
            for (int i = 0; i < Global.NumGraphItems; i++)
            {
                if (GItems[i].Visible == false)
                    hideGraphItems.Add(GItems[i]);
            }

            // Z każdego nowego pokazu zmieniamy kolory elementów geometrycznych 
            // w przeciwnym razie może być nieskonieczna gra. Tzn. Jeżeli w jednym miejscu były cztery 
            // kształty tego samego koloru i piąty jeszcze pojawi się, to następnie oni znikną, 
            // ale następny pokaz (Jeśli kolor nie zmienia się) cykl powtórzy się. 
            for (int i = 0; i < hideGraphItems.Count; i++)
            {
                int r = rand.Next(Global.AmountColorBalls);
                hideGraphItems[i].Color = GameSet.GraphItems[r];
            }

            // Nowe kształty grafelemenów są wyświetlane tylko w tych miejscach, 
            // gdzie byli one niewidoczne. 
            for (int i = 0; i < numballs; i++)
            {
                int r = rand.Next(hideGraphItems.Count);

                // Wybierzemy niewidoczny kształt 
                int count = 0;
                while (count < hideGraphItems.Count)
                {
                    if (hideGraphItems[r].Visible == true)
                    {
                        // Jeśli trafiliśmy ma widoczny kształt, 
                        // dalej na nowo, aż do tgo momentu, gdy
                        // nie znajdzimy niewidoczny kształt. 
                        r++;
                        if (r == hideGraphItems.Count)
                            r = 0;
                    }
                    else
                    {
                        break;
                    }

                    count++;
                }

                hideGraphItems[r].Visible = true;
                
            }

            Invalidate();
        }

        void ComputeCellsCoordinate()
        {
            int num = (Global.NumGraphItems / 10);
            int lenside = 0;// Długość boków kwadratu o roztaszowaniu grafelementów 

            // należy użyć wymiarów obszaru klienta 
            int width = this.ClientRectangle.Width;
            int height = this.ClientRectangle.Height - toolStrip1.Height;

            // Długość pola grafelementów troche mniejsza od wysokości pola klienta 
            lenside = height - 20;

            // różnica długości boków pola grafèlementów 
            // oraz jego wusokości
            int deltaY = height - lenside;

            // długość boku komórki
            int lenCell = lenside / num;

            // obliczamy po kolumnom lokalizację komórek grafelementów
            int count = 0;
            for (int x = 0; x < num; x++)
            {
                for (int y = 0; y < num; y++)
                {
                    GItems[count].CellCoordinate = new Rectangle(x * lenCell + 10, y * lenCell + deltaY / 2 + toolStrip1.Height, lenCell, lenCell);
                    count++;
                }
            }

            // W wyniku, mamy takie roztaszowanie komórek 
            //////////////////////////////////
            // 0 10 20 30 40 50 60 70 80 90 //
            // 1 11 21 31 41 51 61 71 81 91 //
            // 2 12 22 32 42 52 62 72 82 92 //
            // 3 13 23 33 43 53 63 73 83 93 //
            // 4 14 24 34 44 54 64 74 84 94 //
            // 5 15 25 35 45 55 65 75 85 95 //
            // 6 16 26 36 46 56 66 76 86 96 //
            // 7 17 27 37 47 57 67 77 87 97 //
            // 8 18 28 38 48 58 68 78 88 98 //
            // 9 19 29 39 49 59 69 79 89 99 //
            //////////////////////////////////

            Invalidate();
        }

        /// <summary>
        /// Sprawdź możliwość przenoszenia grafelementa do określonego miejsca, 
        /// który wybrał gracz  
        /// </summary>
        /// <param name="activeBall">aktywny grafelement</param>
        /// <param name="placeBall">możliwe nowe miejsce jego roztaszowanie</param>
        /// <returns>false - nie można, true - można</returns>
        bool CheckCanMoveGraphItem(GraphItem activeGraphItem, GraphItem placeGraphItem)
        {
            int x = activeGraphItem.CellCoordinate.X;
            int y = activeGraphItem.CellCoordinate.Y;



            // Przenieść kształt można tylko poziomo lub lionowo,
            // nie można przekątnie. 
            if (x != placeGraphItem.CellCoordinate.X && y != placeGraphItem.CellCoordinate.Y) return false;

            // Jeśli ma zbiegu grafelementy, przenieść aktywny nie można też 
            // Może się to zdarzyć, gdy gracz probuje przenieść podczas zniknienia grafelement
            // grafelementy w końcu znikający sekwencji zmieniając kolor pozostają widoczne. 
            for (int vanish = 0; vanish < GItems.Length; vanish++)
            {
                if (GItems[vanish].Vanish == true) return false;
            }

            // Obliczyć dla koordynat - sprawdzimy wolną ścieżke
            // dla przenoszenia aktywnego balona. 
            // Kontrola osi Y 
            if (x == placeGraphItem.CellCoordinate.X)
            {
                // Y kordynata nowego miejsca docelowego 
                int yPlaceGraphItem = placeGraphItem.CellCoordinate.Y;
                for (int i = 0; i < 100; i++)
                {
                    // Jeśli co najmniej jeden widzet monitoringu zestaw osi Y zobaczymy
                    // i jest na drodze między nowym miejscem określonego użytkownikiem
                    // i aktywnym grafelementem - przenoszenie elementu niemożliwe 
                    if (GItems[i].CellCoordinate.X == x && GItems[i].Visible == true &&
                        GItems[i].CellCoordinate.Y > Math.Min(y, yPlaceGraphItem) &&
                        GItems[i].CellCoordinate.Y < Math.Max(y, yPlaceGraphItem))
                    {
                        return false;
                    }
                }

                // Jeśli nie istnieje żadnego grafelementu na ścieżkie - możemy przesunąć aktywny grafelement.
                //if (listCheck.Count == 0) return true;
            }
            // Проверка по оси Х
            else if (y == placeGraphItem.CellCoordinate.Y)
            {
                int xPlaceGraphItem = placeGraphItem.CellCoordinate.X;
                for (int i = 0; i < 100; i++)
                {
                    if (GItems[i].CellCoordinate.Y == y && GItems[i].Visible == true &&
                        GItems[i].CellCoordinate.X > Math.Min(x, xPlaceGraphItem) &&
                        GItems[i].CellCoordinate.X < Math.Max(x, xPlaceGraphItem))
                    {
                        //listCheck.Add(GItems[i]);
                        return false;
                    }
                }
            }



            // W innych przypadkach przenieść actywny grafelement nie można.
            return true;
        }

        #endregion
        
        #region Проверка непрерывной последовательности из 5 и более геометрических фигур

        // Sprawdzanie w kolumnach
        bool CheckColumn()
        {
            List<bool> listBool = new List<bool>();
            
            // Sprawdzamy wszystkie kolumny pola dry
            for (int col = 0; col < 10; col++)
            {
                List<GraphItem> column1 = new List<GraphItem>();
                column1.Add(GItems[10 * col + 0]);
                column1.Add(GItems[10 * col + 1]);
                column1.Add(GItems[10 * col + 2]);
                column1.Add(GItems[10 * col + 3]);
                column1.Add(GItems[10 * col + 4]);
                column1.Add(GItems[10 * col + 5]);
                column1.Add(GItems[10 * col + 6]);
                column1.Add(GItems[10 * col + 7]);
                column1.Add(GItems[10 * col + 8]);
                column1.Add(GItems[10 * col + 9]);


                listBool.Add(CheckList(column1));

            }

            for (int i = 0; i < listBool.Count; i++)
            {
                if (listBool[i] == true)
                    return true;
            }
            return false;
        }

        // Sprawdź wiersz po wierszu dla powtarzających się sekwencji 5 i więcej grafèlementów.
        bool CheckRow()
        {
            List<bool> listBool = new List<bool>();
            // Sprawdź wszystkie linie gry na wykrywanie sekwencji. 
            for (int col = 0; col < 10; col++)
            {
                List<GraphItem> column1 = new List<GraphItem>();

                column1.Add(GItems[0 + col]);
                column1.Add(GItems[10 + col]);
                column1.Add(GItems[20 + col]);
                column1.Add(GItems[30 + col]);
                column1.Add(GItems[40 + col]);
                column1.Add(GItems[50 + col]);
                column1.Add(GItems[60 + col]);
                column1.Add(GItems[70 + col]);
                column1.Add(GItems[80 + col]);
                column1.Add(GItems[90 + col]);


                listBool.Add(CheckList(column1));

            }

            for (int i = 0; i < listBool.Count; i++)
            {
                if (listBool[i] == true)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Sprawdź wszystko w górę oraz w prawo dla cyklicznego powtórzenia 
        /// Sekwencji 5 i więcej grafelementów. 
        /// </summary>
        bool CheckDiagonal()
        {
            // Przekąty
            // Pierwsza kolumna do góry na prawo
            List<bool> listBool = new List<bool>();
            int count = 0;
            int k = 1;
            List<GraphItem> dList = new List<GraphItem>();

            // Przekątna grafelementów lokalizacje różnią się 
            // różnicą indeksów, która zawsze jest równa 9,
            // czyli zacząć od lewego 5 miejsca od góry (4 miejsce i powyżej są mniej niż 5 miejsc na linii ukośnej), 
            // i dodajemy za każdym razem 9 zatem pojawia się łańcuch miejsc prekątnie w górę-prawo, 
            // Po sprawdzeniu 5, zaczynamy 6 и +9 = 15 + 9 = 24 + 9 = 33 + 9 = 42 + 9 = 51 + 9 = 60 i tp.
            for (int i = 0; i < (5 + count); i++)
            {
                int d1 = (4 + count) + 9 * i;
                dList.Add(GItems[d1]);
               

                if (k == -1 && count == 4)
                    break;

                if ((5 + count) == (i + 1))
                {
                    i = -1;

                    if (count == 5)
                        k = -1;

                    count += k;
                    listBool.Add(CheckList(dList));
                    dList.Clear();

                }


            }



            // Zostawinie przekątnej w górę w prawo po połowie
            // Podobnie jak powyżej - 19 + 9 = 28 + 9 = 37 + 9 = 46 + 9 = 55 + 9 = 64 + 9 = 73 + 9 = 82 + 9 = 91,
            // i dalej 29 + 9 = 38 + 9 = 47 + 9 = 56 + 9 = 65 + 9 = 74 + 9 = 83 + 9 = 92 i tp.
            count = 4;
            k = -1;
            dList.Clear();
            for (int i = 0; i < (5 + count); i++)
            {
                int d1 = 0;

                d1 = 19 + 10*(4-count)  + 9*i;
                dList.Add(GItems[d1]);

                if (k == 1 && count == 1)
                    break;

                if ((5 + count) == (i + 1))
                {
                    i = -1;

                    if (count == 0)
                        k = 1;

                    count += k;
                    listBool.Add(CheckList(dList));
                    dList.Clear();


                }

                
               
            }

            for (int i = 0; i < listBool.Count; i++)
            {
                if (listBool[i] == true)
                    return true;
            }

            return false;
                                         
        }

        /// <summary>
        /// Sprawdź po przekątnej, aż do prawej w dól cyklicznej 
        /// sekwencji 5 i więcej grafelementów. 
        /// </summary>
        bool CheckDiagonal2()
        {
            // Przekątne  
            // Pierwsza kolumna w prawo na dół,
            // Zaczynając na dole lewej kolumny do zera
            //bool[] killballs = new bool[2] { false, false };
            List<bool> listBool = new List<bool>();
            int count = 0;
            int k = 1;
            List<GraphItem> dList = new List<GraphItem>();

            // Jak pierwsza przekątna, różnica indeksy tylko 11 jednostek. 
            // Zaczynając od 0 miejsca z najdłuższa przekątna 
            // 0 + 11 = 11 + 11 = 22 + 11 = 33 + 11 = 44 + 11 = 55 + 11 = 66 + 11 = 77 + 11 = 88 + 11 = 99, dalej na 1 miejsce
            // 1 + 11 = 12 + 11 = 23 + 11 = 34 + 11 = 45 + 11 = 56 + 11 = 67 + 11 = 78 + 11 = 89 i tp.
            for (int i = 0; i < (5 + count); i++)
            {
                int d1 = 0;

                d1 = (5 - count) + 11 * i;
                dList.Add(GItems[d1]);

                if (k == -1 && count == 4)
                    break;

                if ((5 + count) == (i + 1))
                {
                    i = -1;

                    if (count == 5)
                        k = -1;

                    count += k;

                    listBool.Add(CheckList(dList));
                    dList.Clear();
                }

             
            }




            // Pozostałości po przekątnej po połowie w dół w prawo, zaczynając od 10 do 50.
            // Przekątna grafelementów lokalizacje różnią się 
            // różnicą indeksów, która zawsze jest równa 11, 
            // czyli zaczynamy od lewej 10 miejsc z góry i do 50 (60 miejsce i po prawej stronie są mniej niż 5 miejsc na linii przekątnej),
            // i za każdym razem, możemy dodać 11 w ten sposób pojawia się łańcuch miejsc przekątną w dół w prawo, 
            // 10 + 11 = 21 + 11 = 32 + 11 = 43 + 11 = 54 + 11 = 65 + 11 = 76 + 11 = 87 + 11 = 98, przechodzimy na 20 miejsce
            // 20 + 11 = 31 + 11 = 42 + 11 = 53 + 11 = 64 + 11 = 75 + 11 = 86 + 11 = 97 i tp.
            count = 4;
            k = -1;
            dList.Clear();
            for (int i = 0; i < (5 + count); i++)
            {
                int d1 = 0;

                d1 = 10 + 10 * (4 - count) + 11 * i;
                dList.Add(GItems[d1]);

                if (k == 1 && count == 1)
                    break;

                if ((5 + count) == (i + 1))
                {
                    i = -1;

                    if (count == 0)
                        k = 1;

                    count += k;

                    listBool.Add(CheckList(dList));
                    dList.Clear();

                }

            }


            for (int i = 0; i < listBool.Count; i++)
            {
                if (listBool[i] == true)
                    return true;
            }
            
            return false;
        }

        /// <summary>
        /// Sprawdź każdy wiersz na konsekwencje graficznych elementów
        /// jednego koloru 5 oraz więcej elementów. 
        /// </summary>
        /// <param name="parseList">Suma elementów graficznych w linii</param>
        /// <returns>true - istnieje sekwencja elementów graficznych z 5 lub więcej sztuk , inny przypadek - false </returns>
        bool CheckList(List<GraphItem> parseList)
        {
            bool hidegraphitems = false;
            
            Color color;
            // Obsługa listy zagrożonych grafèlementov 
            List<GraphItem> hideList = new List<GraphItem>();
            for (int i = 0; i < parseList.Count; i++)
            {
                color = parseList[i].Color; // Zapamiętamy kolor zbadany przed bieżącego grafelementa 
                hideList.Add(parseList[i]); // Dodamy w pomocniczę listę grafelementy zbadane z linii 

                // Jeśli grafelement już niewiem możemy zrobić spisek pomocniczy pustym
                // i przecodzimy do następnego cyklu.
                if (parseList[i].Visible == false) { hideList.Clear(); continue; }

                // porównamy kolor między pierwszym grafelementem oraz pozostałymi 
                for (int p = i + 1; p < parseList.Count; p++)
                {
                    // Jeśli kolor kolejnego grafelementa jednakowy z kolorem pierszego 
                    // dodajemy go do listy. Tylko spotkamy inny kolor 
                    // skonczamy cykł.
                    if (parseList[p].Visible == true && parseList[p].Color == color)
                        hideList.Add(parseList[p]);
                    else
                    {
                        break;
                    }
                }

                // Teraz sprawdzmy listę pomocniczę, jeśli w niej 
                // 5 i więcej grafelementów, umieściamy na zniknięcie. 
                if (hideList.Count >= 5)
                {
                    //wszystkie grafèlementy w pomocnika umieściamy na zniknięcie
                    for (int n = 0; n < hideList.Count; n++)
                    {
                        hideList[n].Vanish = true;
                    }
                    // Za każdy znięknięły element dodalemy graczowi 10 punktów
                    for (int cp = 0; cp < GameSet.DRH.Length; cp++)
                    {
                        if (GameSet.DRH[cp].CurrentPlayer == true)
                        {
                            GameSet.DRH[cp].Score += hideList.Count * 10;
                            break;
                        }
                    }

                    // Jeśli znajdziesz nawet pojedynczej sekwencji 5 i więcej grafèlementov
                    // zwracamy jako true.
                    hidegraphitems = true;

                    // Odtworzyć dźwięk zniknięcia grafelementów. 
                    // żródło odebramy po szhematu ("namespace.pathresource");
                    Stream res = this.GetType().Assembly.GetManifestResourceStream("Ballons.soundvanish.wav");
                    SoundPlayer sp = new SoundPlayer(res);
                    sp.PlaySync();
                    //sp.Play();
                    
                }

                hideList.Clear();
            }

            return hidegraphitems;
        }

        /// <summary>
        /// Ocenić sekwencję 5 i więcej grafelementów
        /// i kolejne zniknięcia. Zwracaną wartość
        /// użyj, aby określić odpowiednie 
        /// koniec gry.
        /// </summary>
        bool HideGraphItems()
        {
            // Sprawdź wszystkie linie 5 lub więcej grafelementów, 
            // pionowy, poziomy, ukośny. 
            // Jeśli taka sekwencja jest zwracamy true
            // aby określić poprawny koniec gry.

            List<bool> listBool = new List<bool>();
            listBool.Add(CheckColumn());
            listBool.Add(CheckRow());
            listBool.Add(CheckDiagonal());
            listBool.Add(CheckDiagonal2());

            // Jeżeli co najmniej jest jedna sekwencja, oznacza to, że gra nie jest skończona.
            for (int i = 0; i < listBool.Count; i++)
            {
                if (listBool[i] == true)
                    return true;
            }

            return false;

        }

        #endregion

        #region Чтение из файла и запись в файл настроек игры

        /// <summary>
        /// Nagrywać wszystkie ustawienia do pliku na dysku w .lin
        /// folder, w którym znajduje się plik wykonywalny.
        /// </summary>
        void ToFileIni()
        {
            // Na wsielki przypadek działanie pliku robimy w bloku try
            // ponieważ plik jest zewnętrznym dla programu, 
            // nie jest on całkowicie przywiązany do aplikacji.
            try
            {
                // Zapamiętam, położenie i wymiary okna głównego aplikacji. 
                GameSet.Bounds = this.Bounds;

                // Plik konfiguracyjny zawsze zostanie utworzony w pliku lokalizacji aplikacji. 
                string filePath = Application.StartupPath + "\\settings.lin";
                FileStream fileStream = File.Create(filePath);

                // Dane będą przechowywane w kodzie binarnym 
                BinaryFormatter bf = new BinaryFormatter();

                // Gdy aplikacja będzie zamkmięta, zresetulemy etykiety od bieżącego gracza. 
                for (int i = 0; i < GameSet.DRH.Length; i++)
                {
                    GameSet.DRH[i].CurrentPlayer = false;
                }
                bf.Serialize(fileStream, GameSet);
                fileStream.Close();
            }
            catch
            {
                
            }

        }

        /// <summary>
        /// Odczyt ustawień z pliku. 
        /// </summary>
        void FromFileIni()
        {
            FileStream fileStream = null;
            try
            {
                string filePath = Application.StartupPath + "\\settings.lin";

                FileInfo fi = new FileInfo(filePath);
                if (fi.Exists == false)
                    return;

                fileStream = File.OpenRead(filePath);
                BinaryFormatter bf = new BinaryFormatter();
                GameSet = (GameSetting)bf.Deserialize(fileStream);

                // Kiedy będzie ładowanie danych gry graczy usuniemy zbędne graczy
                // z tych samych nazw, jeden z nich z największą ilością punktów, zostanie po
                //procedurze danych tablicy gry posortujemy punkty.
                for (int i = 0; i < GameSet.DRH.Length; i++)
                {
                    for (int j = i+1; j < GameSet.DRH.Length; j++)
                    {
                        if (GameSet.DRH[j].Score != 0 && GameSet.DRH[i].Name == GameSet.DRH[j].Name)
                        {
                            GameSet.DRH[j].Score = 0; // gracz ma zero punktów - zostanie usunięty z listy 
                        }
                    }
                }

                Array.Sort(GameSet.DRH, new SortRecordHolders());
                
            }
            catch
            {
                
            }
            finally // Ten blok jest wykonywany w każdym przypadku 
            {
                // W każdym przypadku spróbujemy plik ustawień po użyciu zamknąć. 
                if(fileStream != null)
                    fileStream.Close();

                // Jeśli rozmiar okna jest bardzo duży lub bardzo mały lub okno pojawiło się poza ekranem  
                // przywracamy okno aplikacji do dopuszczalnego rozmiaru i położenia. 
                if (GameSet.Bounds.Width > (Screen.PrimaryScreen.Bounds.Width - 20) ||
                    GameSet.Bounds.Height > (Screen.PrimaryScreen.Bounds.Height - 20) ||
                    GameSet.Bounds.Width < 500 || GameSet.Bounds.Height < 300 ||
                    GameSet.Bounds.Left < 0 || GameSet.Bounds.Top < 0 ||
                    GameSet.Bounds.Left > Screen.PrimaryScreen.Bounds.Right || GameSet.Bounds.Top > Screen.PrimaryScreen.Bounds.Bottom
                    )
                {
                    this.Width = 640;
                    this.Height = 480;

                }
                else
                {
                    this.Bounds = GameSet.Bounds;
                }
            }

        }

        #endregion
        
        #region Сортировка игроков по очкам

        // Sprawdzamy dane dla liczby punktów graczy i roztaszowamy
        // na podstawie tego miejsca nagrodowe. 
        // Algorytm punktu przyznawania nagród w miejscach między graczami.
        // 1. Rozpoczyna się nowa gra dodajemy gracza na szóste miejsce w tablicy danych graczów.
        // 2. Po każdy krok sortujemy obiekt tablica gracze: 
        // 1) Jeśli wskaźnik gracza spadł, on przenosi się do wyższej nagrody. 
        void ParseDataPlayers()
        {
            // Porównywalny wskaźnik gracza do kroku i po nim. 
            int index = -1;
            for (int i = 0; i < GameSet.DRH.Length; i++)
            {
                if (GameSet.DRH[i].CurrentPlayer == true)
                {
                    index = i;
                    Array.Sort(GameSet.DRH, new SortRecordHolders());
                    break;
                }
            }

            // Jeżeli po posortowaniu indeks gracza spadł
            // następnie on przeniósł się do nowego
            // większego miejsca nagrodowego.
            for (int i = 0; i < GameSet.DRH.Length; i++)
            {
                if (GameSet.DRH[i].CurrentPlayer == true)
                {
                    // Jeśli gracz przeniósł się do pierwszego miejsca, gratulujemy. 
                    if (i < index && i == 0)
                    {
                        // Dodajemy muzykę pozdrowienia
                        Stream res = (Stream)this.GetType().Assembly.GetManifestResourceStream("Ballons.tush.wav");
                        SoundPlayer sp = new SoundPlayer(res);
                        sp.Play();
                    }
                    break;
                }
            }
            
        }

        // Klasa pomocnicza, aby posortować graczy, implementujący IComparer interfejsu ,
        // Interfejs umożliwia programiście tworzenie klas ze specjalnymi (napisany przez samego siebie)
        // funkcji porównania różnych rzeci. 
        // Jest zadeklarowana wewnątrz klasy.
        public class SortRecordHolders : IComparer
        {
            //realizowanie interfejsu IComparer 
            public int Compare(object o1, object o2)
            {
                DataRecordsman drh1 = (DataRecordsman)o1;
                DataRecordsman drh2 = (DataRecordsman)o2;

                // Porównanie punktów, przewagę mają większe punkty.
                int result = drh2.Score.CompareTo(drh1.Score);

                // Jeżeli punkty są równe dostaje zwiczęstwa gracz który 
                // zdobył punkty przed bieżącego gracza.
                if (result == 0)
                    result = drh1.CurrentPlayer.CompareTo(drh2.CurrentPlayer);

                return result;
            }

        }

        #endregion

    }


    
}
