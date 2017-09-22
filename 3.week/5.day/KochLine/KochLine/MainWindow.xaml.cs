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

            double xCoord1 = 0;
            double yCoord1 = 0;
            double xCoord2 = 0;
            double yCoord2 = 0;
            double width = canvas.Width;

            foxDraw.BackgroundColor(Colors.LightYellow);
            KochLineDrawer(foxDraw, xCoord1, yCoord2, xCoord2, yCoord2, width, 3);
        }
        public void KochLineDrawer (FoxDraw draw, double x1, double y1, double x2, double y2, double size, int depth)
        {
            if (depth == 0)
            {
                return;
            }

            //main line
            draw.StrokeColor(Colors.DarkMagenta);
            draw.DrawLine(x1, y2 + canvas.Height / 2, x2 + canvas.Width, y2 + canvas.Height / 2);

            //transparent middle???
            draw.StrokeColor(Colors.White);
            draw.DrawLine(x1 + canvas.Width / 3, y1 + canvas.Height / 2, x2 + canvas.Width / 3 * 2, y2 + canvas.Height / 2);

            //triangle leftline
            draw.StrokeColor(Colors.DarkMagenta);
            draw.DrawLine(x1 + canvas.Width / 3, y1 + canvas.Height / 2, x2 + canvas.Width / 2, y2 + canvas.Height / 5);

            //triangle rightline
            draw.StrokeColor(Colors.DarkMagenta);
            draw.DrawLine(x1 + canvas.Width / 3 * 2, y1 + canvas.Height / 2, x2 + canvas.Width / 2, y2 + canvas.Height / 5);

        }
    }
}
