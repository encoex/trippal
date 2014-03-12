using PhotoDisplayApp.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDisplayApp.ViewModels
{
    public class PhotosViewModel
    {
        public string Title { get; set; }

        public PhotoCollection Collection { get; set; } // the collection of example photos
        public PhotoCollection Checkins { get; set; }
        public PhotoData Data { get; set; }  


        public bool IsDataLoaded { get; set; }

        public async Task LoadData()
        {            
            this.Title = "My Trip";

            this.Collection = await CreatePhotoCollection();
            this.Collection.Title  = "Awesome Trip Photos";
            IsDataLoaded = true;
        }

        private async Task<PhotoCollection> CreatePhotoCollection()
        {      
            var newCollection = new PhotoCollection();
            newCollection.Title = "Bla";

            this.Data = await BackendQuery.GetPhotosAsync(); // get photos
            if (Data.stat == "ok")
            {
                newCollection = Data.photos;
            }

            //newCollection.photo.Add(new Photo() { Owner = "Yigit", SourceUrl = "http://www.itusozluk.com/image/nils-ve-ucan-kaz_33735.jpg" });

            return newCollection;
        }

        private async Task GetFlickrPhotos()
        {
            this.Data = await BackendQuery.GetPhotosAsync().ConfigureAwait(false); // get photos
            if (Data.stat == "ok")
            {
                Collection = Data.photos;
            }
        }
    }
}
