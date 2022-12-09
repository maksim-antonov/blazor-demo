function applyCarousel() {
  waitForCarousel('.owl-carousel').then((elm) => {
    setTimeout(function() {
      $('.owl-carousel').owlCarousel({
        autoPlay: 5000,
        stopOnHover: true,
        singleItem: true
      });
    }, 10);
  })
}

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