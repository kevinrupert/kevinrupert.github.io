$('.animation-group').waypoint(function() {
  $(this.element).find('.animate-fade, .animate-fade-up, .grow').addClass('animated');
}, {offset: '90%' });

$('.animate-fade, .animate-fade-up, .animate-fade-2, .grow').waypoint(function() {
  $(this.element).addClass('animated');
}, {offset: '90%' });