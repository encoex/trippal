using PhotoDisplayApp.Connect;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDisplayApp.ViewModels
{
    public class PhotosViewModel
    {
        private ObservableCollection<Photo> photos;

        public string AlbumTitle { get; set; }
        public int AlbumId { get; set; }
        public bool IsDataLoaded { get; set; }

        internal void LoadDataAsync()
        {

        }        
    }
}
