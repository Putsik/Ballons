using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ballons
{
    // Okno modalne klasy aplikacji.
    public partial class FormGameSetting : Form
    {
        /// <summary>
        /// Własny konstruktor
        /// </summary>
        /// <param name="parent">uzyskać nadrzędny okno zarządzania </param>
        public FormGameSetting(Control parent)
        {
            InitializeComponent();
            formParent = parent;
        }

        Control formParent = null;
        private void FormGameSetting_Load(object sender, EventArgs e)
        {
            InitGraphItem(ref GraphItemColor1, labelGraphItemColor1);
            InitGraphItem(ref GraphItemColor2, labelGraphItemColor2);
            InitGraphItem(ref GraphItemColor3, labelGraphItemColor3);

            GraphItemColor1.Color = ColorGraphItems[0];
            GraphItemColor2.Color = ColorGraphItems[1];
            GraphItemColor3.Color = ColorGraphItems[2];

            switch (CurrentGraphItem)
            {
                case GraphItem.TypeGraphItem.tEllipse:
                    radioButtonEllipse.Checked = true;
                    break;
                case GraphItem.TypeGraphItem.tRectangle:
                    radioButtonRectangle.Checked = true;
                    break;
                case GraphItem.TypeGraphItem.tRhombus:
                    radioButtonRhombus.Checked = true;
                    break;
            }
        }

        public Color[] ColorGraphItems = new Color[Global.AmountColorBalls];

        GraphItem GraphItemColor1 = null;
        GraphItem GraphItemColor2 = null;
        GraphItem GraphItemColor3 = null;
        public GraphItem.TypeGraphItem CurrentGraphItem;

        void InitGraphItem(ref GraphItem ball, Control parent)
        {
            ball = new GraphItem(parent);
            GraphItem.CurrentTypeGraphItem = CurrentGraphItem;
            ball.Visible = true;
            ball.Color = Color.Red;
            ball.Active = true;
            ball.CellCoordinate = new Rectangle(-1, -1, parent.Width, parent.Height);
        }

        /// <summary>
        /// Dla jasności, kolor wybór kształtu geometrycznego,
        /// Narysuj istniejącego modelu postaci,
        /// Narysuj w oknie Label oznakowania,
        /// za pomocą jednego programu obsługi zdarzeń dla wszystkich etykiet (label), 
        /// Funkcja właściwości Tag. 
        /// </summary>
        private void labelBallColor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Label label = (Label)sender;
            // W trybie projektowania, może tylko przypisać Tag właściwość ciąg wartości, 
            // w trybie wykonywania można ustawić tę właściwość do dowolnego obiektu. (jeszcze) 
            string tag = (string)label.Tag; 
            switch (tag)
            {
                case "1":
                    GraphItemColor1.Draw(g);
                    break;
                case "2":
                    GraphItemColor2.Draw(g);
                    break;
                case "3":
                    GraphItemColor3.Draw(g);
                    break;
            }

        }

        /// <summary>
        /// Przyciski wyboru koloru zdarzenia dla kształtów geometrycznych, 
        /// Wybierz przycisk do odpowiednich kształtów geometrycznych
        /// odbywa się za pomocą 'tag' obiekt, 
        /// </summary>
        private void buttonsColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Button button = (Button)sender;
                // W trybie projektowania, może tylko przypisać Tag właściwość ciąg wartości, 
                // w trybie wykonywania można ustawić tę właściwość do dowolnego obiektu. (jeszcze) 
                string tag = (string)button.Tag;
                switch (tag)
                {
                    case "1":
                        ColorGraphItems[0] = colorDlg.Color;
                        break;
                    case "2":
                        ColorGraphItems[1] = colorDlg.Color;
                        break;
                    case "3":
                        ColorGraphItems[2] = colorDlg.Color;
                        break;
                }
                GraphItemColor1.Color = ColorGraphItems[0];
                GraphItemColor2.Color = ColorGraphItems[1];
                GraphItemColor3.Color = ColorGraphItems[2];
            }
        }

        /// <summary>
        /// Wybierz typ kształtów geometrycznych. 
        /// </summary>
        private void radioButtonsGraphTypeItem_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true)
            {
                if (rb.Equals(radioButtonEllipse) == true)
                {
                    GraphItem.CurrentTypeGraphItem = GraphItem.TypeGraphItem.tEllipse;
                }
                else if (rb.Equals(radioButtonRectangle) == true)
                {
                    GraphItem.CurrentTypeGraphItem = GraphItem.TypeGraphItem.tRectangle;
                }
                else
                {
                    GraphItem.CurrentTypeGraphItem = GraphItem.TypeGraphItem.tRhombus;
                }

                formParent.Invalidate();
            }

        }

        
        /// <summary>
        /// Jeśli użytkownik wybierze opcję typu grafelementa, 
        /// naprawić swój wybór naciskając przycisk OK i zaktualizować okno główne. 
        /// </summary>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            CurrentGraphItem = GraphItem.CurrentTypeGraphItem;
            formParent.Invalidate();
        }

        /// <summary>
        /// Jeśli wybór jest anulowany, wracamy poprzednie ustawienia. 
        /// Dzięki zmiennej statycznej GraphItem.CurrentTypeGraphItem
        /// Możemy łatwo powrócić były rodzaju kształty geometryczne.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            GraphItem.CurrentTypeGraphItem = CurrentGraphItem;
            formParent.Invalidate();
        }

        private void FormGameSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Jeśli właśnie zamknięte okna, utożsamiać ten 
            // zniesienia wybranych ustawień.
            buttonCancel_Click(null, null);
        }

       
    }
}
