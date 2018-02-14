using System.Windows;

namespace Lapka1
{
    /// <inheritdoc>
    ///     <cref></cref>
    /// </inheritdoc>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            //Redundant try catch
            InitializeComponent();
            DataContext = new UserViewModel();
        }
        
    }
}
