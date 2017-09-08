// init Masonry

var $grid = $('.grid').masonry({
  itemSelector: '.grid-item',
  columnWidth: '.grid-sizer',
  percentPosition: true
});
// layout Masonry after each image loads
$grid.imagesLoaded().progress( function() {
  $grid.masonry('layout');
});

var posterCount = 12;
var postersLoaded = 0;

$('video').load(function () {
  postersLoaded++;
  if (postersLoaded = posterCount) {
    $grid.masonry('layout');
  }
});