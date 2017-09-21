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
            foxDraw.StrokeColor(Colors.Black);
            Drawer(foxDraw, line, depth);
        }
        public void Drawer(FoxDraw draw, double canvasWidth, int depth)
        {
            if (depth == 0)
            {
                return;
            }

            for (double i = 0; i <= canvasWidth; i++)
            {
                for (double j = 0; j <= canvasWidth; j++)
                {
                    draw.DrawLine(i, 0, i, canvasWidth);
                    draw.DrawLine(i, 0, i, canvasWidth);
                    draw.DrawLine(0, j, canvasWidth, j);
                    draw.DrawLine(0, j, canvasWidth, j);
                    j += canvasWidth / 3;
                    
                }
                i += canvasWidth / 3;
                
            }
        }
    }
}
