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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColorAnimation TCA = new ColorAnimation();
            Color Cstart = Color.FromRgb(255, 0, 0);
            TBHoSe.Foreground = new SolidColorBrush(Cstart);
            TCA.From = Cstart;
            TCA.To = Color.FromRgb(0, 0, 255);
            TCA.Duration = TimeSpan.FromSeconds(2);
            TCA.RepeatBehavior = RepeatBehavior.Forever;
            TCA.AutoReverse = true;
            TBHoSe.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, TCA);

            DoubleAnimation TFA = new DoubleAnimation();
            TFA.From = 32;
            TFA.To = 40;
            TFA.Duration = TimeSpan.FromSeconds(2);
            TFA.RepeatBehavior = RepeatBehavior.Forever;
            TFA.AutoReverse = true;
            TBHoSe.BeginAnimation(TextBlock.FontSizeProperty, TFA);

            ColorAnimation BBA = new ColorAnimation();
            Color Bstart = Color.FromRgb(255, 0, 0);
            BtnReg.Background = new SolidColorBrush(Bstart);
            BBA.From = Bstart;
            BBA.To = Color.FromRgb(0, 255, 0);
            BBA.Duration = TimeSpan.FromSeconds(2);
            BBA.RepeatBehavior = RepeatBehavior.Forever;
            BBA.AutoReverse = true;
            BtnReg.Background.BeginAnimation(SolidColorBrush.ColorProperty, BBA);

            DoubleAnimation BWA = new DoubleAnimation();
            BWA.From = 200;
            BWA.To = 250;
            BWA.Duration = TimeSpan.FromSeconds(3);
            BWA.RepeatBehavior = RepeatBehavior.Forever;
            BWA.AutoReverse = true;
            BtnReg.BeginAnimation(WidthProperty, BWA);

            DoubleAnimation BHA = new DoubleAnimation();
            BHA.From = 50;
            BHA.To = 100;
            BHA.Duration = TimeSpan.FromSeconds(3);
            BHA.RepeatBehavior = RepeatBehavior.Forever;
            BHA.AutoReverse = true;
            BtnReg.BeginAnimation(HeightProperty, BHA);
        }
    }
}
