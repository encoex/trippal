using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using PhotoDisplayApp.ViewModels;
using System.Diagnostics;

namespace PhotoDisplayApp
{

    public partial class AlbumsViewPage : PhoneApplicationPage
    {
        private AlbumsViewModel albumsViewModel;
        public AlbumsViewPage()
        {
            InitializeComponent();
            Loaded += AlbumsViewPage_Loaded;
        }

        private void AlbumsViewPage_Loaded(object sender, RoutedEventArgs e)
        {
            albumsViewModel = new AlbumsViewModel();
            albumsViewModel.LoadDataAsync();

            DataContext = albumsViewModel;
        }

        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("item selected at index: {0}", 1);
        }
    }
}