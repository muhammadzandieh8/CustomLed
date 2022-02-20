using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace CustomLed
{
    /// <summary>
    /// Interaction logic for Led2.xaml
    /// </summary>
    public partial class Led2 : UserControl
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
        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(Led2), new FrameworkPropertyMetadata(Colors.Black));
        #endregion Color
        #region Effect
        public Color zShadow
        {
            get { return (Color)GetValue(ShadowProperty); }
            set
            {
                SetValue(ShadowProperty, value);
                LED_Loaded(null, null);
            }
        }
        public static readonly DependencyProperty ShadowProperty = DependencyProperty.Register("Shadow", typeof(Color), typeof(Led2), new FrameworkPropertyMetadata(Colors.Silver));
        #endregion

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
        public static readonly DependencyProperty SizeProperty = DependencyProperty.Register("Size", typeof(int), typeof(Led2), new FrameworkPropertyMetadata(20));
        #endregion Size
        #region Form Loaded
        private void LED_Loaded(object sender, RoutedEventArgs e)
        {

            G_main.Width = Size;
            G_main.Height = Size;

            //MainEllipse.Width = Size;
            //MainEllipse.Height = Size;

            FrontEllipse.Width = Size - 1;
            FrontEllipse.Height = Size - 1;

            Shadow.Width = Size + 3;
            Shadow.Height = Size + 3;


            if (Color == Colors.Red)
            {
                StartColor.Color = Colors.Red;
                Effect_FrontEllipse.Color = Colors.Red;
                StopColor.Color = Colors.Black;
            }
            else if (Color == Colors.Green)
            {
                StartColor.Color = Colors.GreenYellow;
                Effect_FrontEllipse.Color = Colors.GreenYellow;
                StopColor.Color = Colors.DarkGreen;
            }
            else if (Color == Colors.Gray)
            {
                StartColor.Color = Colors.Gray;
                Effect_FrontEllipse.Color = Colors.Gray;

                StopColor.Color = Colors.Silver;
            }
            else
            {
                StartColor.Color = Color;
                Effect_FrontEllipse.Color = zShadow;
                StopColor.Color = Color;
            }
        }
        #endregion
        public Led2()
        {
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(Led2), new FrameworkPropertyMetadata(typeof(Led2)));
            InitializeComponent();

        }
    }
}
