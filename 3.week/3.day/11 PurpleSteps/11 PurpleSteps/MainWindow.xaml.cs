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

namespace _11_PurpleSteps
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
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.FillColor(Colors.Purple);

            double x = 10;
            double y = 10;
            double size = 10;
            double length = 19;

            for (int i = 0; i < length; i++)
            {
                foxDraw.DrawRectangle(x, y, size, size);
                x += 10;
                y += 10;
            }
        }
    }
}
