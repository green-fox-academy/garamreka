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

namespace _17_EnvelopeStar
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
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/envelope-star/r2.png]

            foxDraw.StrokeColor(Colors.PaleVioletRed);
            for (int i = 0; i < canvas.Width / 2; i++)
            {
                foxDraw.DrawLine(canvas.Width / 2, i, (canvas.Width / 2) + i, canvas.Height / 2);
                foxDraw.DrawLine(canvas.Width / 2, i, (canvas.Width / 2) - i, canvas.Height / 2);
                foxDraw.DrawLine(canvas.Width / 2, canvas.Height - i, (canvas.Width / 2) + i, canvas.Height / 2);
                foxDraw.DrawLine(canvas.Width / 2, canvas.Height - i, (canvas.Width / 2) - i, canvas.Height / 2);
                i += 10;
            }
            
        }
    }
}
