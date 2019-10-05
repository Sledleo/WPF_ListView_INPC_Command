
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_ListView_INPC_Command
{
    public class MainWindowModel 
    {
        public string Title { get { return "ListView - App"; } }
        int iPages = 1;
        public ObservableCollection<Book> Books { get; private set; }


        public MainWindowModel()
        {
            Books = new ObservableCollection<Book>
            {
                new Book{Title = "Qwerty", Pages = 100 },
                new Book{Title = "Asdf", Pages = 200 }
            };

        }



        private ICommand changeCommand;

        public ICommand ChangeCommand
        {
            get
            {
                return changeCommand ?? (changeCommand = new RelayCommand( obj =>
                    {
                        Books.Add(new Book { Title = "Zzz", Pages = iPages });
                        ++iPages;
                        ++Books.First().Pages;
                    }
                ));
            }
        }

    }
}
