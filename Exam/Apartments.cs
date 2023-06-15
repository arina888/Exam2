using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Apartment : INotifyPropertyChanged
    {
        public string Address { get; set; }
        public string Category { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public int Rooms { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
