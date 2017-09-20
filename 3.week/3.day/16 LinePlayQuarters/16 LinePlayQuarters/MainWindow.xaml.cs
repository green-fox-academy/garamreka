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

namespace _16_LinePlayQuarters
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
            // divide the canvas into 4 parts
            // and repeat this pattern in each quarter:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/line-play/r1.png]

            LineDrawer(foxDraw, 0, 0);
            LineDrawer(foxDraw, 0, canvas.Height/2);
            LineDrawer(foxDraw, canvas.Width/2, 0);
            LineDrawer(foxDraw, canvas.Width/2, canvas.Height/2);

        }
        public void LineDrawer (FoxDraw draw, double x, double y)
        {
            for (int i = 0; i < canvas.Width/2; i++)
            {
                draw.StrokeColor(Colors.Crimson);
                draw.DrawLine(x + 0, y + i, x + i, y + canvas.Height/2);
                draw.StrokeColor(Colors.Gold);
                draw.DrawLine(x + i, y + 0, x + canvas.Width/2, + y + i);
                i += 10;
            }
        }
    }
}
