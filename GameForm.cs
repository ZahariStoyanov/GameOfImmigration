/*
 * Дадена е двумерна решетка от квадратни клетки, всяка от които може да бъде в едно от три възможни състояния: жива, полужива или мъртва. Всяка клетка може да взаимодейства с всеки от осемте си съседа: хоризонтално, вертикално и по диагонал. В последователните итерации всяка клетка запазва или променя състоянието си по следните правила:
 * 1)	Всяка жива или полужива клетка с по-малко от две съседни клетки в живо или полуживо състояние умира.
 * 2)	Всяка жива или полужива клетка с повече от три съседни клетки в живо или полуживо състояние умира.
 * 3)	Всяка жива или полужива клетка с две или три съседни клетки в живо или полуживо състояние запазва състоянието си и на следващата итерация.
 * 4)	Всяка мъртва клетка с точно три съседни клетки в живо или полуживо състояние се превръща в жива или полужива клетка, в зависимост от болшинството на трите ѝ съседи: ако повечето от съседните ѝ три клетки са живи, тя се превръща в жива, а ако повечето са полуживи, тя се превръща в полужива.
 * 5)	На всяка итерация правилата се прилагат към всички клетки едновременно.
 * Да се реализира софтуерно приложение, в което да се задава настройка за размерите на мрежата и броя итерации на симулация. Първоначално живите, полуживите и мъртвите клетки се определят произволно и в кратки интервали от време да се показват промените в итерациите.
 * */

using Microsoft.VisualBasic.Devices;
using System.Drawing;

namespace Game_of_immigration
{
    public partial class GameForm : Form
    {
        private Game game;
        public GameForm(Game Game)
        {
            game = Game;
            InitializeComponent();
            Subscribe(game);
            game.playGame(0, (int)hUpDown.Value, (int)wUpDown.Value, (int)dUpDown.Value, true);
            Unsubscribe(game);
        }
        private void pButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            pButton.Enabled = false;
            rButton.Enabled = false;
            hUpDown.Enabled = false;
            wUpDown.Enabled = false;
            itUpDown.Enabled = false;
            Subscribe(game);
            game.playGame((int)itUpDown.Value, (int)hUpDown.Value, (int)wUpDown.Value, (int)dUpDown.Value, false);
            Unsubscribe(game);
            Cursor = Cursors.Default;
            pButton.Enabled = true;
            rButton.Enabled = true;
            hUpDown.Enabled = true;
            wUpDown.Enabled = true;
            itUpDown.Enabled = true;
        }
        private void rButton_Click(object sender, EventArgs e)
        {
            Subscribe(game);
            game.playGame(0, (int)hUpDown.Value, (int)wUpDown.Value, (int)dUpDown.Value, true);
            Unsubscribe(game);
        }
        public void Subscribe(Game game)
        {
            game.sendMap += refreshMap;
        }
        public void Unsubscribe(Game game)
        {
            game.sendMap -= refreshMap;
        }

        private void refreshMap(Bitmap bitMap)
        {
            mapBox.Image = bitMap;
            Refresh();
        }
    }
}