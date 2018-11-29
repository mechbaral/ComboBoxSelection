using System.ComponentModel;
using System.Windows.Controls;


namespace RadioButtonandContentControl
{
    /// <summary>
    /// Interaction logic for CylinderOneView.xaml
    /// </summary>
    public partial class CylinderOneView : UserControl,INotifyPropertyChanged
    {
        private MainView _ObjectOfMainView;

        public MainView ObjectOfMainView
        {
            get { return _ObjectOfMainView; }
            set
            {
                if (_ObjectOfMainView == value)
                    return;
                _ObjectOfMainView = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ObjectOfMainView)));
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
            ObjectOfMainView = new MainView();
            InitializeComponent();
            SelectedItemInCombobox = ObjectOfMainView.SelectedItem;
        }
    }
}
