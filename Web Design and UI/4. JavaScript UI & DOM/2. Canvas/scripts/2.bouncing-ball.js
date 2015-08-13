(function(){
	var x = 0,
		y = 150,
		dx = 5,
		dy = 5;

	var canvas = document.getElementById("bouncing-ball");
	var	ctx = canvas.getContext("2d");

	function bouncingBallAnimation() {
		ctx.clearRect(0, 0, 800, 500);
		ctx.beginPath();

		ctx.fillStyle = "green";

		ctx.arc(x, y, 20, 0, 2*Math.PI);
		ctx.closePath();
		ctx.fill();

		if( x < 0 || x > 800) {
			dx = -dx;
		}
		if(y < 0 || y > 500) {
			dy = -dy;
			
		}
		x += dx;
		y += dy;
	}

	setInterval(bouncingBallAnimation, 10);
}());