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

namespace PhotoDisplayApp
{
    public partial class AlbumContentPage : PhoneApplicationPage
    {
        private PhotosViewModel photosViewModel;

        public AlbumContentPage()
        {
            InitializeComponent();
            Loaded += AlbumContentPage_Loaded;            
        }

        void AlbumContentPage_Loaded(object sender, RoutedEventArgs e)
        {
            if(photosViewModel == null)
            {
                photosViewModel = new PhotosViewModel();
            }

            if(!photosViewModel.IsDataLoaded)
            {
                photosViewModel.LoadDataAsync();
                DataContext = photosViewModel;
            }          
        }
    }
}