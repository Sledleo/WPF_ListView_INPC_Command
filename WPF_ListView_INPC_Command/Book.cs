
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ListView_INPC_Command
{
    public class Book  : INotifyPropertyChanged
    {
        private int pages;
        private string title;

        public string Title { get => title; set { if (value != title) { title = value; PCh(); } } }

        public int Pages { get => pages;  set { if (value != pages) { pages = value; PCh(); } } }




        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        private void PCh([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
