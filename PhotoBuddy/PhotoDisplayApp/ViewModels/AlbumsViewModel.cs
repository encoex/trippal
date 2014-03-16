using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDisplayApp.ViewModels
{
    public class AlbumsViewModel
    {
        private ObservableCollection<Album> albums;

        public void CreateAlbumAsync(){ }
        public void DeleteAlbumAsync() { }

        public void MakeAlbumPublicAsync() { }

        public void MakeAlbumPrivateAsync() { }

        public void ShareAlbum() { }

        public void GetAlbumIdAsync() { }


        /// <summary>
        /// Get availabel albums from backend
        /// </summary>
        internal void LoadDataAsync()
        {

        }
    }
}
