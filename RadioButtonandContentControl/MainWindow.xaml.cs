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

        private HomeView _HomeView;
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
            
            _HomeView = new HomeView();
            CylinderOne = new CylinderOneView();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HomeClicked(sender, e);
        }
        private void HomeClicked(object sender, RoutedEventArgs e)
        {
            DataContext = _HomeView;
        }
        private void CyinderOneClicked(object sender, RoutedEventArgs e)
        {
            DataContext = CylinderOne;
        }
    }
}
