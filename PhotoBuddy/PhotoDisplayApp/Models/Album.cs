using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDisplayApp.ViewModels
{
    public class Album
    {
        IEnumerable<Photo> photos;
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public bool IsPrivate { get; set; }
        public void GetPhotosAsync() { }
        public void AddPhotoAsync() { }
        public void DeletePhotoAsync() { }
        
    }
}
