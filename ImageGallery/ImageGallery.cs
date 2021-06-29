using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGallery
{
    class ImageGallery
    {
        Iphotos _photos;
        public ImageGallery(Iphotos _photos)
        {
            this._photos = _photos;
        }
        public void Share()
        {
            _photos.Send();

        }
    }
}
