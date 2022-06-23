using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageCache.ViewModels
{
    public class ImageCachingViewModel : BaseViewModel
    {
        public UriImageSource Image { get; set; } =
            new UriImageSource
            {
                Uri = new Uri("https://image.webcamromania.ro/camera/045/snap/cam_share.1655814608.jpg"),
                CacheValidity = new TimeSpan(0, 0, 1, 0)
            };
    }
}
