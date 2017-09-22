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

namespace KochLine
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

            double xCoord = 0;
            double yCoord = 0;
            double width = canvas.Width;
            double heigth = canvas.Width;

            foxDraw.BackgroundColor(Colors.LightYellow);
            KochLineDrawer(foxDraw, xCoord, yCoord, width, Height, 3);
        }
        public void KochLineDrawer (FoxDraw draw, double x, double y, double width, double height, int depth)
        {
            if (depth == 0)
            {
                return;
            }

            //main line
            draw.StrokeColor(Colors.DarkMagenta);
            draw.DrawLine(x, y + height / 2, x + width, y + height / 2);

            //transparent middle???
            draw.StrokeColor(Colors.White);
            draw.DrawLine(x + width / 3, y + height / 2, x + width / 3 * 2, y + height / 2);

            //triangle leftline
            draw.StrokeColor(Colors.DarkMagenta);
            draw.DrawLine(x + width / 3, y + height / 2, x + width / 2, y + height / 5);

            //triangle rightline
            draw.StrokeColor(Colors.DarkMagenta);
            draw.DrawLine(x + width / 3 * 2, y + height / 2, x + width / 2, y + height / 5);

            KochLineDrawer(draw, x, y + height / 3, width / 3, height / 3, depth - 1);
            KochLineDrawer(draw, x + width / 3 * 2, y + height / 3, width / 3, height / 3, depth - 1);
        }
    }
}
