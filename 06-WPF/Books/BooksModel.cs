using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class BooksModel
    {
            public ObservableCollection<Book> Books { get; private set; }
            public BooksModel()
            {
            Books = new ObservableCollection<Book>();
            List<Book> BooksList = MyBookCollection.GetMyCollection();
            for (int i = 0; i < BooksList.Count; i++)
            {
                Book book = BooksList[i];
                Books.Add(book);
            }
        }
    }
}
