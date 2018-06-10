using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTimeAndAngle.Models;
namespace WpfTimeAndAngle.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        string _userInputText;
        public string UserInputText
        {
            get
            {
                return _userInputText;
            }
            set
            {
                _userInputText = value;
                Angle = Model.CountAngle(_userInputText);
                OnPropertyChanged("UserInputText");
            }
        }

        string _angle;
        public string Angle
        {
            get
            {
                return _angle;
            }
            set
            {
                _angle = value;
                OnPropertyChanged("Angle");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
