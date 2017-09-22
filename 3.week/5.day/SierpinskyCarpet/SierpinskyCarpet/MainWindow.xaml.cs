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

namespace SierpinskyCarpet
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
            Random random = new Random();

            Squares(foxDraw, 0, 0, canvas.Width, random, 5);
        }
        public void Squares (FoxDraw draw, double x, double y, double size, Random random, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            draw.DrawRectangle(x + size / 3, y + size / 3, size / 3, size / 3);
            draw.FillColor(Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));

            Squares(draw, x, y, size / 3, random, depth - 1);
            Squares(draw, x + size / 3, y, size / 3, random, depth - 1);
            Squares(draw, x + size / 3 * 2, y + size / 3, size / 3, random, depth - 1);
            Squares(draw, x, y + size / 3, size / 3, random, depth - 1);
            Squares(draw, x, y + size / 3 * 2, size / 3, random, depth - 1);
            Squares(draw, x + size / 3, y + size / 3 * 2, size / 3, random, depth - 1);
            Squares(draw, x + size / 3 * 2, y, size / 3, random, depth - 1);
            Squares(draw, x + size / 3 * 2, y + size / 3 * 2, size / 3, random, depth - 1);

        }
    }
}
