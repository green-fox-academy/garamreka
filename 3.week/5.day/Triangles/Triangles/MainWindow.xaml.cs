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

namespace Triangles
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
            foxDraw.FillColor(Colors.Transparent);

            Triangles(foxDraw, 0, 0, canvas.Width, 7);

        }
        public void Triangles(FoxDraw draw, double x, double y, double size, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            var triangleAngles = new List<Point>();
            triangleAngles.Add(new Point(x, y));
            triangleAngles.Add(new Point(x + size, y));
            triangleAngles.Add(new Point(x + size / 2, y + size));

            draw.DrawPolygon(triangleAngles);

            Triangles(draw, x, y, size / 2, depth - 1);
            Triangles(draw, x + size / 2, y, size / 2, depth - 1);
            Triangles(draw, x + size / 4, y + size / 2, size / 2, depth - 1);
        }
    }
}
