using JobTask.Constants;
using JobTask.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace JobTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StaticVariables.win = (MainWindow)GetWindow(this);
            StaticVariables.LoadCoordinatesData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DrawHelper.DrawSiteZone();
        }

        public static VirtualizingStackPanel CreateSolarPanel()
        {


            Border border = new Border()
            {
                BorderThickness = new Thickness(2),
                HorizontalAlignment = HorizontalAlignment.Center
            };

            VirtualizingStackPanel virtualizingStackPanel = new VirtualizingStackPanel();
            virtualizingStackPanel.Children.Add(border);

            return virtualizingStackPanel;
        }

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
