using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Position : ViewModelBase
    {
        private ObservableCollection<Employee> employees;

        public Position(string positionname)
        {
            Name = positionname;
            employees = new ObservableCollection<Employee>()
                {
                    new Employee("Employee1"),
                    new Employee("Employee2"),
                    new Employee("Employee3")
                };
        }

        public ObservableCollection<Employee> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
                OnPropertyChanged("Employees");
            }
        }

        public string Name
        {
            get;
            set;
        }
    }
}
