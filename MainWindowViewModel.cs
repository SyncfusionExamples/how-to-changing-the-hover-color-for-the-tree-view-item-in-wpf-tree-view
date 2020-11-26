using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Department> departments;

        public MainWindowViewModel()
        {
            Departments = new ObservableCollection<Department>()
                {
                    new Department("DotNet"),
                    new Department("PHP")
                };
        }

        public ObservableCollection<Department> Departments
        {
            get
            {
                return departments;
            }
            set
            {
                departments = value;
                OnPropertyChanged("Departments");
            }
        }
    }
}
