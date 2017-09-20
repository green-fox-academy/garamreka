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

namespace _14_FunctionToCenter
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
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            foxDraw.StrokeColor(Colors.LawnGreen);
            foxDraw.BackgroundColor(Colors.Snow);

            for (int i = 0; i <= canvas.Width; i++)
            {
                LineDrawer(foxDraw, i, 0);
                LineDrawer(foxDraw, i, canvas.Height);
                LineDrawer(foxDraw, canvas.Width, i);
                LineDrawer(foxDraw, 0, i);
                i += 20;
            }
        }
        public void LineDrawer(FoxDraw draw, double x, double y)
        {
            var startPoint = new Point(x, y);
            var endPoint = new Point(canvas.Width/2, canvas.Height/2);
            draw.DrawLine(startPoint, endPoint);
        }
    }
}
