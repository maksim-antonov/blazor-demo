function applyCarousel() {
  waitForCarousel('.ms-category-block').then((elm) => {
    const carouselBlock = $('.ms-category-block')
    const carouselSpeed = Number.parseInt(carouselBlock.attr('data-carousel-speed'))

    carouselBlock.owlCarousel({
      margin: 24, // margin in pixels, lib makes it responsive
      loop: true,
      dots: false,
      nav: false,
      smartSpeed: 1500, // sliding speed
      autoplay: true,
      autoplayTimeout: carouselSpeed,
      autoplayHoverPause: true,
      items: 3, // default value of items count
      responsiveClass: true,
      responsive: { // same thing as items count but responsive
        0: {
          items: 1
        }, // from 0px to 420px screen width
        420: {
          items: 2
        },
        768: {
          items: 2
        },
        992: {
          items: 3
        },
        1200: {
          items: 3
        }, // from 1200px to 1400px screen width
        1400: {
          items: 3
        }
      }
    });
  })
}

/* 
* Func for blazor not breaking js
* 
*/
function waitForCarousel(selector) {
  return new Promise(resolve => {
    if (document.querySelector(selector)) {
      return resolve(document.querySelector(selector));
    }

    const observer = new MutationObserver(mutations => {
      if (document.querySelector(selector)) {
        resolve(document.querySelector(selector));
        observer.disconnect();
      }
    });

    observer.observe(document.body, {
      childList: true,
      subtree: true
    });
  });
}