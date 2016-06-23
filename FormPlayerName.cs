using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ballons
{
    /// <summary>
    /// Okno dialogowe o zmianie nazwy gracza 
    /// </summary>
    public partial class FormPlayerName : Form
    {
        public FormPlayerName()
        {
            InitializeComponent();
        }

        GraphItem graphItemIcon = null;
        public string PlayerName = "Gracz";
        

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            PlayerName = textBoxName.Text;
        }

        private void FormPlayerName_Load(object sender, EventArgs e)
        {
            textBoxName.Text = PlayerName;          // Nazwa bieżącego gracza 
            graphItemIcon = new GraphItem(this);    // Grafelement jako ikona
            graphItemIcon.Visible = true;           // Geometria niewidoczne 
            graphItemIcon.Color = Color.Blue;       // Kolor kształta
            graphItemIcon.Active = true;            // Postać pulsuje 
            graphItemIcon.CellCoordinate = new Rectangle(10, 10, 80, 80); // położenie i wymiary komórki grafelementa 
        }

        
        private void FormPlayerName_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            graphItemIcon.Draw(g);
        }
    }
}
