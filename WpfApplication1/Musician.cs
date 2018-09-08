using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace WpfApplication1
{
    public class Musician : INotifyPropertyChanged, ICloneable
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

        public object Clone() {
            return new Musician {
                FirstName = this.FirstName,
                LastName = this.LastName,
                IsActive = this.IsActive
            };
        }

        public void Clear() {
            FirstName = string.Empty;
            LastName = string.Empty;
            IsActive = false;
        }

        public void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            return FullName;
        }
    }
}
