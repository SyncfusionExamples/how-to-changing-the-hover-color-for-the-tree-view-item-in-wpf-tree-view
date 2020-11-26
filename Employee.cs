using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Employee : ViewModelBase
    {
        private string _strEmployeeName = string.Empty;
        public string Name
        {
            get
            {
                return _strEmployeeName;
            }
            set
            {
                _strEmployeeName = value;
                OnPropertyChanged("EmployeeName");
            }
        }

        public Employee(string employeename)
        {
            Name = employeename;
        }
    }
}
