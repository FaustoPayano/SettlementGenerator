using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementGenerator.HelpMenu {
    public class HelpMenuItem : INotifyPropertyChanged {
        public string Name { get; set; }

        public string Content { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged() {
            return args => PropertyChanged?.Invoke(this, args);
        }
    }

}
