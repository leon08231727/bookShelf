using BookShelf.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfApp1.Model
{
    /// <summary>
    /// bookSearch.xaml の相互作用ロジック
    /// </summary>
    public partial class bookSearch : Window
    {
        public bookSearch()
        {
            InitializeComponent();
        }

        private void get(object sender, RoutedEventArgs e)
        {

        }

        private void OnSearchButonClick(object sender, RoutedEventArgs e)
        {
            string searchWord = this.searchWord.Text;
            bookApiClient bookApiClient = new bookApiClient();
            bookApiClient.getBookData(searchWord);

        }
    }
}
