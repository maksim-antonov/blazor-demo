using Demo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImagesController : ControllerBase
{
    private static readonly string CarouselId = Guid.NewGuid().ToString();

    private static readonly ImageCarousel Carousel = new ImageCarousel
    {
        Id = CarouselId,
        Images = new Image[]
        {
            new()
            {
                Id = 0,
                ImageTitle = "He is",
                ImageCarouselId = CarouselId,
                ImageData = System.IO.File.ReadAllBytes("./ImageFiles/heis.png")
            },
            new()
            {
                Id = 1,
                ImageTitle = "Profile Image",
                ImageCarouselId = CarouselId,
                ImageData = System.IO.File.ReadAllBytes("./ImageFiles/ava.png")
            },
            new()
            {
                Id = 2,
                ImageTitle = "A nice dev",
                ImageCarouselId = CarouselId,
                ImageData = System.IO.File.ReadAllBytes("./ImageFiles/nicedev.png")
            },
            new()
            {
                Id = 3,
                ImageTitle = "You need",
                ImageCarouselId = CarouselId,
                ImageData = System.IO.File.ReadAllBytes("./ImageFiles/youneed.png")
            },
            new()
            {
                Id = 4,
                ImageTitle = "Hiring me is a nice idea",
                ImageCarouselId = CarouselId,
                ImageData = System.IO.File.ReadAllBytes("./ImageFiles/hiremenow.png")
            },
        }
    };
    
    private readonly ILogger<ImagesController> _logger;

    public ImagesController(ILogger<ImagesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("ImageCarousel")]
    public ActionResult<ImageCarousel> GetImageCarousel()
    {
        var carousel = new ImageCarousel
        {
            Id = Carousel.Id,
            Images = Carousel.Images,
            CarouselSpeed = Random.Shared.Next(3, 12) * 100
        };

        return carousel;
    }
}