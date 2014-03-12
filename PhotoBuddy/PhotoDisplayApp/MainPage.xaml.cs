using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhotoDisplayApp.Resources;
using PhotoDisplayApp.ViewModels;
using System.Diagnostics;

namespace PhotoDisplayApp
{
    using System.Diagnostics.CodeAnalysis;

    public partial class MainPage : PhoneApplicationPage
    {

        private PhotosViewModel viewModel;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1126:PrefixCallsCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        protected async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel = new PhotosViewModel();
            await viewModel.LoadData();

            DataContext = viewModel;
        }

        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LongListSelector selector = sender as LongListSelector;
            if (selector == null)
                return;

            Photo selectedPhoto = selector.SelectedItem as Photo;
            if (selectedPhoto == null)
                return;

            string navTo = string.Format(
                "/SlideViewPage.xaml?selectedUri={0}",
                selectedPhoto.SourceUrl);

            NavigationService.Navigate(new Uri(navTo, UriKind.RelativeOrAbsolute));

            selector.SelectedItem = null; // resetting the selected Item
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}