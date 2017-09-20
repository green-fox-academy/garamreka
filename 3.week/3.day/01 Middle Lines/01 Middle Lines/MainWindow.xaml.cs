using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;
using System.Windows.Controls;

namespace _01_Middle_Lines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.

            DrawRedLine(foxDraw, canvas);
            DrawGreenLine(foxDraw, canvas);
        }
        public static void DrawRedLine (FoxDraw draw, Canvas canvas)
        {
            var horizontalStartPoint = new Point(0, canvas.Height/2);
            var horizontalEndPoint = new Point(canvas.Width, canvas.Height/2);
            draw.StrokeColor(Colors.Red);
            draw.DrawLine(horizontalStartPoint, horizontalEndPoint);
        }
        public static void DrawGreenLine (FoxDraw draw, Canvas canvas)
        {
            var verticalStartPoint = new Point(canvas.Width/2, 0);
            var verticalEndPoint = new Point(canvas.Width/2, canvas.Height);
            draw.StrokeColor(Colors.Green);
            draw.DrawLine(verticalStartPoint, verticalEndPoint);
        }
        
    }
}
