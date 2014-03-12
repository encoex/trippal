using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDisplayApp.ViewModels
{
    public class Photo
    {
        private string PhotoUrl = "http://farm{0}.staticflickr.com/{1}/{2}_{3}";

        private string sourceUrl;
        public string Owner { get; set; }
        public string SourceUrl {
            get
            {
               FormPhotoUr();
                return sourceUrl+"_n.jpg";
            }
            set
            {
                sourceUrl = value;
            }
        }

        public string id { get; set; }
        public string owner { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public string title { get; set; }
        public int ispublic { get; set; }
        public int isfriend { get; set; }
        public int isfamily { get; set; }

        public void FormPhotoUr()
        {
            this.sourceUrl = string.Format(PhotoUrl, this.farm, this.server, this.id, this.secret);
        }
    }
}
