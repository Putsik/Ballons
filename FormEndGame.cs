using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ballons
{
    /// <summary>
    /// Zostanie wyświetlone okno dialogowe po grze.
    /// </summary>
    public partial class FormEndGame : Form
    {
        /// <summary>
        /// Konstruktor z parametrem
        /// </summary>
        /// <param name="score">iłość nabranych punktów</param>
        public FormEndGame(int score)
        {
            InitializeComponent();

            // Przed pokazaniem okna przygotuje
            // końcową informacje dla gracza.
            labelTablo.Text = "Gra skonczona!\n";
            labelTablo.Text += "Masz " + score.ToString() + " punktów!\n\n";

            labelTablo.Text += "Czy chcesz kontynować?";
        }

        GraphItem graphItemIcon = null;

        private void FormEndGame_Load(object sender, EventArgs e)
        {
            InitGraphItem(ref graphItemIcon, labelPlaceGraphItem);
        }

        /// <summary>
        /// Inicjowanie użycia grafelementa jako animowane ikony.
        /// </summary>
        /// <param name="graphItem">Element graficzny</param>
        /// <param name="parent">Okienko do rysunku</param>
        void InitGraphItem(ref GraphItem graphItem, Control parent)
        {
            graphItem = new GraphItem(parent);
            graphItem.Visible = true;
            graphItem.Color = Color.Red;
            graphItem.Active = true;
            graphItem.CellCoordinate = new Rectangle(-1, -1, parent.Width, parent.Height);
        }

        private void labelPlaceGraphItem_Paint(object sender, PaintEventArgs e)
        {
            graphItemIcon.Draw(e.Graphics);
        }
    }
}
