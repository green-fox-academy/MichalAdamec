using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Collections.Generic;
using System.IO;

namespace Av
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            //int xstart = 100;
            //int ystart = 50;
            //MiddleLines(foxDraw);
            //ColoredBox(foxDraw);
            //Diagonals(foxDraw);
            //GoToCenter(foxDraw, xstart, ystart);
            //HorizontalLines(foxDraw, xstart, ystart);
            //CenteredSquare(foxDraw);
            //FourRectangles(foxDraw);
            //PositionSquare(foxDraw, 150, 200);
            //CenterBoxFunction(foxDraw, 400);
            ChessBoard(foxDraw);
        }




        public static void MiddleLines(FoxDraw param)
        {
            param.SetStrokeColor(Colors.Red);
            param.DrawLine(new Point(250, 0), new Point(250, 500));

            param.SetStrokeColor(Colors.Green);
            param.DrawLine(new Point(0, 250), new Point(500, 250));
        }
        public static void ColoredBox(FoxDraw param)
        {
            List<Color> Color = new List<Color>()
            {Colors.Blue, Colors.Green, Colors.Red, Colors.Black};

            int length = 400;
            int x = 50;
            int y = 50;
            int a = 0;

            param.SetStrokeColor(Color[a++]);
            param.DrawLine(new Point(x, y), new Point(x + length, y));

            param.SetStrokeColor(Color[a++]);
            param.DrawLine(new Point(x + length, y), new Point(x + length, y + length));

            param.SetStrokeColor(Color[a++]);
            param.DrawLine(new Point(x + length, y + length), new Point(x, y + length));

            param.SetStrokeColor(Color[a]);
            param.DrawLine(new Point(x, y + length), new Point(x, y));

        }
        public static void Diagonals(FoxDraw param)
        {
            int xstart = 500;
            int ystart = 500;
            int xend = 0;
            int yend = 0;
            int start = xstart + ystart;
            int end = xend + yend;

            if (start == 0 || end == 0)
            {
                param.SetStrokeColor(Colors.Green);
                param.DrawLine(new Point(xstart, ystart), new Point(xend, yend));
            }
            else
            {
                param.SetStrokeColor(Colors.Red);
                param.DrawLine(new Point(xstart, ystart), new Point(xend, yend));
            }
        }
        public static void GoToCenter(FoxDraw param, int xstart, int ystart)
        {
            xstart = 100;
            ystart = 50;
            for (int a = 1; a < 5; a++)
            {
                xstart = xstart + (20 * a);
                //ystart = ystart + (20 * a);
                param.SetStrokeColor(Colors.Green);
                param.DrawLine(new Point(xstart, ystart), new Point(250, 250));

            }
        }
        public static void HorizontalLines(FoxDraw param, int xstart, int ystart)
        {
            param.SetStrokeColor(Colors.Green);
            param.DrawLine(new Point(xstart, ystart), new Point(xstart + 50, ystart));
            int a = 0;
            while (a < 4)
            {
                a++;
                param.SetStrokeColor(Colors.Green);
                param.DrawLine(new Point(xstart, ystart + 100 * a), new Point(xstart + 50, ystart + 100 * a));
            }
        }
        public static void CenteredSquare(FoxDraw param)
        {
            int x = 250;
            int y = 250;
            int width = 150;
            int heigth = 150;
            int xcent = x - width / 2;
            int ycent = y - heigth / 2;
            param.DrawRectangle(xcent, ycent, width, heigth);
        }
        public static void FourRectangles(FoxDraw param)
        {
            List<Color> Barva = new List<Color>()
            {Colors.Blue, Colors.Green, Colors.Red, Colors.Black};

            int x = 0;
            int y = 0;
            int width = 20;
            int heigth = 20;
            ;
            for (int a = 0; a < 4; a++)
            {
                param.SetFillColor(Barva[a]);
                param.DrawRectangle(x + 50 * a, y + 50 * a, width + 50 * a, heigth + 50 * a);
            }
        }
        public static void PositionSquare(FoxDraw param, int x, int y)
        {
            //x = 150;
            //y = 200;
            int length = 50;
            param.DrawRectangle(x, y, length, length);
        }
        public static void CenterBoxFunction(FoxDraw param, int length)
        {
            List<Color> Barva = new List<Color>(4)
            { Colors.Blue, Colors.Black, Colors.Pink};
            int a = 0;
            while (a < 3)
            {
                int lengthnew = length / (a + 1);
                param.SetFillColor(Barva[a]);
                param.DrawRectangle(250 - (lengthnew / 2), 250 - (lengthnew / 2), lengthnew, lengthnew);
                a++;


            }
        }
        public static void ChessBoard(FoxDraw param)
        {
            double squareLength = 500 / 8;
            for (int x = 0; x <= 7; x++)
            {
                double xstart = squareLength;
                double ystart = squareLength;
                for (int y = 0; y <=7; y++)
                {
                    xstart = squareLength * x;
                    ystart = squareLength * y;
                    if ((x + y) % 2 == 0)
                    {
                        param.SetFillColor(Colors.Black);
                        param.DrawRectangle(xstart, ystart, squareLength, squareLength);
                    }
                    else
                        param.SetFillColor(Colors.Red);
                        param.DrawRectangle(xstart, ystart, squareLength, squareLength);
                }
            }
        }

    private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
