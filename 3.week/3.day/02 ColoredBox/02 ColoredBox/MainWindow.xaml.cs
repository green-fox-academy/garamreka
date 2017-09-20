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

namespace _02_ColoredBox
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
            // draw a box that has different colored lines on each edge.


            var topLeftCorner = new Point(100, 100);
            var topRightCorner = new Point(200, 100);
            var bottomLeftCorner = new Point(100, 200);
            var bottomRightCorner = new Point(200, 200);

            DrawLine(foxDraw, Colors.BlueViolet, topLeftCorner, topRightCorner);
            DrawLine(foxDraw, Colors.CornflowerBlue, topRightCorner, bottomRightCorner);
            DrawLine(foxDraw, Colors.Coral, bottomRightCorner, bottomLeftCorner);
            DrawLine(foxDraw, Colors.Firebrick, bottomLeftCorner, topLeftCorner);
        }

        public static void DrawLine(FoxDraw draw, Color color, Point startPoint, Point endPoint)
        {
            draw.StrokeColor(color);
            draw.DrawLine(startPoint, endPoint);
        }
        
    }
}
