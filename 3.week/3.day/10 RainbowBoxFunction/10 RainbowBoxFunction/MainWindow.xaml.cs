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

namespace _10_RainbowBoxFunction
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
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            //Random random = new Random();
            int red = 0;
            int green = 100;
            int blue = 255;

            for (int i = 255; i > 0; i--)
            {
                Rainbow(foxDraw, i, Color.FromRgb((byte)red, (byte)green, (byte)blue));
                red++;
                blue--;
                
            }
        }
        public void Rainbow (FoxDraw draw, double squareSize, Color fillColor)
        {
            draw.DrawRectangle(canvas.Width / 2 - squareSize / 2, canvas.Height / 2 - squareSize / 2, squareSize, squareSize);
            draw.FillColor(fillColor);
            draw.StrokeColor(fillColor);
        }
    }
}
