/*
 * Дадена е двумерна решетка от квадратни клетки, всяка от които може да бъде в едно от три възможни състояния: жива, полужива или мъртва. Всяка клетка може да взаимодейства с всеки от осемте си съседа: хоризонтално, вертикално и по диагонал. В последователните итерации всяка клетка запазва или променя състоянието си по следните правила:
 * 1)	Всяка жива или полужива клетка с по-малко от две съседни клетки в живо или полуживо състояние умира.
 * 2)	Всяка жива или полужива клетка с повече от три съседни клетки в живо или полуживо състояние умира.
 * 3)	Всяка жива или полужива клетка с две или три съседни клетки в живо или полуживо състояние запазва състоянието си и на следващата итерация.
 * 4)	Всяка мъртва клетка с точно три съседни клетки в живо или полуживо състояние се превръща в жива или полужива клетка, в зависимост от болшинството на трите ѝ съседи: ако повечето от съседните ѝ три клетки са живи, тя се превръща в жива, а ако повечето са полуживи, тя се превръща в полужива.
 * 5)	На всяка итерация правилата се прилагат към всички клетки едновременно.
 * Да се реализира софтуерно приложение, в което да се задава настройка за размерите на мрежата и броя итерации на симулация. Първоначално живите, полуживите и мъртвите клетки се определят произволно и в кратки интервали от време да се показват промените в итерациите.
 * */

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;

namespace Game_of_immigration
{
    public class Game
    {
        public delegate void SendMap(Bitmap bitMap);
        public event SendMap? sendMap;

        // The map dimensions are fixed
        private readonly int[] gameHW = { 1000, 1000 };

        // We have a resizable window that zooms in/out on the map
        private int[] vizHW;

        private int density;

        private readonly byte[] values = { 0, 1, 10 }; // Possible values per cell: 0 = dead, 1 = half-alive, 10 = alive
        private Random rand = new Random();
        private byte[,] gameMap;
        private Dictionary<byte, Dictionary<byte, byte>> newStates; // Contains conditions for a cell to be (half-)alive
                                                                    // Format - Dictionary<current, Dictionary<naighbours, new>>
        public Game()
        {
            density = 0;
            newStates = new Dictionary<byte, Dictionary<byte, byte>>()
            {
                { 0, new Dictionary<byte, byte>(){ { 3, 1 }, { 12, 1 }, { 21, 10 }, { 30, 10 } } },
                { 1, new Dictionary<byte, byte>(){ { 2, 1 }, { 3, 1 }, { 11, 1 }, { 12, 1 }, { 20, 1 }, { 21, 1 }, { 30, 1 } } },
                { 10, new Dictionary<byte, byte>(){ { 2, 10 }, { 3, 10 }, { 11, 10 }, { 12, 10 }, { 20, 10 }, { 21, 10 }, { 30, 10 } } }
            };
            vizHW = new int[2];
            gameMap = new byte[gameHW[0], gameHW[1]];
        }
        public void randomize(int density)
        {
            Parallel.For(0, gameHW[0], (r) =>
                Parallel.For(0, gameHW[1], (c) =>
                {
                    int ind = rand.Next(0, 100);
                    gameMap[r, c] = (byte)(ind < density / 2 - 1 ? 10 : ind < density - 1 ? 1 : 0);
                }));
            this.density = density;
        }

        public Bitmap prepMap()
        {
            Dictionary<byte, Color> pixels = new Dictionary<byte, Color>()
            {
                { 0, Color.FromArgb(255, 0, 0, 127) },
                { 1, Color.FromArgb(255, 255, 255, 127) },
                { 10, Color.FromArgb(255, 255, 0, 0) }
            };
            Bitmap bitMap;
            int vizW;
            int vizW_;
            int vizH;
            int vizH_;
            if (vizHW[0] <= 100 && vizHW[1] <= 100)
            {
                vizW = 5 * vizHW[1] - 1;
                vizW_ = vizW - 1;
                vizH = 5 * vizHW[0] - 1;
                vizH_ = vizH - 1;
            }
            else
            {
                vizW = vizW_ = vizHW[1];
                vizH = vizH_ = vizHW[0];
            }
            bitMap = new Bitmap(vizW, vizH);
            Graphics graphics = Graphics.FromImage(bitMap);
            Pen pen = new Pen(Color.Black, (float)vizHW[1] / 200 + (float)vizHW[0] / 200);

            for (int r = 0; r < vizHW[0]; r++)
            {
                int r_ = r + (gameHW[0] - vizHW[0]) / 2;
                int R = 5 * r;
                int R_ = R - 1;
                if (r > 0 && vizHW[0] <= 100 && vizHW[1] <= 100) graphics.DrawLine(pen, 0, R_, vizW_, R_);
                for (int c = 0; c < vizHW[1]; c++)
                {
                    int C = 5 * c;
                    int C_ = C - 1;
                    if (c > 0 && vizHW[0] <= 100 && vizHW[1] <= 100) graphics.DrawLine(pen, C_, 0, C_, vizH_);
                    if (pixels.TryGetValue(gameMap[r_, c + (gameHW[1] - vizHW[1]) / 2], out Color pixel))
                    {
                        if (vizHW[1] <= 100 && vizHW[0] <= 100)
                            graphics.FillRectangle(new SolidBrush(pixel), C, R, 5, 5);
                        else
                            bitMap.SetPixel(c, r, pixel);
                    }
                }
            }
            return bitMap;
        }

        //public void playGame(int iterations)
        public void playGame(int iterations, int WH, int WW, int density, bool forceRand)
        {
            /*
             * We always process the entire map.
             * Then we prepare an image that only vizualizes the zoom window.
             * This image is sent to the GUI.
             * */
            var timer = new Stopwatch();
            timer.Start();
            if (this.density != density || forceRand)
            {
                randomize(density);
            }
            for (int it = 0; it < iterations || iterations == 0; it++)
            {
                ScaleVizualizer(iterations, WH, WW, it);
                if (iterations == 0) iterations++;
                else
                {
                    byte[,] neighbours = new byte[gameHW[0], gameHW[1]];
                    AnalyzeNeighbours(neighbours);
                    ReactToNeighbours(neighbours);
                    timer.Stop();
                    TimeSpan timeTaken = timer.Elapsed;
                    int ms = (int)timeTaken.TotalMilliseconds;
                    Thread.Sleep(Math.Max(0, 500 - ms)); // This way we ensure a relatively consistent framerate regardles of the zoom.
                    timer.Restart();
                }
                sendMap?.Invoke(prepMap()); // Replaces "if (sendMap != null) sendMap(prepMap());" since v6
            }
            timer.Stop();
        }

        private void ScaleVizualizer(int iterations, int WH, int WW, int it)
        {
            vizHW[0] -= vizHW[0] == WH ? 0 : iterations / 2 == it ? vizHW[0] - WH : (vizHW[0] - WH) / (iterations / 2 - it);
            vizHW[1] -= vizHW[1] == WW ? 0 : iterations / 2 == it ? vizHW[1] - WH : (vizHW[1] - WW) / (iterations / 2 - it);
        }
        //public static int SafeDivide(int a, int b) => b == 0 ? a : a / b;

        private void AnalyzeNeighbours(byte[,] neighbours)
        {
            Parallel.For(0, gameHW[0], r =>
            {
                int upper = Math.Max(0, 1 - r);
                int lower = Math.Min(3, gameHW[0] + 1 - r);
                Parallel.For(0, gameHW[1], c =>
                {
                    int left = Math.Max(0, 1 - c);
                    int right = Math.Min(3, gameHW[1] + 1 - c);
                    for (int i = upper; i < lower; i++)
                        for (int j = left; j < right; j++)
                            if (i * j != 1)
                            {
                                neighbours[r, c] += gameMap[r + i - 1, c + j - 1];
                            }
                });
            });
        }

        private void ReactToNeighbours(byte[,] neighbours)
        {
            Parallel.For(0, gameHW[0], r1 =>
                Parallel.For(0, gameHW[1], c1 =>
                    gameMap[r1, c1] =
                        newStates[gameMap[r1, c1]].TryGetValue(neighbours[r1, c1], out byte newState) ?
                        newState : (byte)0));
        }
    }
}