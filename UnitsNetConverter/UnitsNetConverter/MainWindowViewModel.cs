using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using UnitsNet;

namespace UnitsNetConverter
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private QuantityType _selectedQuantity;
        public QuantityType SelectedQuantity
        {
            get { return _selectedQuantity; }
            set
            {
                _selectedQuantity = value;
                RaisePropertyChanged("SelectedQuantity");
            }
        }

        private string _fromText;
        public String FromText
        {
            get { return _fromText; }
            set
            {
                if (!IsTextAllowed(value))
                    return;
                _fromText = value;
                RaisePropertyChanged("FromText");
                ToText = FromText;
            }

        }

        private string _toText;
        public String ToText
        {
            get { return _toText; }

            set
            {
                if (!IsTextAllowed(value))
                    return;
                _toText = value;
                RaisePropertyChanged("ToText");
                FromText = ToText;
            }

        }

        public MainWindowViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyThatChanged)
        {
            //checking if event is not null than raise event and pass
            //in propperty name that has changed
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyThatChanged));
        }


        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }
    }
}
