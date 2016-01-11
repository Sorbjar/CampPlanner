using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CampPlanner.Models.Database.Generic
{
    public class Statefull : INotifyPropertyChanged
    {
        public State State { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
