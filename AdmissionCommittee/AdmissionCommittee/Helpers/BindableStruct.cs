using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Helpers
{
    public sealed class BindableStruct<T> : INotifyPropertyChanged
        where T : struct
    {
        private T value;

        public T Value
        {
            get => value;
            set
            {
                if (!value.Equals(this.value))
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
