using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace PhotoDisplayApp.ViewModels
{
    using System.Collections.ObjectModel;

    public class PhotoCollection
    {
        public string Title { get; set; }
        public ObservableCollection<Photo> photo { get; set; }        

        public int page { get; set; }
        public int pages { get; set; }
        public int perpage { get; set; }
        public string total { get; set; }



        public PhotoCollection()
        {
            photo = new ObservableCollection<Photo>();
        }
    }
}
