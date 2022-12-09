namespace Demo.Shared;

public class ImageCarousel
{
    public ImageCarousel()
    {
    }

    public ImageCarousel(string id, ICollection<Image> images)
    {
        Id = id;
        Images = images;
    }

    public string Id { get; set; }
    public int CarouselSpeed { get; set; }
    public ICollection<Image> Images { get; set; }
}