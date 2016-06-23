using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ballons
{
    // Klasa, składa się z kwadratowych komórek 
    // i kształty geometryczne. 
    // Geometryczny kształt może przyjmować różne formy,
    // Przy wyborze gracza do wykazania aktywności.
    public class GraphItem
    {
        // Wygody statycznej zmiennej - można zmienić jeden raz i
        // program zmieni typ kształtu geometrycznego w wszystkich 
        // obiektach klasy GraphItem 
        public static TypeGraphItem CurrentTypeGraphItem;

        // Pomocnicze właściwości są wymagane dla prawidłowej
        // zmiany kolora graczem geometrycznej figury poprzez okno Ustawienia. 
        public int Tag = -1;

        // Współrzędne grafèlementa komórki.
        public Rectangle CellCoordinate;

        // Kolor kształtów geometrycznych. 
        public Color Color = Color.Black;
        public enum TypeGraphItem { tRhombus, tEllipse, tRectangle };

        // Potrzebujemy tylko Invalidate Metody () okno nadrzędne, Metoda ta jest dziedziczona z Control klasy. 
        // Wykorzystane w czasomierze aktywności i zniknięcza. 
        Control Parent = null;

        //Przekaźniki czasowe dają nam toczne działanie aplikacji. 
        Timer timerActive = new Timer();
        Timer timerVanish = new Timer();

        /// <summary>
        /// Konstruktor 
        /// </summary>
        /// <param name="parent">odwołanie do obiektu nadrzędnego okna</param>
        public GraphItem(Control parent)
        {
            Parent = parent;

            // ---- Inicjowanie zegarów ----

            // kształt geometryczny stoper aktywności 
            timerActive.Interval = 40;
            timerActive.Tick += new EventHandler(timerActive_Tick);
            timerActive.Enabled = false;

            //kształtu zniknięcia geometrycznej figury
            timerVanish.Interval = 40;
            timerVanish.Tick += new EventHandler(timerVanish_Tick);
            timerVanish.Enabled = false;
            deltaWidth = inflateSize;
            deltaHeight = inflateSize;
        }


        #region Рисование графэлемента в родительском окне
        /// <summary>
        /// Pędzel ozdobny komórek.
        /// </summary>
        /// <returns>pędzel gotowy</returns>
        Brush BrushCell()
        {
            // Przygotowaniu współrzędnych do rysowania romba
            Point point1 = new Point(CellCoordinate.Left + CellCoordinate.Width / 2, CellCoordinate.Top);
            Point point2 = new Point(CellCoordinate.Left + CellCoordinate.Width, CellCoordinate.Top + CellCoordinate.Height / 2);
            Point point3 = new Point(CellCoordinate.Left + CellCoordinate.Width / 2, CellCoordinate.Top + CellCoordinate.Height);
            Point point4 = new Point(CellCoordinate.Left, CellCoordinate.Top + CellCoordinate.Height / 2);

            Point[] pt = { point1, point2, point3, point4 };

            // Jakiego rodzaju pędzel, takiego i kształu geometryczny.
            GraphicsPath gp = new GraphicsPath();
            
            gp.AddRectangle(CellCoordinate);



            // Kolorowanie kształtu geometrycznego.
            PathGradientBrush pathBrush = new PathGradientBrush(gp);
            pathBrush.SurroundColors = new Color[] { Color.FromArgb(50, 50, 50) };
            pathBrush.CenterPoint = new PointF(CellCoordinate.Left + CellCoordinate.Width / 2, CellCoordinate.Top + CellCoordinate.Height / 2);
            pathBrush.CenterColor = Color.Black;

            return pathBrush;
        }


        int inflateSize = -4; // zmienna duzego pulsowania kształtu geometrycznego
        int deltaWidth = 0;   // zmiany szerokości   
        int deltaHeight = 0;  // zmiana wysokości
        /// <summary>
        /// W kontekście grafiki, rysowania grafiki.
        /// </summary>
        /// <param name="g">okno dane wyjściowe grafiki</param>
        public void Draw(Graphics g)
        {
            g.FillRectangle(BrushCell(), CellCoordinate.X + 1,
                CellCoordinate.Y + 1, CellCoordinate.Width - 1, CellCoordinate.Height - 1);

            // Kiedy figura jest niewidocznej geometrii rysowałem tylko kwadratowe komórke.
            if (visible == false) return;

            // Wsparcie dla placu i zanikanie efektu
            // aktywności w stanie wybrania.
            Rectangle rectInflate = CellCoordinate;
            rectInflate.Inflate(deltaWidth, deltaHeight);


            // ---------- Formowanie kształtu geometrycznego wewnątrz komórki -------------------

            // Przygotowaniu współrzędnych do rysowania rombu
            Point point1 = new Point(CellCoordinate.Left + CellCoordinate.Width / 2, rectInflate.Top);
            Point point2 = new Point(rectInflate.Left + rectInflate.Width, CellCoordinate.Top + CellCoordinate.Height / 2);
            Point point3 = new Point(CellCoordinate.Left + CellCoordinate.Width / 2, rectInflate.Top + rectInflate.Height);
            Point point4 = new Point(rectInflate.Left, CellCoordinate.Top + CellCoordinate.Height / 2);

            Point[] pt = { point1, point2, point3, point4 };

            // Wybierz typ kształtów graficznych.
            GraphicsPath gp = new GraphicsPath();
            switch (CurrentTypeGraphItem)
            {
                case TypeGraphItem.tEllipse:
                    gp.AddEllipse(rectInflate);
                    break;
                case TypeGraphItem.tRectangle:
                    gp.AddRectangle(rectInflate);
                    break;
                case TypeGraphItem.tRhombus:
                    gp.AddPolygon(pt);
                    break;
            }

            // Najmniejsze okna mogą wystąpić
            // Kiedy znikali kształty ujemne wartości szerokości i wysokości.
            // Aby uniknąć błędów, jest przeznaczony ten wiersz. 
            if (rectInflate.Width < 0 || rectInflate.Height < 0) return;


            // Kolorowanie kształtu geometrycznego.
            PathGradientBrush pathBrush = new PathGradientBrush(gp);
            pathBrush.SurroundColors = new Color[] { this.Color };
            pathBrush.CenterPoint = new PointF(CellCoordinate.Left + CellCoordinate.Width / 2, CellCoordinate.Top + CellCoordinate.Height / 2);
            pathBrush.CenterColor = Color.White;



            // Bieżącego rysunku kształty geometryczne.
            switch (CurrentTypeGraphItem)
            {
                case TypeGraphItem.tEllipse:
                    g.FillEllipse(pathBrush, rectInflate);
                    break;
                case TypeGraphItem.tRectangle:
                    g.FillRectangle(pathBrush, rectInflate);
                    break;
                case TypeGraphItem.tRhombus:
                    g.FillPolygon(pathBrush, pt);
                    break;
            }

        }

        #endregion

        #region Свойства графэлемента - видимости, активности, исчезания

        bool visible = false;
        /// <summary>
        /// Niewiem uznaje się nawet znikający kształt geometryczny.
        /// </summary>
        public bool Visible
        {
            get
            {
                if (vanish == true || visible == false)
                    return false;

                return true;
            }
            set
            {
                visible = value;
            }
        }

        bool active = false;
        /// <summary>
        /// właściwość aktywności geometryczne kształty.
        /// </summary>
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
                
                if (active == true)
                {
                    timerActive.Enabled = true;
                }
                else
                {
                    timerActive.Enabled = false;
                    deltaWidth = inflateSize;
                    deltaHeight = inflateSize;
                }
            }
        }

        // Właściwość kształtu znikać.
        bool vanish = false;
        /// <summary>
        /// Gładkie zniknięcie kształtu geometrycznego. 
        /// </summary>
        public bool Vanish
        {
            get
            {
                return vanish;
            }
            set
            {
                vanish = value;

                if (vanish == true)
                {
                    timerVanish.Enabled = true;
                }
            }
        }

        #endregion

        #region Таймеры графэлемента - таймер активности и таймер исчезания
        int k = 1;
        /// <summary>
        /// Stoper aktywności okresowo zwiększa i zmniejsza figury geometrycznej,
        /// tworząc działanie.
        /// </summary>
        void timerActive_Tick(object sender, EventArgs e)
        {
            deltaWidth += 1 * k;
            deltaHeight += 1 * k;
            if (deltaWidth >= -2)
                k = -1;
            else if (deltaWidth <= -7)
                k = 1;

            Parent.Invalidate(CellCoordinate);
        }
   
        /// <summary>
        /// Stoper zniknięcia, na początku grafelement zmnięjsza się
        /// a potem znika.
        /// </summary>
        void timerVanish_Tick(object sender, EventArgs e)
        {

            deltaWidth += -2;
            deltaHeight += -2;

            if (deltaWidth < -14)
            {
                timerVanish.Enabled = false;
                visible = false;
                vanish = false;
                deltaWidth = inflateSize;
                deltaHeight = inflateSize;
            }
            
            Parent.Invalidate(CellCoordinate);
        }
        #endregion 

    }
}
