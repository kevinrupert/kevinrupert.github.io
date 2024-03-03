$('.content-container').waypoint(function() {
  $('body').toggleClass('dark');
}, {offset: '50%' });

var [block1, block2, block3, block4, block5, block6] = ['.block-1-text', '.block-2-text', '.block-3-text', '.block-4-text', '.block-5-text', '.block-6-text'].map(selector => baffle(selector));

var	characters = '░█▓ ▒ W█';
var speed = '50';

[block1, block2, block3, block4, block5, block6].forEach(block => {
  block.start().set({
    characters: characters,
    speed: speed
  });
});

['.grid-item-1', '.grid-item-2', '.grid-item-3', '.grid-item-4', '.grid-item-5', '.grid-item-6'].forEach((item, index) => {
  $(item).waypoint(function() {
    window[`block${index + 1}`].reveal(500);
    this.destroy();
  }, {offset: 'bottom-in-view' });
});



