﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;

namespace RadioButtonandContentControl
{  
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _SelectedItem;

        public string SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                if (_SelectedItem == value)
                    return;
                _SelectedItem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
            }
        }

        private List<string> _ListofItems;

        public List<string> ListofItems
        {
            get { return _ListofItems; }
            set
            {
                if (_ListofItems == value)
                    return;
                _ListofItems = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ListofItems)));
            }
        }

        public MainView()
        {
            InitializeComponent();
            this.DataContext = this;
            ListofItems = new List<string>();
            ListofItems.Add("Nepal");
            ListofItems.Add("USA");
            ListofItems.Add("Germany");
            ListofItems.Add("Finland");
            ListofItems.Add("Norway");
            MyComboBox.SelectionChanged += PropertyAssignMethod;
        }

        public void PropertyAssignMethod(object sender, SelectionChangedEventArgs e)
        {
            SelectedItem = this.MyComboBox.SelectedItem as string;
        }
    }
}
