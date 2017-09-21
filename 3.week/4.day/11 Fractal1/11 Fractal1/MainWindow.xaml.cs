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

namespace _11_Fractal1
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
            double line = canvas.Width;
            int depth = 5;

            foxDraw.BackgroundColor(Colors.LightYellow);
            foxDraw.StrokeColor(Colors.DarkMagenta);
            Drawer(foxDraw, 0, 0, line, depth);
        }
        public void Drawer(FoxDraw draw, double x, double y, double canvasSize, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            draw.DrawLine(x + canvasSize / 3, y, x + canvasSize / 3, y + canvasSize);
            draw.DrawLine(x + canvasSize / 3 * 2, y, x + canvasSize / 3 * 2, y + canvasSize);
            draw.DrawLine(x, y + canvasSize / 3, x + canvasSize, y + canvasSize / 3);
            draw.DrawLine(x, y + canvasSize / 3 * 2, x + canvasSize, y + canvasSize / 3 * 2);

            Drawer(draw, x + canvasSize / 3, y, canvasSize / 3, depth - 1);
            Drawer(draw, x + canvasSize / 3, y + canvasSize / 3 * 2, canvasSize / 3, depth - 1);
            Drawer(draw, x, y + canvasSize / 3, canvasSize / 3, depth - 1);
            Drawer(draw, x + canvasSize / 3 * 2, y + canvasSize / 3, canvasSize / 3, depth - 1);
        }
    }
}
