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

namespace Circles
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
            foxDraw.StrokeColor(Colors.Sienna);
            foxDraw.DrawEllipse(0, 0, canvas.Width, canvas.Height);

            CircleDrawer(foxDraw, 0, 0, canvas.Width, 20, 3);
        }
        public void CircleDrawer (FoxDraw draw, double x, double y, double r, int n, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            draw.DrawEllipse(x + canvas.Width / n * 5, y, r / 2, r / 2);
            draw.DrawEllipse(x + canvas.Width / n, y + canvas.Height / (n / 4) * 2, r / 2, r / 2);
            draw.DrawEllipse(x + canvas.Width / n * 9, y + canvas.Height / (n / 4) * 2, r / 2, r / 2);

            CircleDrawer(draw, x + canvas.Width / n * 2, y, r / 2, n, depth - 1);
        }
    }
}
