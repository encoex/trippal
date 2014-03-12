using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using PhotoDisplayApp.ViewModels;

namespace PhotoDisplayApp
{
    public partial class SlideViewPage : PhoneApplicationPage
    {
        public SlideViewPage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                var viewModel = new PhotosViewModel();
                await viewModel.LoadData();

                DataContext = viewModel.Collection.photo;
            }
        }
    }
}