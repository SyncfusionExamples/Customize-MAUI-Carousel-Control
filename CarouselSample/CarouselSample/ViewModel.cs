using Syncfusion.Maui.Carousel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarouselSample
{
    public class ViewModel
    {
        public List<SfCarouselItem> CarouselItems { get; set; }
        public ViewModel()
        {
            CarouselItems = new List<SfCarouselItem>();
            CarouselItems.Add(new SfCarouselItem() { ImageName = "argentina.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "austria.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "barcelona.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "brazil.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "canada.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "colombia.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "dubai.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "france.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "germany.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "india.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "italy.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "japan.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "kremlin.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "switzerland.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "sydney.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "thailand.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "turkey.jpg" });
            CarouselItems.Add(new SfCarouselItem() { ImageName = "usa.jpg" });
        }
    }
}
