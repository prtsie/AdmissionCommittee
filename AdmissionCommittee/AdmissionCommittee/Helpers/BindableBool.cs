using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Helpers
{
    public sealed class BindableBool : INotifyPropertyChanged
    {
        private bool value;

        public bool Value
        {
            get => value;
            set
            {
                if (value != this.value)
                {
                    this.value = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
