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

namespace SitPO.TextSourceEditor.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConfigurationViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        private void Initialise()
        {
            _viewModel = new ConfigurationViewModel
            {
                AutoSave = true,
                TextSources = new List<TextSource>
                {
                    new SimpleTextSource { Name = "Basic Text", Value = "Some text goes here" },
                    new NumericTextSource { Name = "Team A Score", Value = 5 },
                    new NumericTextSource { Name = "Team B Score", Value = 10 }
                }
            };

            this.DataContext = _viewModel;
        }

        private void LoadConfigButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_viewModel.AutoSave.ToString());
        }
    }
}
