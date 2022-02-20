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

namespace CustomLed
{
    /// <summary>
    /// Interaction logic for Led4.xaml
    /// </summary>
    public partial class Led4 : UserControl
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
        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(Led4), new FrameworkPropertyMetadata(Colors.Black));
        #endregion Color
        #region Color Number
        public int ColorNumber
        {
            get { return (int)GetValue(ColorNumberProperty); }
            set
            {
                SetValue(ColorNumberProperty, value);
                LED_Loaded(null, null);
            }
        }
        public static readonly DependencyProperty ColorNumberProperty = DependencyProperty.Register("ColorNumber", typeof(int), typeof(Led4), new FrameworkPropertyMetadata(858585));
        #endregion
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
        public static readonly DependencyProperty ShadowProperty = DependencyProperty.Register("Shadow", typeof(Color), typeof(Led4), new FrameworkPropertyMetadata(Colors.Silver));
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
        public static readonly DependencyProperty SizeProperty = DependencyProperty.Register("Size", typeof(int), typeof(Led4), new FrameworkPropertyMetadata(20));
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
            if (zShadow == Colors.Silver)
            {
                Effect_FrontEllipse.Color = Color;
            }


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
                StopColor.Color = Color;
            }

            if (ColorNumber != 858585)
            {
                Define_ColorNumber();
            }
        }
        public void Define_ColorNumber()
        {
            switch (ColorNumber)
            {
                case 0:
                    {
                        //Gray
                        StartColor.Color = Colors.Gray;
                        StopColor.Color = Colors.Gray;
                        Effect_FrontEllipse.Color = Colors.Gray;
                    }
                    break;
                case 1:
                    {
                        //Red
                        StartColor.Color = Colors.Red;
                        StopColor.Color = Colors.Black;
                        Effect_FrontEllipse.Color = Colors.Red;
                    }
                    break;
                case 2:
                    {
                        //Yellow
                        StartColor.Color = Colors.Yellow;
                        StopColor.Color = Colors.Yellow;
                        Effect_FrontEllipse.Color = Colors.Yellow;
                    }
                    break;
                case 3:
                    {
                        //Green
                        StartColor.Color = Colors.GreenYellow;
                        StopColor.Color = Colors.DarkGreen;
                        Effect_FrontEllipse.Color = Colors.GreenYellow;
                    }
                    break;
                case 4:
                    {
                        //DarkBlue
                        StartColor.Color = Colors.DarkBlue;
                        StopColor.Color = Colors.DarkBlue;
                        Effect_FrontEllipse.Color = Colors.DarkBlue;
                    }
                    break;
                case 5:
                    {
                        //Black
                        StartColor.Color = Colors.Black;
                        StopColor.Color = Colors.Black;
                        Effect_FrontEllipse.Color = Colors.Black;
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion
        public Led4()
        {
            InitializeComponent();
        }
    }
}
