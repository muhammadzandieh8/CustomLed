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

namespace CustomLed.Leds
{
    /// <summary>
    /// Interaction logic for Led0.xaml
    /// </summary>
    public partial class Led0 : UserControl
    {
        #region Color
        public Color Color
        {
            get { return (Color)GetValue(ColorProperty); }
            set
            {
                SetValue(ColorProperty, value);
                LED_Loaded(null, null);
            }
        }
        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(Led0), new FrameworkPropertyMetadata(Colors.Black));
        #endregion Color
        #region Size
        public int Size
        {
            get { return (int)GetValue(SizeProperty); }
            set
            {
                SetValue(SizeProperty, value);
                LED_Loaded(null, null);
            }
        }
        public static readonly DependencyProperty SizeProperty = DependencyProperty.Register("Size", typeof(int), typeof(Led0), new FrameworkPropertyMetadata(20));
        #endregion Size
        #region Form Loaded
        private void LED_Loaded(object sender, RoutedEventArgs e)
        {

            G_main.Width = Size;
            G_main.Height = Size;

            MainEllipse.Width = Size;
            MainEllipse.Height = Size;

            FrontEllipse.Width = Size - 1;
            FrontEllipse.Height = Size - 1;

            Shadow.Width = Size + 3;
            Shadow.Height = Size + 3;


            if (Color == Colors.Red)
            {
                StartColor.Color = Colors.Red;
                StopColor.Color = Colors.Black;
            }
            else if (Color == Colors.Green)
            {
                StartColor.Color = Colors.GreenYellow;
                StopColor.Color = Colors.DarkGreen;
            }
            else if (Color == Colors.Gray)
            {
                StartColor.Color = Colors.Gray;
                StopColor.Color = Colors.Silver;
            }
            else
            {
                StartColor.Color = Color;
                StopColor.Color = Color;
            }
        }
        #endregion
        public Led0()
        {
            InitializeComponent();
        }
    }
}
