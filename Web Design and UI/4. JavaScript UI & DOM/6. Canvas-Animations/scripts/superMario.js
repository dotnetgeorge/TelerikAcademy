window.onload = function() {
	"use strict";

	var stage = new Kinetic.Stage({
		container: 'container',
		width: 14400,
		height: 960
	});

	var layer = new Kinetic.Layer();

	var img = new Image();

	img.onload = function() {
		var superMario = new Kinetic.Sprite({
			x: 450,
			y: 600,
			image: img,
			animation: 'idle',
			animations: {
				idle: [
					340, 980, 170, 250,
					1130, 1040, 180, 200
				],
				move: [
					560, 985, 240, 260,
					25, 970, 235, 265,
					960, 660, 200, 220
				]
			},
			frameRate: 2,
			frameIndex: 0
		});

		layer.add(superMario);

		stage.add(layer);

		superMario.start();

		var frameCount = 0;

		superMario.on('frameIndexChange', function(evt) {
			if(superMario.animation() === 'move' && ++frameCount > 3) {
				superMario.animation('idle');
				superMario.scaleX(1);
				frameCount = 0;
			}
		});

		function onKeyDown(evt) {
			switch(evt.keyCode) {
				case 37:
					superMario.setX(superMario.attrs.x -= 50);
					superMario.attrs.animation = "move";
					break;
				case 39:
					superMario.setX(superMario.attrs.x += 50);
					superMario.attrs.animation = "move";
					break;
			}
		}

		window.addEventListener('keydown', onKeyDown);
	};

	img.src = "images/super-mario-sprite.png";

	var paper = new Raphael(0, 0, 1440, 960);

	paper.image('images/super-mario-background.png', 0, 0, 1440, 960);
}