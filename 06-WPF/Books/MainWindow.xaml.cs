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
            if (Format.SelectedItem == null || Author.Text == "" || Title.Text == "" || Year.Text == "")
            {
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

            model.Books.Add(new Book(model.Books[model.Books.Count() - 1].Id + 1)
            {
                Author = Author.Text,
                Format = format,
                IsRead = (bool)IsRead.IsChecked,
                Title = Title.Text,
                Year = int.Parse(Year.Text)
            });

            Id.Content = "";
            Title.Text = "";
            Author.Text = "";
            Year.Text = "";
            IsRead.IsChecked = false;
        }

        private void ShowDetailsBasedUponSelection(object sender, SelectionChangedEventArgs e)
        {

            ListBox listBox = (ListBox)sender;
            object selectedBook = listBox.SelectedItem;
            ListBoxItem selectedItemBox = listBox.ItemContainerGenerator.ContainerFromItem(selectedBook) as ListBoxItem;
            if (selectedItemBox != null)
            {
                Book selected = selectedItemBox.DataContext as Book;
                Id.Content = selected.Id;
                Title.Text = selected.Title;
                Author.Text = selected.Author;
                Year.Text = selected.Year.ToString();
                IsRead.IsChecked = selected.IsRead;
                Format.SelectedItem = selected.Format;
            }
            else
            {
                return;
            }
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            if (Id.Content != null)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to edit this item?", "Save Confirmation Dialog", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    BooksModel model = DataContext as BooksModel;

                    for (int i = 0; i < model.Books.Count(); i++)
                    {
                        if (model.Books[i].Id.ToString() == Id.Content.ToString())
                        {

           
                            model.Books[i].Author = Author.Text.ToString();
                            if (Format.SelectedItem.Equals("EBook"))
                            {
                                model.Books[i].Format= BookFormat.EBook;
                            }
                            else if (Format.SelectedItem.Equals("Paper"))
                            {
                                model.Books[i].Format = BookFormat.PaperBack;
                            }
                            model.Books[i].IsRead = (bool)IsRead.IsChecked;
                            model.Books[i].Title = Title.Text.ToString();
                            model.Books[i].Year = int.Parse(Year.Text);
                            break;
                        }
                    }
                }
            }
            else 
            {
                return;
            }
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
