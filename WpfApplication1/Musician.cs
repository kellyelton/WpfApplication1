using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace WpfApplication1
{
    public class Musician : INotifyPropertyChanged
    {
        private bool isActive;
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }
        public string FullName
        {
            get { return $"{firstName} {lastName}"; }
        }
        public bool IsActive
        {
            get { return isActive;}
            set
            {
                isActive = value;
                OnPropertyChanged("IsActive");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String propertyName)
        {
            if(propertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                
            }
        }
        public override string ToString()
        {
            return FullName;
        }



    }
}
