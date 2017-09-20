using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace _03_Diagonals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.
            var topLeft = new Point(0, 0);
            var bottomLeft = new Point(canvas.Height, 0);
            var topRight = new Point(0, canvas.Width);
            var bottomRight = new Point(canvas.Height, canvas.Width);

            DrawDiagonal(foxDraw, topLeft, bottomRight);
            DrawDiagonal(foxDraw, topRight, bottomLeft);
        }
        public static void DrawDiagonal (FoxDraw draw, Point startPoint, Point endPoint)
        {
            draw.StrokeColor(Colors.Green);
            draw.DrawLine(startPoint, endPoint);
        }
    }
}
