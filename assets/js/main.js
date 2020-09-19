$('.menu-icon').click(function() {
    if (document.getElementById("menu").classList.contains('open')) {
      $('.menu, .icon-container').removeClass('open');
      const body = document.body;
      const scrollY = body.style.top;
      body.style.position = '';
      body.style.top = '';
      window.scrollTo(0, parseInt(scrollY || '0') * -1);
      $('.model').removeClass('overflow');
    }
    else {
      $('.menu, .icon-container').addClass('open');
      const scrollY = document.documentElement.style.getPropertyValue('--scroll-y');
      const body = document.body;
      body.style.position = 'fixed';
      body.style.top = `-${scrollY}`;
      $('.model').addClass('overflow');
    }
    $('.menu-icon').removeClass('highlight');
  }
);

window.addEventListener('scroll', () => {
  document.documentElement.style.setProperty('--scroll-y', `${window.scrollY}px`);
});

$('.animation-group').waypoint(function() {
  $(this.element).find('.animate-fade, .animate-fade-up, .animate-scale, .animate-width').addClass('animated');
}, {offset: '90%' });

$('.animate-fade, .animate-fade-up, .animate-scale, .animate-width').waypoint(function() {
  $(this.element).addClass('animated');
}, {offset: '90%' });

// var myElement = $('.13-17');

// $(window).on('scroll', function() {
//     var st = $(this).scrollTop();
//     myElement.css({
//         'opacity' : 1 - st/600
//     });
// });

$('.archive-grid').waypoint(function() {
  $('.archive-title-text').toggleClass('dark');
}, {offset: '50%' });

$('.news-link').click(function() {
    $('.image-1, .image-2').addClass('swap');
    $(this).addClass('active');
    $('.stories-link').removeClass('active');
  }
);

$('.stories-link').click(function() {
    $('.image-1, .image-2').removeClass('swap');
    $(this).addClass('active');
    $('.news-link').removeClass('active');
  }
);