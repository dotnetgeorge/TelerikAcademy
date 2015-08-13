window.onload = function() {

	var paper = new Raphael(0, 0, 700, 700);

	var centerX = 350;
	var centerY = 350;

	for(var i = 0; i < 7200; i++) {
		var angle = 0.01 * i;

		var x = centerX + (4 * angle) * Math.cos(angle);
		var y = centerY + (4 * angle) * Math.sin(angle);

		paper.circle(x, y, 1);
	}
};