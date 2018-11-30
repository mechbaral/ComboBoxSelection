using System.ComponentModel;
using System.Windows;


namespace RadioButtonandContentControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private MainView _MainView;
        private CylinderOneView _CylinderOne;
        public CylinderOneView CylinderOne
        {
            get { return _CylinderOne; }
            set
            {
                if (_CylinderOne == value)
                    return;
                _CylinderOne = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CylinderOne)));
            }
        }
        public MainWindow()
        {
            
            _MainView = new MainView();
            CylinderOne = new CylinderOneView();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainClicked(sender, e);
        }
        private void MainClicked(object sender, RoutedEventArgs e)
        {
            DataContext = _MainView;
        }
        private void CyinderOneClicked(object sender, RoutedEventArgs e)
        {
            DataContext = CylinderOne;
        }
    }
}
