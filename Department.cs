using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Department : ViewModelBase
    {
        private ObservableCollection<Position> positions;

        public Department(string depname)
        {
            Name = depname;
            positions = new ObservableCollection<Position>()
                {
                    new Position("TL"),
                    new Position("PM")
                };
        }
        public ObservableCollection<Position> Positions
        {
            get
            {
                return positions;
            }
            set
            {
                positions = value;
                OnPropertyChanged("Positions");
            }
        }
        public string Name
        {
            get;
            set;
        }
    }
}
