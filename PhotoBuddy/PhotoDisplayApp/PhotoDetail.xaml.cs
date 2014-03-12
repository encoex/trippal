using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhotoDisplayApp
{
    public partial class PhotoDetail : PhoneApplicationPage
    {
        public PhotoDetail()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(DataContext == null)
            {
                string selectedIndexUri = "";
                NavigationContext.QueryString.TryGetValue("selectedUri", out selectedIndexUri);

                DataContext = selectedIndexUri;
            }
        }

    }
}