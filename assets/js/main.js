$('.content-container').waypoint(function() {
  $('body').toggleClass('dark');
}, {offset: '50%' });

var block1 = baffle('.block-1-text');
var	block2 = baffle('.block-2-text');
var	block3 = baffle('.block-3-text');
var	block4 = baffle('.block-4-text');

var	characters = '░█▓ ▒W';
var speed = '70';

[block1, block2, block3, block4].forEach(block => {
  block.start().set({
    characters: characters,
    speed: speed
  });
});

['.grid-item-1', '.grid-item-2', '.grid-item-3', '.grid-item-4'].forEach((item, index) => {
  $(item).waypoint(function() {
    window[`block${index + 1}`].reveal(500);
    this.destroy();
  }, {offset: 'bottom-in-view' });
});



