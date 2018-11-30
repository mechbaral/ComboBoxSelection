using System.ComponentModel;
using System.Windows.Controls;


namespace RadioButtonandContentControl
{
    /// <summary>
    /// Interaction logic for CylinderOneView.xaml
    /// </summary>
    public partial class CylinderOneView : UserControl,INotifyPropertyChanged
    {
        private HomeView _ObjectOfHomeView;

        public HomeView ObjectOfHomeView
        {
            get { return _ObjectOfHomeView; }
            set
            {
                if (_ObjectOfHomeView == value)
                    return;
                _ObjectOfHomeView = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ObjectOfHomeView)));
            }
        }

        private string _SelectedItemInCombobox="Null";

        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedItemInCombobox
        {
            get { return _SelectedItemInCombobox; }
            set
            {
                if (_SelectedItemInCombobox == value)
                    return;
                _SelectedItemInCombobox = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItemInCombobox)));
            }
        }

        public CylinderOneView()
        {
            ObjectOfHomeView = new HomeView();
            InitializeComponent();
            SelectedItemInCombobox = ObjectOfHomeView.SelectedItem;
        }
    }
}
