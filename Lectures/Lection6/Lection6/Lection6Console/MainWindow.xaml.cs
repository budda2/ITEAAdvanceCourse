using Examples;
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

namespace Lection6Console
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Freeze(object sender, RoutedEventArgs e)
        {
            Text.Text = "Start";
            var longRunning = new HardLongOperations();
            longRunning.RunPerformanceHeavy();
            Text.Text = "Finished";
        }

        private async void NotFreeze(object sender, RoutedEventArgs e)
        {
            Text1.Text = "Start";
            var longRunning = new HardLongOperations();
            await longRunning.RunPerformanceHeavyInBackground();
            
            //use to do nothing for some period of time.
            //note: having this awaited will let the thread to do another work while "doing nothing"
            await Task.Delay(100);

            Text1.Text = "Finished";
        }

        private async void ShowLockingExample(object sender, RoutedEventArgs e)
        {
            var usage = new UsageOfLockExample();

            await usage.UseLockExample();
        }
    }
}
