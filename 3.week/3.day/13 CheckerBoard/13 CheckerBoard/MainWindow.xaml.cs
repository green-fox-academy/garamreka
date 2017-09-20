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

namespace _13_CheckerBoard
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
            // fill the canvas with a checkerboard pattern.

            int boardSize = 20;
            for (int i = 0; i < boardSize; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        if (j % 2 == 1)
                        {
                            StartWithWhite(foxDraw, i, j);
                        }
                        else
                        {
                            StartWithBlack(foxDraw, i, j);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        if (j % 2 == 1)
                        {
                            StartWithBlack(foxDraw, i, j);
                        }
                        else
                        {
                            StartWithWhite(foxDraw, i, j);
                        }
                    }
                }

            }
        }
        public void StartWithWhite(FoxDraw draw, int x, int y)
        {
            draw.FillColor(Colors.White);
            draw.DrawRectangle(x * 10, y * 10, 10, 10);
            draw.FillColor(Colors.Black);
            draw.DrawRectangle(x * 10, y * 10, 10, 10);
        }
        public void StartWithBlack(FoxDraw draw, int x, int y)
        {
            draw.FillColor(Colors.Black);
            draw.DrawRectangle(x * 10, y * 10, 10, 10);
            draw.FillColor(Colors.White);
            draw.DrawRectangle(x * 10, y * 10, 10, 10);
        }
    }
}
