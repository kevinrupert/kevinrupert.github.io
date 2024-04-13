$('.content-container').waypoint(function() {
  $('body').toggleClass('dark');
}, {offset: '50%' });

// var [block1, block2, block3, block4, block5, block6, block7, block8, block9, block10, block11] = ['.block-1-text', '.block-2-text', '.block-3-text', '.block-4-text', '.block-5-text', '.block-6-text', '.block-7-text', '.block-8-text', '.block-9-text', '.block-10-text', '.block-11-text'].map(selector => baffle(selector));

// var	characters = '░█▓ ▒ V█';
// var speed = '50';

// $('.block-1-text, .block-2-text, .block-3-text, .block-4-text, .block-5-text, .block-6-text, .block-7-text, .block-8-text, .block-9-text, .block-10-text, .block-11-text').hide();

// setTimeout(function() {
//   $('.block-1-text, .block-2-text, .block-3-text, .block-4-text, .block-5-text, .block-6-text, .block-7-text, .block-8-text, .block-9-text, .block-10-text, .block-11-text' ).show();
// }, 50);

// [block1, block2, block3, block4, block5, block6, block7, block8, block9, block10, block11].forEach(block => {
//   block.start().set({
//     characters: characters,
//     speed: speed
//   });
// });

// ['.grid-item-1', '.grid-item-2', '.grid-item-3', '.grid-item-4', '.grid-item-5', '.grid-item-6', '.grid-item-7', '.grid-item-8', '.grid-item-9', '.grid-item-10', '.grid-item-11'].forEach((item, index) => {
//   $(item).waypoint(function() {
//     window[`block${index + 1}`].reveal(500);
//     this.destroy();
//   }, {offset: 'bottom-in-view' });
// });

// var project = baffle('.project-text', {
//   characters: characters,
//   speed: speed
// })

// // var logo = baffle('.logo-text', {
// //   characters: characters,
// //   speed: speed
// // })

// $('.project-header-details').hide();

// project.start();

// setTimeout(function() {
//   $('.project-header-details').show();
// }, 50);

// setTimeout(function() {
//   project.reveal(500);
// }, 100);

// // $('.project-header-logo').hide();

// // logo.start();

// // setTimeout(function() {
// //   $('.project-header-logo').show();
// // }, 50);

// // setTimeout(function() {
// //   logo.reveal(500);
// // }, 100);

// // $('.project-header-logo').hover(function() {
// //   logo.start();
// // }, function() {
// //   logo.reveal(500);
// // });