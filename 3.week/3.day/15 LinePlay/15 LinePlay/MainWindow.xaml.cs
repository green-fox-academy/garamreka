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

namespace _15_LinePlay
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
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/line-play/r1.png]


            for (int i = 0; i < canvas.Width; i++)
            {
                foxDraw.StrokeColor(Colors.Crimson);
                var startPoint = new Point(0, i);
                var endPoint = new Point(i, canvas.Height);
                foxDraw.DrawLine(startPoint, endPoint);
                i += 20;
            }
            for (int i = 0; i < canvas.Width; i++)
            {
                foxDraw.StrokeColor(Colors.DarkMagenta);
                var startPoint = new Point(i, 0);
                var endPoint = new Point(canvas.Width, i);
                foxDraw.DrawLine(startPoint, endPoint);
                i += 20;
            }
        }
    }
}
