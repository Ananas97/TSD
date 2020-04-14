using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Books
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new BooksModel();
            InitializeComponent();
            Format.Items.Add(BookFormat.EBook);
            Format.Items.Add(BookFormat.PaperBack);
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            BooksModel model = DataContext as BooksModel;
            BookFormat format = new BookFormat();
            if (Format.SelectedItem == null) {
                MessageBox.Show("Put in valid data", "Invalid data", MessageBoxButton.OK);
                return;
            }
            if (Format.SelectedItem.Equals("EBook"))
             {
                    format = BookFormat.EBook;
             }
            else if (Format.SelectedItem.Equals("Paper"))
             {
                    format = BookFormat.PaperBack;
             }
    
            Id.Content = "";
            Title.Text = "";
            Author.Text = "";
            Year.Text = "";
            IsRead.IsChecked = false;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation Dialog", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                BooksModel model = DataContext as BooksModel;

                for (int i = 0; i < model.Books.Count(); i++)
                {
                    if (model.Books[i].Id.ToString() == Id.Content.ToString())
                    {
                        model.Books.RemoveAt(i);
                        Id.Content = "";
                        Title.Text = "";
                        Author.Text = "";
                        Year.Text = "";
                        IsRead.IsChecked = false;
                        break;
                    }
                }
            }
        }
    }
}
