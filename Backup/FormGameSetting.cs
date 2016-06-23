///////////////////////////////////////////////////////////////////////////////
//
// программы, игры и их исходные коды на http://interestprograms.ru
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;
using System.Windows.Forms;

namespace linesk
{
    // Класс модального окна настроек приложения.
    public partial class FormGameSetting : Form
    {
        /// <summary>
        /// Собственный конструктор
        /// </summary>
        /// <param name="parent">получим управление родительского окна</param>
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
        /// Для наглядности выбора цвета геометрической фигуры,
        /// рисуем действующие модели фигур, 
        /// рисуем в оконных элементах Label,
        /// используя один обработчик события для всех Label,
        /// отличаем по свойству Tag.
        /// </summary>
        private void labelBallColor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Label label = (Label)sender;
            // В дизайнерском режиме свойству Tag можно присваивать только строковые значения,
            // в режиме времени выполнения этому свойству можно присвоить любой объект.(пока)
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
        /// Событие кнопок выбора цвета для геометрических фигур,
        /// выбор кнопки для соответствующей геометрической фигуры 
        /// осуществляется с помощью свойства tag,
        /// </summary>
        private void buttonsColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Button button = (Button)sender;
                // В дизайнерском режиме свойству Tag можно присваивать только строковые значения,
                // в режиме времени выполнения этому свойству можно присвоить любой объект.(пока)
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
        /// Выбор вида геометрической фигуры.
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
        /// Если пользователь выбрал тип графэлемента,
        /// закрепим выбор нажатием кнопки ОК и обновим главное окно.
        /// </summary>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            CurrentGraphItem = GraphItem.CurrentTypeGraphItem;
            formParent.Invalidate();
        }

        /// <summary>
        /// Если выбор отменен, возращаем предыдущие настройки.
        /// Благодаря статической переменной GraphItem.CurrentTypeGraphItem
        /// мы легко возвращаем прежний вид геометрической фигуры.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            GraphItem.CurrentTypeGraphItem = CurrentGraphItem;
            formParent.Invalidate();
        }

        private void FormGameSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Если окно просто закрыли, приравниваем это
            // к отмене выбранных настроек.
            buttonCancel_Click(null, null);
        }

       
    }
}
