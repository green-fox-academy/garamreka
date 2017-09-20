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

namespace _06_CenteredSquare
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
            // draw a green 10x10 square to the canvas' center.

            var topLeft = new Point((canvas.Width/2) - 5, (canvas.Height / 2) - 5);
            var bottomLeft = new Point((canvas.Width / 2) - 5, (canvas.Height / 2) + 5);
            var topRight = new Point((canvas.Width / 2) + 5, (canvas.Height / 2) - 5);
            var bottomRight = new Point((canvas.Width / 2) + 5, (canvas.Height / 2) + 5);

            foxDraw.DrawLine(topLeft, topRight);
            foxDraw.DrawLine(topRight, bottomRight);
            foxDraw.DrawLine(bottomRight, bottomLeft);
            foxDraw.DrawLine(bottomLeft, topLeft);
        }
    }
}
