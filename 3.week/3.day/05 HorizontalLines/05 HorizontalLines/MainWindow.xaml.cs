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

namespace _05_HorizontalLines
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
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.

            LineDrawer(foxDraw, 30, 40);
            LineDrawer(foxDraw, 50, 130);
            LineDrawer(foxDraw, 216, 290);
        }
        public void LineDrawer(FoxDraw draw, double x, double y)
        {
            draw.StrokeColor(Colors.BurlyWood);

            var startPoint = new Point(x, y);
            var endPoint = new Point(x + 50, y);

            draw.DrawLine(startPoint, endPoint);
        }
    }
}
